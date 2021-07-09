using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required(ErrorMessage = "Enter TAx Id")]
        [StringLength(15,MinimumLength = 8, ErrorMessage = "Tax Id does not meet length requirements")]
        public string TaxId { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)] 
        public string firstname { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string lastname { get; set; }
        
        public string Address { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)] 
        [EmailAddress]
        public string emailAddress { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)] 
        [Phone]
        public string contact_number { get; set; }

        public virtual List<Booking> Bookings { get; set; }
    }
}