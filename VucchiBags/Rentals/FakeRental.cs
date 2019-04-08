using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using VucchiBags.Customers;
using VucchiBags.Products;
using VucchiBags.Reservations;

namespace VucchiBags.Rentals
{
    class FakeRental : Faker<Rental>
    {
        public FakeRental(Reservation reservation)
        {
            RuleFor(o => o.ReservationID, f => reservation.Id);
        }
    }
}
