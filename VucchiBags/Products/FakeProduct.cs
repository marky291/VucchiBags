using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace VucchiBags.Products
{
    class FakeProduct : Faker<Product>
    {
        public FakeProduct()
        {
            RuleFor(o => o.Category, f => f.Random.Enum<ProductCategory>());
            RuleFor(o => o.Brand, f => f.Random.Enum<ProductBrand>());
            RuleFor(o => o.Status, f => f.Random.Enum<ProductStatus>());
            RuleFor(o => o.ShortDescription, f => f.Lorem.Sentence(100));
            RuleFor(o => o.ShortDescription, f => f.Lorem.Paragraph(3));
            RuleFor(o => o.Value, f => f.Random.Decimal(100, 1250));
        }
    }
}
