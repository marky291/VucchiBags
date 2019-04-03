using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VucchiBags.Products
{
    enum ProductStatus { Rented, Available, Damaged }

    enum ProductCategory { Bag, Belts, Shoes }

    [Serializable]
    class Product : Entity
    {
        public ProductCategory Category { get; set; }

        public string Model { get; set; }

        public ProductStatus Status { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public decimal Value { get; set; }

        public string ImageName { get; set; }
    }
}