namespace KestenApp.Web.ViewModels.Garden
{
    public class GardenDetailsModel
    {
        public string GardenName { get; set; } = null!;
        public Guid GardenId { get; set; }
        public string UserName { get; set; } = null!;
        public Guid UserId { get; set; }
        public bool HideArchiveButton { get => !IsActive; }
        public bool HideRestoreButton { get => !HideArchiveButton; }
        public bool HidePublishButton { get => IsPublished || !IsActive; }
        public bool HideUnpublishButton { get => !IsPublished || !IsActive; }
        public IEnumerable<string> GardenVarieties
        {
            get
            {
                return YearVarieties
                    .GroupBy(s => s.VarietyName)
                    .Select(g => g.Key)
                    .OrderBy(x => x)
                    .ToList();
            }
        }
        public IEnumerable<int?> GardenYears
        {
            get
            {
                return YearVarieties
                    .GroupBy(s => s.Year)
                    .Select(g => g.Key)
                    .OrderBy(x => x)
                    .ToList();
            }
        }
        public IEnumerable<YearSpecimens> YearVarieties { get; set; } = Enumerable.Empty<YearSpecimens>();
        public bool IsActive { get; set; }
        public bool IsPublished { get; set; }
    }
}
