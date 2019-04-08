using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VucchiBags.Customers;
using VucchiBags.Rentals;

namespace VucchiBags.Reservations
{

    enum ReservationStatus { Active, Cancelled, Suspended }

    [Serializable]
    class Reservation : Entity
    {
        public int CustomerID { get; set; }

        public int RentalID { get; set; }

        public DateTime CollectDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public decimal DailyRate { get; set; }

        public int DiscountPercent { get; set; }

        public decimal BalanceDue { get; set; }

        public ReservationStatus Status { get; set; }

        // @todo: this must include the discount percent
        public decimal TotalPrice => NumberDaysReserved * DailyRate;

        public int NumberDaysReserved => (int)ReturnDate.Date.Subtract(CollectDate.Date).TotalDays;
    }
}
