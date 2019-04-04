using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.DataSets;

namespace VucchiBags.Customers
{
    class FakeCustomer : Faker<Customer>
    {
        public FakeCustomer()
        {
            RuleFor(o => o.Forename, f => f.Name.FirstName());
            RuleFor(o => o.Surname, f => f.Name.LastName());
            RuleFor(o => o.Address, f => f.Address.FullAddress());
            RuleFor(o => o.Birthdate, f => f.Date.Past());
            RuleFor(o => o.Rating, f => f.Random.Enum<CustomerRating>());
            RuleFor(o => o.PhoneNumber, f => f.Phone.PhoneNumber());
            RuleFor(o => o.PassportNumber, f => f.Name.Random.Replace("##########"));
        }
    }
}
