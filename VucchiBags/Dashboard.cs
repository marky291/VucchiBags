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
using VucchiBags.Reservations;

namespace VucchiBags
{
    internal partial class Dashboard : Form
    {
        private readonly FileStorage _storage;

        /**
         * Dashboard accepts a file storage for data loading and saving
         */
        public Dashboard(FileStorage fileStorage)
        {
            InitializeComponent();

            this._storage = fileStorage;
        }

        /**
         * Debug button to check loading of data
         */
        private void DebugButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"Customers: {this._storage.Customers.Count}, Rentals: {this._storage.Rentals.Count}, Reservations: {this._storage.Reservations.Count}, Products: {this._storage.Products.Count}", "Data Load Debug");
        }

        /**
         * k00233238
         *
         * Mark Hester (Reservations)
         */
        private void ReservationButton_Click(object sender, EventArgs e)
        {
            Form ReservationIndexForm = new ReservationManagement(this, _storage);

            this.Hide();
            
            ReservationIndexForm.Show();
        }
    }
}
