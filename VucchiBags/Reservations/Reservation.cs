using System;
using Bogus.DataSets;
using VucchiBags.Products;

namespace VucchiBags.Reservations
{
    enum ReservationStatus { Active, Cancelled, Suspended, Completed }

    [Serializable]
    class Reservation : Entity
    {
        public int CustomerID { get; set; }

        public int ProductID { get; set; }

        public DateTime CollectDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public decimal CurrentPayedAmount { get; set; }

        public int DiscountPercent { get; set; }

        public ReservationStatus Status { get; set; }

        /**
         * Times need to be defaulted to now, since 2001 is not a good default.
         */
        public Reservation()
        {
            CollectDate = DateTime.Now;

            ReturnDate = DateTime.Now;
        }
       
        /**
         * Since we hold the dates, and the product holds the price.
         * We get the total by multiplying the two
         * this means we need to pass the product since
         * this class was told to use lookups in which
         * this class does not hold the reference to the
         * product... instead it needs to be passed the reference. o.O
         */
        public decimal TotalPriceOf(Product product)
        {
            if (DiscountPercent > 0)
            {
                return FinalRateOfReservation(product) - (int)(FinalRateOfReservation(product) * DiscountAsDouble());
            }

            return FinalRateOfReservation(product);
        }

        /**
         * Get the number of data, if incorrect, return 0 days.
         */
        public int NumberDaysReserved()
        {
            if (CollectDate > ReturnDate)
                return 0;

            return (int)ReturnDate.Date.Subtract(CollectDate.Date).TotalDays;
        }

        /**
         * same here, we need the product reference for the calculation.
         */
        public decimal BalanceDueOn(Product product)
        {
            return TotalPriceOf(product) - CurrentPayedAmount;
        }

        public int FinalRateOfReservation(Product product)
        {
            return NumberDaysReserved() * product.DailyRateAddedEuros();
        }

        public double DiscountAsDouble()
        {
            return (double) DiscountPercent / 100;
        }
    }
}
