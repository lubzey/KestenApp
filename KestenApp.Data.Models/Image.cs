namespace KestenApp.Data.Models
{
    public class Image
    {
        public Guid ImageId { get; set; }
        public string FileName { get; set; } = default!;
        public List<Variety> Varieties { get; set; } = new List<Variety>();
    }
}
