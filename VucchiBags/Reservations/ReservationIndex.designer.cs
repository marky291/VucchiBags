namespace VucchiBags.Reservations
{
    partial class ReservationIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationIndex));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.ReservationIndexLabel = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ReservationsGrid = new System.Windows.Forms.DataGridView();
            this.ReservationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AvailabilityReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1258, 104);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(24, 106);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(6);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(1218, 31);
            this.SearchBar.TabIndex = 2;
            // 
            // ReservationIndexLabel
            // 
            this.ReservationIndexLabel.AutoSize = true;
            this.ReservationIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationIndexLabel.Location = new System.Drawing.Point(16, 17);
            this.ReservationIndexLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ReservationIndexLabel.Name = "ReservationIndexLabel";
            this.ReservationIndexLabel.Size = new System.Drawing.Size(201, 36);
            this.ReservationIndexLabel.TabIndex = 47;
            this.ReservationIndexLabel.Text = "Reservations";
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ReturnButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReturnButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.Color.Black;
            this.ReturnButton.Location = new System.Drawing.Point(808, 765);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(6);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(164, 63);
            this.ReturnButton.TabIndex = 6;
            this.ReturnButton.Text = "&Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.Location = new System.Drawing.Point(546, 765);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(164, 63);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "&Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.ForeColor = System.Drawing.Color.Black;
            this.ViewButton.Location = new System.Drawing.Point(284, 765);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(6);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(164, 63);
            this.ViewButton.TabIndex = 4;
            this.ViewButton.Text = "&View";
            this.ViewButton.UseVisualStyleBackColor = false;
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.ForeColor = System.Drawing.Color.Black;
            this.CreateButton.Location = new System.Drawing.Point(22, 762);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(6);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(164, 63);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "&Create";
            this.CreateButton.UseVisualStyleBackColor = false;
            // 
            // ReservationsGrid
            // 
            this.ReservationsGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ReservationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationNumber,
            this.CustomerName,
            this.ProductCategory,
            this.Rate,
            this.NumberOfDays,
            this.Price});
            this.ReservationsGrid.Location = new System.Drawing.Point(24, 148);
            this.ReservationsGrid.Margin = new System.Windows.Forms.Padding(6);
            this.ReservationsGrid.Name = "ReservationsGrid";
            this.ReservationsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReservationsGrid.Size = new System.Drawing.Size(1286, 604);
            this.ReservationsGrid.TabIndex = 42;
            this.ReservationsGrid.TabStop = false;
            // 
            // ReservationNumber
            // 
            this.ReservationNumber.HeaderText = "Reservation Number";
            this.ReservationNumber.Name = "ReservationNumber";
            this.ReservationNumber.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // ProductCategory
            // 
            this.ProductCategory.HeaderText = "Product Category";
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // NumberOfDays
            // 
            this.NumberOfDays.HeaderText = "Number Of Days";
            this.NumberOfDays.Name = "NumberOfDays";
            this.NumberOfDays.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 58);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // AvailabilityReport
            // 
            this.AvailabilityReport.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AvailabilityReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.AvailabilityReport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AvailabilityReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvailabilityReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailabilityReport.ForeColor = System.Drawing.Color.Black;
            this.AvailabilityReport.Location = new System.Drawing.Point(1070, 765);
            this.AvailabilityReport.Margin = new System.Windows.Forms.Padding(6);
            this.AvailabilityReport.Name = "AvailabilityReport";
            this.AvailabilityReport.Size = new System.Drawing.Size(234, 63);
            this.AvailabilityReport.TabIndex = 7;
            this.AvailabilityReport.Text = "&Availability Report";
            this.AvailabilityReport.UseVisualStyleBackColor = false;
            // 
            // ReservationIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 846);
            this.Controls.Add(this.AvailabilityReport);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.ReservationIndexLabel);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ReservationsGrid);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReservationIndex";
            this.Text = "ReservationManagement";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label ReservationIndexLabel;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DataGridView ReservationsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AvailabilityReport;
    }
}