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
using VucchiBags.Products;

namespace VucchiBags.Reservations
{
    internal partial class ReservationIndex : Form
    {
        private FileStorage fileStorage;

        public ReservationIndex(ref FileStorage fileStorage)
        {
            InitializeComponent();

            this.fileStorage = fileStorage;

            for (int i = 0; i < fileStorage.Reservations.Count; i++)
            {
                Reservation reservation = fileStorage.Reservations.ElementAt(i);
                Customer customer = fileStorage.Customers.Where(x => x.Id == reservation.CustomerID).First();
                Rental rental = fileStorage.Rentals.Where(x => x.Id == reservation.RentalID).First();
                Product product = fileStorage.Products.Where(x => x.Id == rental.ProductID).First();

                ReservationsGrid.Rows.Add(
                    reservation.Id.ToString(), //ID
                    customer.FullName.ToString(), // Customer name
                    product.Category.ToString(), // Product Category
                    "$"+reservation.DailyRate.ToString("#.##"), // daily rate
                    reservation.NumberDaysReserved, // days reserved
                    "$"+reservation.TotalPrice.ToString("#.##") // total price value.
                    );
            }
        }
    }
}
