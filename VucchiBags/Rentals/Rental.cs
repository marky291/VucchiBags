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
        // reservation holds customers and products.
        // this allows lookups and access to those 
        // attributes belonging to those models
        public int ReservationID { get; set; }
    }
}
