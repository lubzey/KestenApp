namespace KestenApp.Web.ViewModels.Specimen
{
    using KestenApp.Data.Models;

    public class SpecimenDetailsModel
    {
        public Guid SpecimenId { get; }
        public string SpecimenName { get; } = null!;
        public int Row { get; }
        public int Column { get; }
        public Variety? Variety { get; }
        public Garden? Garden { get; }
        public ApplicationUser User { get; }
        public int? Elevation { get; }
        public DateTime? PlantedOnDate { get; }
        public DateTime? SowedOnDate { get; }
        public bool HideArchiveButton { get; }
        public bool HideRestoreButton { get; }

        public SpecimenDetailsModel(Specimen specimen)
        {
            SpecimenId = specimen.SpecimenId;
            SpecimenName = specimen.Name;

            Row = specimen.SpecimenPosition?.Row ?? 0;
            Column = specimen.SpecimenPosition?.Column ?? 0;

            Variety = specimen.Variety;
            Garden = specimen.Garden;
            User = specimen.User;

            Elevation = specimen.Elevation;
            PlantedOnDate = specimen.PlantedOnDate;
            SowedOnDate = specimen.SowedOnDate;

            HideArchiveButton = !specimen.IsActive;
            HideRestoreButton = !HideArchiveButton;
        }
    }
}
