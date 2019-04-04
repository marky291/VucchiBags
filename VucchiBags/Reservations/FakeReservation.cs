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
            RuleFor(o => o.CustomerID, f => Customer.Id);
            RuleFor(o => o.RentalID, f => Rental.Id);
            RuleFor(o => o.ReturnDate, f => f.Date.Soon());
            RuleFor(o => o.CollectDate, f => f.Date.Past());
            RuleFor(o => o.DailyRate, f => f.Random.Decimal(1, 100));
            RuleFor(o => o.TotalPrice, f => f.Random.Decimal(100, 1000));
            RuleFor(o => o.DiscountPercent, f => f.Random.Number(0, 15));
        }
    }
}
