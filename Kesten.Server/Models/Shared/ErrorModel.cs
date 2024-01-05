namespace Kesten.Server.Models.Shared
{
    public class ErrorModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}