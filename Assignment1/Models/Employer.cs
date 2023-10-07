using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    /// <summary>
    /// Represents an employer entity with various attributes
    /// </summary>
    public class Employer
    {
        /// <summary>
        /// Gets or sets the unique identifier 
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        [Required]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the phone number
        /// </summary>
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the website URL of the employer.
        /// </summary>
        [Required]
        [Url]
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets the incorporated date
        /// </summary>
        [Display(Name = "Incorporated Date")]
        [DataType(DataType.Date)]
        public DateTime? IncorporatedDate { get; set; }
    }
}
