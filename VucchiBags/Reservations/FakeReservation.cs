using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.DataSets;
using VucchiBags.Rentals;
using VucchiBags.Customers;

namespace VucchiBags.Reservations
{
    class FakeReservation : Faker<Reservation>
    {
        public FakeReservation(Rental Rental, Customer Customer)
        {

            DateTime CollectDate = FakerHub.Date.Between(DateTime.Now.AddYears(-1), DateTime.Now.AddYears(1));
            DateTime ReturnDate = CollectDate.AddDays(FakerHub.Random.Number(0, 30));

            RuleFor(o => o.CustomerID, f => Customer.Id);
            RuleFor(o => o.RentalID, f => Rental.Id);
            RuleFor(o => o.ReturnDate, f => ReturnDate);
            RuleFor(o => o.CollectDate, f => CollectDate);
            RuleFor(o => o.DailyRate, f => f.Random.Decimal(1, 42));
            RuleFor(o => o.TotalPrice, f => f.Random.Decimal(750, 1000));
            RuleFor(o => o.Status, f => f.Random.Enum<ReservationStatus>());
            RuleFor(o => o.DiscountPercent, f => f.Random.Number(0, 15));
            RuleFor(o => o.BalanceDue, f => f.Random.Decimal(0, 600));
        }
    }
}
