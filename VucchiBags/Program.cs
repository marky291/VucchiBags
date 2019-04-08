using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VucchiBags.Reservations;
using VucchiBags.Customers;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using VucchiBags.Products;
using VucchiBags.Rentals;

namespace VucchiBags
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // create the storage container.
            FileStorage storage = new FileStorage();

            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            GenerateStorageContainer(ref storage);

            // run the dashboard with the storage.
            Application.Run(new Dashboard(storage));
        }

        static void ClearStorage(ref FileStorage fileStorage)
        {
            fileStorage.Customers.Clear();
            fileStorage.Rentals.Clear();
            fileStorage.Reservations.Clear();
            fileStorage.Products.Clear();

            return;
        }

        static void GenerateStorageContainer(ref FileStorage fileStorage)
        {
            // random class.
            Random random = new Random();

            // clear current storage in case one exists.
            ClearStorage(ref fileStorage);

            // generate connected object data.

            // make a random number of customers.
            for (int i = 0; i < random.Next(25, 100); i++)
            {
                fileStorage.Customers.Add(new FakeCustomer());
            }

            // lets make a random number of products.
            for (int i = 0; i < random.Next(25, 100); i++)
            {
                fileStorage.Products.Add(new FakeProduct());
            }

            // lets make a random number of reservation.
            for (int i = 0; i < random.Next(25, 100); i++)
            {
                // a reservation needs a random customer.
                Customer Customer = fileStorage.Customers.ElementAt(random.Next(1, fileStorage.Customers.Count()));

                // a reservation needs a random product.
                Product product = fileStorage.Products.ElementAt(random.Next(1, fileStorage.Products.Count()));

                // create the rental
                fileStorage.Reservations.Add(new FakeReservation(product, Customer));
            }

            // lets make a random number of rentals.
            for (int i = 0; i < random.Next(25, 100); i++)
            {
                // a rental needs a random product.
                Reservation Reservation = fileStorage.Reservations.ElementAt(random.Next(1, fileStorage.Reservations.Count()));

                // create the rental
                fileStorage.Rentals.Add(new FakeRental(Reservation));
            }
        }
    }
}
