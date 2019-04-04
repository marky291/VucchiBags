using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using VucchiBags.Customers;
using VucchiBags.Products;

namespace VucchiBags.Rentals
{
    class FakeRental : Faker<Rental>
    {
        public FakeRental(Customer customer, Product product)
        {
            RuleFor(o => o.CustomerID, f => customer.Id);
            RuleFor(o => o.ProductID, f => product.Id);
            RuleFor(o => o.DailyRate, f => f.Random.Decimal(0, 200));
            RuleFor(o => o.ETA, f => f.Date.Soon());
            RuleFor(o => o.ETT, f => f.Date.Past());
            RuleFor(o => o.TotalPrice, f => f.Random.Decimal(0, 200));
        }
    }
}
