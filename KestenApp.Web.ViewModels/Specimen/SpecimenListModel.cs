﻿namespace KestenApp.Web.ViewModels.Specimen
{
    public class SpecimenListModel
    {
        public readonly List<string> HeaderTitles = new List<string>
        {
            "Identifier",
            "Year",
            "Garden",
            "Row",
            "Column"
        };

        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public int CountPerPage { get; set; }
        public IEnumerable<SpecimenSummaryModel> Specimens { get; set; } = Enumerable.Empty<SpecimenSummaryModel>();
    }
}
