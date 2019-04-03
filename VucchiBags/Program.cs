using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VucchiBags.Reservations;
using VucchiBags.Customers;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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
            FileStorage storage = new FileStorage();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Sample());

            Customer customer = new FakeCustomer();
        }
    }
}
