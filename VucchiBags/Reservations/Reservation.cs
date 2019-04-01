using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VucchiBags.Customers;
using VucchiBags.Rentals;

namespace VucchiBags.Reservations
{
    class Reservation : Entity
    {
        public ICustomer Customer { get; set; }

        public decimal DailyRate { get; set; }

        public IRental Rental { get; set; }

        public DateTime ETA { get; set; }

        public DateTime ETT { get; set; }

        public decimal TotalPrice { get; set; }

        public int DiscountPercent { get; set; }
    }
}
