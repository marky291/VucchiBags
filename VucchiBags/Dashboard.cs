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
        private FileStorage storage;

        public Dashboard(FileStorage fileStorage)
        {
            InitializeComponent();

            this.storage = fileStorage;
        }

        private void DebugButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Customers: {this.storage.Customers.Count}, Rentals: {this.storage.Rentals.Count}, Reservations: {this.storage.Reservations.Count}, Products: {this.storage.Products.Count}", "Data Load Debug");
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            Form ReservationIndexForm = new ReservationManagement(ref this.storage);

            ReservationIndexForm.Show();
        }
    }
}
