using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VucchiBags.Rentals
{
    [Serializable]
    class Rental : Entity
    {
        public int CustomerID { get; set; }

        public int ProductID { get; set; }

        public decimal DailyRate { get; set; }

        public DateTime ETA { get; set; }

        public DateTime ETT { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
