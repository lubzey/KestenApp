﻿namespace KestenApp.Services
{
    using Microsoft.EntityFrameworkCore;

    using KestenApp.Data;
    using KestenApp.Data.Enums;
    using KestenApp.Data.Models;
    using KestenApp.Services.Contracts;
    using KestenApp.Web.ViewModels.Garden;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class GardenServices : IGardenServices
    {
        private readonly KestenDbContext _context;

        public GardenServices(KestenDbContext context)
        {
            _context = context;
        }

        public async Task<GardenListModel> AllGardensAsync(
            SortingType sorting = SortingType.DateCreated,
            int currentPage = 1,
            int countPerPage = int.MaxValue,
            bool isPublished = true)
        {
            IQueryable<Garden> specimensQuery = _context
                .Gardens
                .Include(g => g.Specimens.Where(s => s.IsActive))
                    .ThenInclude(s => s.Variety)
                .Include(g => g.User)
                .Where(g => g.IsPublished == isPublished && g.IsActive)
                .AsNoTracking();

            specimensQuery = sorting switch
            {
                SortingType.Name => specimensQuery.OrderByDescending(c => c.Name),
                SortingType.DateCreated or _ => specimensQuery.OrderBy(c => c.DateCreated)
            };

            int totalCount = specimensQuery.Count();

            IEnumerable<Garden> gardens = await specimensQuery
                .Skip((currentPage - 1) * countPerPage)
                .Take(countPerPage)
                .ToListAsync();

            return new GardenListModel
            {
                TotalCount = totalCount,
                CurrentPage = currentPage,
                CountPerPage = countPerPage,
                Gardens = gardens.Select(v => ConstructGardenModel(v)).ToList()
            };
        }

        private GardenSummaryModel ConstructGardenModel(Garden g)
        {
            return new GardenSummaryModel
            {
                Garden = g,
                Specimens = g.Specimens,
                User = g.User
            };
        }

        public async Task<GardenDetailsModel> GetDetailsViewByIdAsync(Guid id, string userId)
        {
            Garden garden = await _context
                .Gardens
                .Include(g => g.Specimens.Where(s => s.IsActive && s.Row > 0 && s.Column > 0))
                    .ThenInclude(s => s.Variety)
                .Include(g => g.User)
                .AsNoTracking()
                .FirstAsync(g => g.GardenId == id
                    && (g.IsPublished || g.UserId.ToString() == userId));

            GardenDetailsSchemaModel[,] specimensSchema = new GardenDetailsSchemaModel[garden.TotalRows, garden.TotalColumns];

            garden.Specimens
                .ToList()
                .ForEach(sp =>
                {
                    specimensSchema[sp.Row - 1, sp.Column - 1] = new GardenDetailsSchemaModel
                    {
                        Name = sp.Variety != null
                            ? sp.Variety.Name
                            : sp.Name,
                        Year = sp.Year,
                        SpecimenId = sp.SpecimenId,
                        BackgroundColor = GetBackgroundColorByPollen(sp.Variety?.PollenType)
                    };
                });

            List<GardenDetailsYearSpecimens> yearVarieties = garden.Specimens
                .GroupBy(s => new { s.Year, s.Variety?.Name })
                .Select(g => new GardenDetailsYearSpecimens
                {
                    Year = g.Key.Year,
                    VarietyName = g.Key.Name ?? "",
                    Count = g.Count()
                }).ToList();

            return new GardenDetailsModel
            {
                GardenName = garden.Name,
                GardenId = garden.GardenId,
                UserName = garden.User.UserName,
                GardenUserId = garden.User.Id,
                CurrentUserId = userId,
                IsActive = garden.IsActive,
                IsPublished = garden.IsPublished,
                TotalRows = garden.TotalRows,
                TotalColumns = garden.TotalColumns,
                YearVarieties = yearVarieties,
                Specimens = specimensSchema
            };
        }

        private string GetBackgroundColorByPollen(PollenType? pollenType)
        {
            switch (pollenType)
            {
                case PollenType.NotSelected:
                    return "table-secondary";

                case PollenType.Sterile:
                case null:
                    return "table-danger";

                case PollenType.Medium:
                    return "table-warning";

                case PollenType.Abundant:
                    return "table-success";

                default:
                    return "table-secondary";
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetUserGardensAsync(string userId)
        {
            List<SelectListItem> dropdownList = new List<SelectListItem>();

            //Display all user gardens
            IEnumerable<Garden> allUserGardens = await _context.Gardens
                .Where(g => g.UserId.ToString() == userId && g.IsActive)
                .AsNoTracking()
                .ToListAsync();

            if (allUserGardens.Count() > 1)
            {
                //Add not selected option
                dropdownList.Add(new SelectListItem { Selected = true });
            }

            IEnumerable<SelectListItem> gardensList = allUserGardens
                .OrderBy(v => v.Name)
                .Select(v => new SelectListItem
                {
                    Value = v.GardenId.ToString(),
                    Text = v.Name
                });

            dropdownList.AddRange(gardensList);

            return dropdownList;
        }

        public async Task<bool> IsUserGardenValidAsync(Guid gardenId, string userId)
        {
            bool isUserGardenValid = await _context.Gardens
                .AnyAsync(g => g.UserId.ToString() == userId
                    && g.GardenId == gardenId
                    && g.IsActive);

            return isUserGardenValid;
        }

        public async Task<bool> IsPositionTakenAsync(Guid gardenId, int row, int column)
        {
            bool isPositionTaken = await _context.Gardens
                .AnyAsync(g =>
                    g.GardenId == gardenId
                    && g.Specimens.Any(sp => sp.Row == row && sp.Column == column));

            return isPositionTaken;
        }

        public async Task<bool> IsPositionValidAsync(Guid gardenId, int row, int column)
        {
            bool isPositionValid = await _context.Gardens
                .AnyAsync(g =>
                    g.GardenId == gardenId
                    && g.TotalRows >= row
                    && g.TotalColumns >= column);

            return isPositionValid;
        }

        public async Task<GardenDetailsModel> GetGardenWithUsedPositionsAsync(Guid gardenId)
        {
            Garden garden = await _context
                .Gardens
                .Include(g => g.Specimens.Where(s => s.IsActive && s.Row > 0 && s.Column > 0))
                    .ThenInclude(s => s.Variety)
                .AsNoTracking()
                .SingleAsync(g => g.GardenId == gardenId);

            GardenDetailsSchemaModel[,] specimensSchema = new GardenDetailsSchemaModel[garden.TotalRows, garden.TotalColumns];

            garden.Specimens
                .ToList()
                .ForEach(sp =>
                {
                    specimensSchema[sp.Row - 1, sp.Column - 1] = new GardenDetailsSchemaModel
                    {
                        Name = sp.Variety != null
                            ? sp.Variety.Name
                            : sp.Name,
                        Year = sp.Year,
                        SpecimenId = sp.SpecimenId,
                        BackgroundColor = GetBackgroundColorByPollen(sp.Variety?.PollenType)
                    };
                });

            return new GardenDetailsModel
            {
                GardenName = garden.Name,
                GardenId = garden.GardenId,
                TotalRows = garden.TotalRows,
                TotalColumns = garden.TotalColumns,
                YearVarieties = garden.Specimens
                    .GroupBy(s => new { s.Year, s.Variety?.Name })
                    .Select(g => new GardenDetailsYearSpecimens
                    {
                        Year = g.Key.Year,
                        VarietyName = g.Key.Name ?? "",
                        Count = g.Count()
                    }).ToList(),
                Specimens = specimensSchema
            };
        }

        public async Task<bool> UpdateGardenAsync(Guid id, string userId, FormModel model)
        {
            Garden garden = await _context
                .Gardens
                .SingleAsync(g => g.GardenId == id
                    && g.UserId.ToString() == userId);

            garden.Name = model.GardenName;
            garden.TotalRows = model.TotalRows;
            garden.TotalColumns = model.TotalColumns;

            return await this._context.SaveChangesAsync() > 0;
        }

        public async Task<Guid> CreateGardenAsync(string userId, FormModel model)
        {
            Garden garden = new Garden
            {
                Name = model.GardenName,
                TotalRows = model.TotalRows,
                TotalColumns = model.TotalColumns,
                UserId = Guid.Parse(userId)
            };

            await this._context.AddAsync(garden);
            await _context.SaveChangesAsync();

            return garden.GardenId;
        }

        public async Task ArchiveByIdAsync(Guid id, bool restore = false)
        {
            Garden garden = await this._context
                .Gardens
                .FirstAsync(h => h.GardenId == id);

            if (restore)
            {
                garden.IsActive = true;
            }
            else
            {
                garden.IsActive = false;
            }

            await this._context.SaveChangesAsync();
        }
    }
}