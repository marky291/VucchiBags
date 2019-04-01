using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using VucchiBags.Customers;
using VucchiBags.Rentals;
using VucchiBags.Reservations;

namespace VucchiBags
{
    [Serializable]
    class FileStorage
    {
        public List<Rental> Rentals = new List<Rental>();
        public List<Customer> Customers = new List<Customer>();
        public List<Reservation> Reservations = new List<Reservation>();

        // construct == load on entry
        public FileStorage()
        {
            FileStream fs = new FileStream("storage.dat", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            if (fs.Length > 0)
            {
                // deserialize the stored data for reading back to object.
                FileStorage Stored = (FileStorage)formatter.Deserialize(fs);

                // get the stored data back to class.
                this.Customers = Stored.Customers;
                this.Rentals = Stored.Rentals;
                this.Reservations = Stored.Reservations;

                foreach(Customer customer in this.Customers)
                {
                    Console.WriteLine("Customer ID: " + customer.id);
                }

                Console.WriteLine($"Total Customers loaded {Stored.Customers.Count}");
            }

            fs.Close();
        }

        // destruct == save on exit
        ~FileStorage()
        {
            FileStream fs = new FileStream("storage.dat", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fs, this);

            fs.Close();
        }
    }
}
