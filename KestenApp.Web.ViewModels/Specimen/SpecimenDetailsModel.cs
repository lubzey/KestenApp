namespace KestenApp.Web.ViewModels.Specimen
{
    using KestenApp.Data.Models;

    public class SpecimenDetailsModel
    {
        public Guid SpecimenId { get; }
        public string SpecimenName { get; } = null!;
        public SpecimenPosition? Position { get; }
        public Variety? Variety { get; }
        public Garden? Garden { get; }
        public ApplicationUser User { get; }
        public int? Elevation { get; }
        public DateTime? PlantedOnDate { get; }
        public DateTime? SowedOnDate { get; }
        public DateTime? GraftedOnDate { get; }
        public bool HideArchiveButton { get; }
        public bool HideRestoreButton { get; }

        public SpecimenDetailsModel(Specimen specimen)
        {
            SpecimenId = specimen.SpecimenId;
            SpecimenName = specimen.Name;

            Position = specimen.SpecimenPosition;

            Variety = specimen.Variety;
            Garden = specimen.Garden;
            User = specimen.User;

            Elevation = specimen.Elevation;
            PlantedOnDate = specimen.PlantedOnDate;
            SowedOnDate = specimen.SowedOnDate;
            GraftedOnDate = specimen.GraftedOnDate;

            HideArchiveButton = !specimen.IsActive;
            HideRestoreButton = !HideArchiveButton;
        }
    }
}
