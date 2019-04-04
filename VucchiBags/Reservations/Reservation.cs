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

        public DateTime CollectDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public decimal DailyRate { get; set; }

        public int DiscountPercent { get; set; }

        public decimal TotalPrice
        {
            get => NumberDaysReserved * DailyRate;
        }

        public int NumberDaysReserved
        {
            get => (int)ReturnDate.Date.Subtract(CollectDate.Date).TotalDays;
        }
    }
}
