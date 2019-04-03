using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using VucchiBags.Rentals;
using VucchiBags.Customers;

namespace VucchiBags.Reservations
{
    class FakeReservation : Faker<Reservation>
    {
        public FakeReservation(Rental rental, Customer customer)
        {
            RuleFor(o => o.CustomerID, f => customer.Id);
            RuleFor(o => o.RentalID, f => rental.Id);
            RuleFor(o => o.CollectionDate, f => f.Date.Between(DateTime.Now.AddMonths(-1), DateTime.Now.AddMonths(1)));
            RuleFor(o => o.DueDate, f => f.Date.Between(DateTime.Now.AddMonths(-1), DateTime.Now.AddMonths(1)));
            RuleFor(o => o.DailyRate, f => f.Random.Decimal(0, 540));
            RuleFor(o => o.DiscountPercent, f => f.Random.Decimal(0, 15));
            RuleFor(o => o.TotalPrice, f => f.Random.Decimal(0, 50000));
        }
    }
}
