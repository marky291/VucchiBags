using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VucchiBags.Customers;
using VucchiBags.Rentals;

namespace VucchiBags.Reservations
{
    internal partial class ReservationView : Form
    {

        private FileStorage storage;

        public ReservationView(ref FileStorage fileStorage, Reservation reservation)
        {
            InitializeComponent();

            this.storage = fileStorage;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            // generate an object to handle the randomness.
            Random rand = new Random();

            // a fake reservation needs a random existing customer.
            Customer Customer = this.storage.Customers.ElementAt(rand.Next(1, storage.Customers.Count()));

            // a fake reservation needs a random existing rental.
            Rental Rental = this.storage.Rentals.ElementAt(rand.Next(1, storage.Rentals.Count()));

            // create the fake reservation.
            Reservation Reservation = new FakeReservation(Rental, Customer);

            // display it to the form.
            CustomerNameText.Text = $"{Customer.Forename} {Customer.Surname}";
        }
    }
}
