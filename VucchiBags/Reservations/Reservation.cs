using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VucchiBags.Customers;
using VucchiBags.Rentals;

namespace VucchiBags.Reservations
{
    [Serializable]
    class Reservation : Entity
    {
        public int CustomerID { get; set; }

        public int RentalID { get; set; }

        public DateTime CollectionDate { get; set; }

        public DateTime DueDate { get; set; }

        public decimal DailyRate { get; set; }

        public decimal TotalPrice { get; set; }

        public int DiscountPercent { get; set; }
    }
}
