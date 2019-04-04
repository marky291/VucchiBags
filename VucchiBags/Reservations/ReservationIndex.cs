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
    internal partial class ReservationIndex : Form
    {
        private FileStorage fileStorage;

        public ReservationIndex(ref FileStorage fileStorage)
        {
            InitializeComponent();

            this.fileStorage = fileStorage;
        }
    }
}
