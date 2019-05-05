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

        private readonly Dashboard _dashboardForm;

        private enum ReservationFilters { Future, Current, Past, All }

        /**
         * Generation of the reservation form, means we show all the current and future
         * reservations, we also accept the file storage which holds and saves all data
         * related to this application.
         */
        public ReservationManagement(Dashboard dashboardForm, FileStorage fileStorage)
        {
            InitializeComponent();

            _fileStorage = fileStorage;

            _dashboardForm = dashboardForm;

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

            Debug.Assert(Query != null, nameof(Query) + " != null");

            if (Query.Text.Length != 0)
            {
                GenerateReservationGridUsing("Searched", _fileStorage.Reservations.Where(x => x.Id.ToString().Contains(Query.Text)).ToList());

                return;
            }

            ReservationFilterList.SelectedIndex = (int)ReservationFilters.Future;
        }

        /**
         * When we close the management form we want to
         * show the currently hidden dashboardForm screen
         * since that exists in memory still and is just hidden.
         */
        private void ReservationManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            _dashboardForm.Show();
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
                Product product = _fileStorage.Products.First(x => x.Id == reservation.ProductID);

                // Add this reservation and its associated objects to the grid.
                _grid.Rows.Add(
                    reservation.Id.ToString(), // Reservation Number
                    customer.FullName.ToString(), // Customer name
                    reservation.Status, // Reservation Status
                    product.Category.ToString(), // Product Category
                    "$" + product.DailyRateAddedEuros().ToString("#.##"), // Rental Rate)
                    reservation.NumberDaysReserved(), // Days Reserved (No. Days
                    "$" + reservation.TotalPriceOf(product).ToString("#.##"), // Payment Amount
                    "$" + reservation.BalanceDueOn(product).ToString("#.##"),// Payment due
                    reservation.CollectDate.ToShortDateString(), // collection date
                    reservation. ReturnDate.ToShortDateString() // return date
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

        private void CreateBookingForm_Click(object sender, EventArgs e)
        {
            ReservationEditor editor = new ReservationEditor(this, _fileStorage, new Reservation());

            editor.Show();

            this.Hide();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            int reservationId = Convert.ToInt32(ReservationsGrid.Rows[ReservationsGrid.SelectedRows[0].Index].Cells[0].Value.ToString());

            Reservation reservation = _fileStorage.Reservations.First(x => x.Id == reservationId);

            ReservationEditor editor = new ReservationEditor(this, _fileStorage, reservation);

            editor.Show();

            this.Hide();
        }

        private void ReservationsGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewButton_Click(this, EventArgs.Empty);
        }

        private void AnalysisReportButton_Click(object sender, EventArgs e)
        {
            ReservationAnalysis ReservationAnalysis = new ReservationAnalysis(_fileStorage);

            ReservationAnalysis.Show();
        }
    }
}
;