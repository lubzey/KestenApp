namespace KestenApp.Web.ViewModels.User
{
    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
    using System.ComponentModel.DataAnnotations;
    using static KestenApp.Common.EntityValidationConstants.UserConstants;

    public class IndexViewModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string? Username { get; set; } = null!;

        [EmailAddress]
        [Required]
        public string Email { get; set; } = null!;        

        [StringLength(NameMaxLength)]
        public string? DisplayName { get; set; } = null!;

        //Display roles if any
        [ValidateNever]
        public string Roles { get; set; } = null!;

        //Display success/error
        [ValidateNever]
        public string StatusMessage { get; set; } = null!;
    }
}
