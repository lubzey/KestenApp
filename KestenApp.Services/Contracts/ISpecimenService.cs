﻿using KestenApp.Data.Enums;
using KestenApp.Data.Models;
using KestenApp.Web.ViewModels.Specimen;

namespace KestenApp.Services.Contracts
{
    public interface ISpecimenService
    {
        Task<SpecimenListModel> AllSpecimenAsync(VarietySortingType sorting = VarietySortingType.DateCreated, int currentPage = 1, int countPerPage = int.MaxValue, bool isPublished = true);
    }
}