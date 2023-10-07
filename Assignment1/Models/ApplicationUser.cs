using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

// UserName, Email, and PhoneNumber already exisits in IdentityUser
namespace Assignment1.Models
{
    /// <summary>
    /// Represents an application 
    /// Inherits from the IdentityUser class
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        

        /// <summary>
        /// Gets or sets the birth date
        /// </summary>
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
    }
}
