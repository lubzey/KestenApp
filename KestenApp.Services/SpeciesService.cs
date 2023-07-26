namespace KestenApp.Services
{
    using KestenApp.Data;
    using KestenApp.Data.Enums.EnumHelpers;
    using KestenApp.Data.Enums;
    using KestenApp.Data.Models;
    using KestenApp.Services.Contracts;
    using KestenApp.Web.ViewModels;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;

    public class SpeciesService : ISpeciesService
    {
        private readonly KestenDbContext dbContext;

        public SpeciesService(KestenDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Species>> AllSpecies()
        {
            return await this.dbContext
                .Species
                .ToArrayAsync();
        }

        //public IEnumerable<DropdownModel> MapDropdown<TEnum>()
        //{
        //    return EnumExtensions
        //        .GetEnumValuesCollection<TEnum>()
        //        .Select(p => new DropdownModel
        //        {
        //            Id = (int)(object)p,
        //            Name = p.ToString(),
        //            //Selected = pollenType == p
        //        }).ToList();
        //}
    }
}