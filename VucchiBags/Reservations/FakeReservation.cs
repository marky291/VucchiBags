using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.DataSets;
using VucchiBags.Rentals;
using VucchiBags.Customers;
using VucchiBags.Products;

namespace VucchiBags.Reservations
{
    class FakeReservation : Faker<Reservation>
    {
        public FakeReservation(Product Product, Customer Customer)
        {

            DateTime CollectDate = FakerHub.Date.Between(DateTime.Now.AddYears(-5), DateTime.Now.AddYears(5));
            DateTime ReturnDate = CollectDate.AddDays(FakerHub.Random.Number(0, 30));

            RuleFor(o => o.CustomerID, f => Customer.Id);
            RuleFor(o => o.ProductID, f => Product.Id);
            RuleFor(o => o.ReturnDate, f => ReturnDate);
            RuleFor(o => o.CollectDate, f => CollectDate);
            RuleFor(o => o.Status, f => f.Random.Enum<ReservationStatus>());
            RuleFor(o => o.DiscountPercent, f => f.Random.Number(0, 50));
            RuleFor(o => o.CurrentPayedAmount, f => f.Random.Decimal(0, 10));
        }
    }
}
