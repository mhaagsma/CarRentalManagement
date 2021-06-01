using System.Collections.Generic;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public virtual List<Booking> Bookings { get; set; }
    }
}