namespace KestenApp.Web.ViewModels.User
{
    using System.Collections.Generic;

    public class UsersListModel
    {
        public IEnumerable<UserSummaryModel> Users { get; set; } = null!;
    }
}
