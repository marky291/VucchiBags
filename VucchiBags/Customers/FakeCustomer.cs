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
            //
        }
    }
}
