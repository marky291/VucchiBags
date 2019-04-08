using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VucchiBags.Products
{
    enum ProductStatus { Rented, Available, Damaged }

    enum ProductCategory { Economy, Standard, Luxury, Special }

    enum ProductBrand { Nike, Addidas }

    [Serializable]
    class Product : Entity
    {
        public ProductCategory Category { get; set; }

        public ProductBrand Brand { get; set; }

        public ProductStatus Status { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public decimal Value { get; set; }


        public int DailyRateAddedEuros()
        {
            switch (Category)
            {
                case ProductCategory.Economy:
                    return 10;
                case ProductCategory.Standard:
                    return 20;
                case ProductCategory.Luxury:
                    return 30;
                case ProductCategory.Special:
                    return 40;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}