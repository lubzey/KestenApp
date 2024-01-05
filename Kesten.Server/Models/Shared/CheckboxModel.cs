namespace Kesten.Server.Models.Shared
{
    public class CheckboxModel
    {
        public int Id { get; set; }
        public string LabelName { get; set; } = null!;
        public bool IsChecked { get; set; }
    }
}
