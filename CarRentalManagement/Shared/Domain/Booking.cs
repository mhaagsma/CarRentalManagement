using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace CarRentalManagement.Shared.Domain
{
    public class Booking : BaseDomainModel, IValidatableObject
    {
        [Required]
        public int VehicleId { get; set; }

        [Required]
        public virtual Vehicle Vehicle { get; set; }
        [Required]
        [DataType(DataType.Date)] 
        public DateTime DateOut { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? DateIn { get; set; }
        public virtual Customer Customer { get; set;  }
        [Required] 
        public int CustomerID { get; set; }



        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateIn <= DateOut)
            {
                yield return new ValidationResult("Date In must be greater than Date Out", new [] {"DateIn"});
            }
        }
    }
}