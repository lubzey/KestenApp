using System.Data;

namespace KestenApp.Web.ViewModels.Garden
{
    public class GardenDetailsModel
    {
        public string GardenName { get; set; } = null!;
        public Guid GardenId { get; set; }
        public string UserName { get; set; } = null!;
        public Guid GardenUserId { get; set; }
        public bool HideArchiveButton { get => !IsActive; }
        public bool HideRestoreButton { get => !HideArchiveButton; }
        public bool HidePublishButton { get => IsPublished || !IsActive; }
        public bool HideUnpublishButton { get => !IsPublished || !IsActive; }
        public IEnumerable<string> GardenVarieties
        {
            get
            {
                var x = YearVarieties
                    .GroupBy(s => s.VarietyName)
                    .Select(g => g.Key)
                    .OrderBy(x => x)
                    .ToList();
                return x;
            }
        }
        public IEnumerable<int?> GardenYears
        {
            get
            {
                var x = YearVarieties
                    .GroupBy(s => s.Year)
                    .Select(g => g.Key)
                    .OrderBy(x => x)
                    .ToList();
                return x;
            }
        }
        public IEnumerable<GardenDetailsYearSpecimens> YearVarieties { get; set; } = Enumerable.Empty<GardenDetailsYearSpecimens>();
        public bool IsActive { get; set; }
        public bool IsPublished { get; set; }
        public int TotalRows { get; set; }
        public int TotalColumns { get; set; }
        public GardenDetailsSchemaModel[,] Specimens { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string CurrentUserId { get; set; } = null!;
    }
}
