namespace KestenApp.Web.ViewModels.User
{
    using System;

    public class UserSummaryModel
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
