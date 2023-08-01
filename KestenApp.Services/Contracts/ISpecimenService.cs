﻿using KestenApp.Data.Enums;
using KestenApp.Data.Models;
using KestenApp.Web.ViewModels.Specimen;

namespace KestenApp.Services.Contracts
{
    public interface ISpecimenService
    {
        Task<SpecimenListModel> AllSpecimensAsync(SortingType sorting = SortingType.DateCreated, int currentPage = 1, int countPerPage = int.MaxValue, bool isPublished = true);
        Task<SpecimenDetailsModel> GetDetailsViewByIdAsync(Guid id);
    }
}