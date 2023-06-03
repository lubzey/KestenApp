namespace KestenTestApp.Models.Repositories
{
    public interface IVarietyRepository
    {
        IEnumerable<Variety> AllVarieties { get; }

        Variety? GetPieById(int pieId);
        IEnumerable<Variety> SearchPies(string searchQuery);
    }
}