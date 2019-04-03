using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bogus;
using System.Threading.Tasks;
using Bogus.DataSets;

namespace VucchiBags.Products
{
    class FakeProducts : Faker<Product>
    {
        public FakeProducts()
        {

        }
    }
}
