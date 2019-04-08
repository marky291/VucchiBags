using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VucchiBags.Customers;
using VucchiBags.Rentals;
using VucchiBags.Products;


namespace VucchiBags.Reservations
{
    internal partial class ReservationManagement : Form
    {
        private readonly FileStorage _fileStorage;

        private readonly DataGridView _grid;

        private enum ReservationFilters { Future, Current, Past, All }

        /**
         * Generation of the reservation form, means we show all the current and future
         * reservations, we also accept the file storage which holds and saves all data
         * related to this application.
         */
        public ReservationManagement(ref FileStorage fileStorage)
        {
            InitializeComponent();

            _fileStorage = fileStorage;

            _grid = ReservationsGrid;

            CreateReservationFilterListings(Enum.GetValues(typeof(ReservationFilters)));
        }

        /**
         * Generate the listing filter combo box.
         */
        private void CreateReservationFilterListings(IEnumerable items)
        {
            foreach (ReservationFilters filter in items)
            {
                ReservationFilterList.Items.Add($@"{filter} Reservations");
            }

            ReservationFilterList.SelectedIndex = (int)ReservationFilters.Future;
        }

      
        /**
         * Remove all data from the grid.
         */
        private void SearchBarInput_TextChanged(object sender, EventArgs e)
        {
            var Query = sender as TextBox;

            if (Query.Text.Length != 0)
            {
                GenerateReservationGridUsing("Searched", _fileStorage.Reservations.Where(x => x.Id.ToString().Contains(Query.Text)).ToList());

                return;
            }

            ReservationFilterList.SelectedIndex = (int)ReservationFilters.Future;
        }

        /**
         * Apply DRY mechanics, allow passing of reservations that will generate the grid view list.
         */
        private void GenerateReservationGridUsing(string categoryTitle, List<Reservation> reservations)
        {
            _grid.Rows.Clear();

            ManageReservationsLabel.Text = $@"Manage {categoryTitle} Reservations";

            reservations.ForEach(reservation =>
            {
                Customer customer = _fileStorage.Customers.First(x => x.Id == reservation.CustomerID);
                Rental rental = _fileStorage.Rentals.First(x => x.Id == reservation.RentalID);
                Product product = _fileStorage.Products.First(x => x.Id == rental.ProductID);

                // Add this reservation and its associated objects to the grid.
                _grid.Rows.Add(
                    reservation.Id.ToString(), // Reservation Number
                    customer.FullName.ToString(), // Customer name
                    reservation.Status, // Reservation Status
                    product.Category.ToString(), // Product Category
                    "$" + reservation.DailyRate.ToString("#.##"), // Rental Rate)
                    reservation.NumberDaysReserved, // Days Reserved (No. Days
                    "$" + reservation.TotalPrice.ToString("#.##"), // Payment Amount
                    "$" + reservation.BalanceDue.ToString("#.##"),// Payment due
                    reservation.CollectDate.ToShortDateString(), // collection date
                    reservation.ReturnDate.ToShortDateString() // return date
                );
            });

            ReservationsShowingCounterLabel.Text = $@"Showing {reservations.Count} reservations";
        }

        /**
         * Filter the data-view reservations by user selection of the enum.
         */
        private void ReservationFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case (int)ReservationFilters.All:
                    GenerateReservationGridUsing("All", _fileStorage.Reservations);
                    break;

                case (int)ReservationFilters.Future:
                    GenerateReservationGridUsing("Future", _fileStorage.Reservations.Where(x => x.ReturnDate >= DateTime.Now.Date).ToList());
                    break;

                case (int)ReservationFilters.Current:
                    GenerateReservationGridUsing("Todays", _fileStorage.Reservations.Where(x => x.ReturnDate == DateTime.Now.Date).ToList());
                    break;

                case (int)ReservationFilters.Past:
                    GenerateReservationGridUsing("Past", _fileStorage.Reservations.Where(x => x.ReturnDate <= DateTime.Now.Date).ToList());
                    break;

                default:
                    Console.WriteLine(@"Error: Unable to load the filter for reservation selection.");
                    break;
            }
        }
    }
}
