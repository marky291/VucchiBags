namespace VucchiBags.Reservations
{
    partial class ReservationAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AnalysisChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ManageReservationsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AnalysisChart)).BeginInit();
            this.SuspendLayout();
            // 
            // AnalysisChart
            // 
            chartArea2.Name = "ChartArea1";
            this.AnalysisChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.AnalysisChart.Legends.Add(legend2);
            this.AnalysisChart.Location = new System.Drawing.Point(36, 103);
            this.AnalysisChart.Name = "AnalysisChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "test";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series2.YValuesPerPoint = 3;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.AnalysisChart.Series.Add(series2);
            this.AnalysisChart.Size = new System.Drawing.Size(1603, 822);
            this.AnalysisChart.TabIndex = 0;
            this.AnalysisChart.Text = "chart1";
            // 
            // ManageReservationsLabel
            // 
            this.ManageReservationsLabel.AutoSize = true;
            this.ManageReservationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageReservationsLabel.Location = new System.Drawing.Point(28, 34);
            this.ManageReservationsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ManageReservationsLabel.Name = "ManageReservationsLabel";
            this.ManageReservationsLabel.Size = new System.Drawing.Size(500, 44);
            this.ManageReservationsLabel.TabIndex = 48;
            this.ManageReservationsLabel.Text = "Reservations made annually";
            // 
            // ReservationAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 979);
            this.Controls.Add(this.ManageReservationsLabel);
            this.Controls.Add(this.AnalysisChart);
            this.Name = "ReservationAnalysis";
            this.Text = "ReservationAnalysis";
            ((System.ComponentModel.ISupportInitialize)(this.AnalysisChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart AnalysisChart;
        private System.Windows.Forms.Label ManageReservationsLabel;
    }
}