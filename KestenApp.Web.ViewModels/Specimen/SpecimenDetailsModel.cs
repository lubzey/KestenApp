﻿namespace KestenApp.Web.ViewModels.Specimen
{
    using KestenApp.Data.Models;

    public class SpecimenDetailsModel
    {
        public Guid SpecimenId { get; }
        public string? SpecimenName { get; } = null!;
        public Variety? Variety { get; }
        public Garden Garden { get; } = new Garden();
        public int Row { get; }
        public int Column { get; }
        public Guid UserId { get; }
        public int? Elevation { get; }
        public DateTime? PlantedOnDate { get; }
        public DateTime? SowedOnDate { get; }
        public DateTime? GraftedOnDate { get; }
        public bool HideArchiveButton { get; }
        public bool HideRestoreButton { get; }

        public SpecimenDetailsModel(Specimen? specimen)
        {
            if (specimen == null)
            {
                return;
            }

            SpecimenId = specimen.SpecimenId;
            SpecimenName = specimen.Name;

            Variety = specimen.Variety;
            Garden = specimen.Garden;
            Row = specimen.Row;
            Column = specimen.Column;
            UserId = specimen.UserId;

            Elevation = specimen.Elevation;
            PlantedOnDate = specimen.PlantedOnDate;
            SowedOnDate = specimen.SowedOnDate;
            GraftedOnDate = specimen.GraftedOnDate;

            HideArchiveButton = !specimen.IsActive;
            HideRestoreButton = !HideArchiveButton;
        }
    }
}
