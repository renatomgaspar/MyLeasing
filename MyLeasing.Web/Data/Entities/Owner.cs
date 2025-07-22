using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner : IEntity
    {
        public int Id { get; set; }


        [Required]
        [Display(Name = "Document*")]
        public string Document { get; set; }


        [Required]
        [Display(Name = "First Name*")]
        public string FirstName { get; set; }


        [Required]
        [Display(Name = "Last Name*")]
        public string LastName { get; set; }


        [Display(Name = "Fixed Phone")]
        [RegularExpression(@"^(\+?\d{1,4}[\s\-\.]?)?((\(?\d{1,4}\)?[\s\-\.]?)?[\d\s\-\.]{6,14})$", ErrorMessage = "Invalid Number")]
        public string? FixedPhone { get; set; }


        [Display(Name = "Cell Phone")]
        [RegularExpression(@"^(\+?\d{1,4}[\s\-\.]?)?((\(?\d{1,4}\)?[\s\-\.]?)?[\d\s\-\.]{6,14})$", ErrorMessage = "Invalid Number")]
        public string? CellPhone { get; set; }


        public string? Address { get; set; }
    }
}
