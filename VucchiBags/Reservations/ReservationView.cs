using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VucchiBags.Reservations
{
    internal partial class ReservationView : Form
    {
        public ReservationView(FileStorage fileStorage, Reservation reservation)
        {
            InitializeComponent();
        }
    }
}
