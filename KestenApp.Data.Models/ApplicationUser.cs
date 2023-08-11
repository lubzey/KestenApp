namespace KestenApp.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using static KestenApp.Common.EntityValidationConstants;

    public class ApplicationUser : IdentityUser<Guid>
    {
        /// <summary>
        /// This is custom user class that works with the default ASP.NET Core Identity.
        /// You can add additional info to the built-in users.
        /// </summary>
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
            this.Gardens = new HashSet<Garden>();
            this.Specimens = new HashSet<Specimen>();
        }

        [MaxLength(UserConstants.NameMaxLength)]
        public string? DisplayName { get; set; } = null!;

        public virtual ICollection<Garden> Gardens { get; private set; } = new HashSet<Garden>();
        public virtual ICollection<Specimen> Specimens { get; private set; } = new HashSet<Specimen>();
    }
}
