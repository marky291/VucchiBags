using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VucchiBags.Reservations
{
    internal partial class ReservationAnalysis : Form
    {
        private readonly ReservationManagement _previousFrom;

        private readonly FileStorage _storage;

        public ReservationAnalysis(FileStorage storage)
        {
            //_previousFrom = previousFrom;
            _storage = storage;
            InitializeComponent();

            CreateChartDataForFiveYears();
        }

        private void CreateChartDataForFiveYears()
        {
            for (int i = 0; i < 10; i++)
            {
                DateTime date = DateTime.Now.AddYears(-i+5).Date;

                int count = _storage.Reservations.Count(x => x.CollectDate.Year == date.Year);

                AnalysisChart.Series[0].Points.AddXY(date.Year, count);
            }
        }
    }
}
