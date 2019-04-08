namespace VucchiBags.Reservations
{
    partial class ReservationManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchBarInput = new System.Windows.Forms.TextBox();
            this.ManageReservationsLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.CreateBookingButton = new System.Windows.Forms.Button();
            this.ReservationsGrid = new System.Windows.Forms.DataGridView();
            this.ReservationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollectionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.AnalysisReportButton = new System.Windows.Forms.Button();
            this.ReservationsShowingCounterLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReservationFilterList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBarInput
            // 
            this.SearchBarInput.Location = new System.Drawing.Point(162, 56);
            this.SearchBarInput.Name = "SearchBarInput";
            this.SearchBarInput.Size = new System.Drawing.Size(838, 20);
            this.SearchBarInput.TabIndex = 2;
            this.SearchBarInput.TextChanged += new System.EventHandler(this.SearchBarInput_TextChanged);
            // 
            // ManageReservationsLabel
            // 
            this.ManageReservationsLabel.AutoSize = true;
            this.ManageReservationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageReservationsLabel.Location = new System.Drawing.Point(8, 16);
            this.ManageReservationsLabel.Name = "ManageReservationsLabel";
            this.ManageReservationsLabel.Size = new System.Drawing.Size(192, 24);
            this.ManageReservationsLabel.TabIndex = 47;
            this.ManageReservationsLabel.Text = "Manage Reservations";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.Location = new System.Drawing.Point(368, 541);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 33);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "No Row Selected";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.SystemColors.Control;
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.ForeColor = System.Drawing.Color.Black;
            this.ViewButton.Location = new System.Drawing.Point(190, 541);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(150, 33);
            this.ViewButton.TabIndex = 4;
            this.ViewButton.Text = "&View / Modify";
            this.ViewButton.UseVisualStyleBackColor = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // CreateBookingButton
            // 
            this.CreateBookingButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateBookingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBookingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBookingButton.ForeColor = System.Drawing.Color.Black;
            this.CreateBookingButton.Location = new System.Drawing.Point(12, 541);
            this.CreateBookingButton.Name = "CreateBookingButton";
            this.CreateBookingButton.Size = new System.Drawing.Size(150, 33);
            this.CreateBookingButton.TabIndex = 3;
            this.CreateBookingButton.Text = "&Create Booking";
            this.CreateBookingButton.UseVisualStyleBackColor = false;
            this.CreateBookingButton.Click += new System.EventHandler(this.CreateBookingForm_Click);
            // 
            // ReservationsGrid
            // 
            this.ReservationsGrid.AllowUserToAddRows = false;
            this.ReservationsGrid.AllowUserToDeleteRows = false;
            this.ReservationsGrid.AllowUserToResizeColumns = false;
            this.ReservationsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReservationsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ReservationsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReservationsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReservationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationNumber,
            this.CustomerName,
            this.Status,
            this.ProductCategory,
            this.RentalRate,
            this.NumberOfDays,
            this.Payable,
            this.BalanceDue,
            this.CollectionDate,
            this.ReturnDate});
            this.ReservationsGrid.GridColor = System.Drawing.SystemColors.Control;
            this.ReservationsGrid.Location = new System.Drawing.Point(12, 91);
            this.ReservationsGrid.MultiSelect = false;
            this.ReservationsGrid.Name = "ReservationsGrid";
            this.ReservationsGrid.ReadOnly = true;
            this.ReservationsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReservationsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReservationsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReservationsGrid.Size = new System.Drawing.Size(988, 433);
            this.ReservationsGrid.TabIndex = 42;
            this.ReservationsGrid.TabStop = false;
            this.ReservationsGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationsGrid_CellContentDoubleClick);
            // 
            // ReservationNumber
            // 
            this.ReservationNumber.HeaderText = "Reservation Number";
            this.ReservationNumber.Name = "ReservationNumber";
            this.ReservationNumber.ReadOnly = true;
            this.ReservationNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ReservationNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Full Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            this.Status.HeaderText = "Reservation Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Status.Width = 93;
            // 
            // ProductCategory
            // 
            this.ProductCategory.HeaderText = "Product Category";
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.ReadOnly = true;
            this.ProductCategory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProductCategory.Width = 86;
            // 
            // RentalRate
            // 
            this.RentalRate.HeaderText = "Product Rental Rate";
            this.RentalRate.MinimumWidth = 3;
            this.RentalRate.Name = "RentalRate";
            this.RentalRate.ReadOnly = true;
            this.RentalRate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RentalRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RentalRate.Width = 78;
            // 
            // NumberOfDays
            // 
            this.NumberOfDays.HeaderText = "Days of Reservation";
            this.NumberOfDays.Name = "NumberOfDays";
            this.NumberOfDays.ReadOnly = true;
            this.NumberOfDays.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumberOfDays.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NumberOfDays.Width = 80;
            // 
            // Payable
            // 
            this.Payable.HeaderText = "Total Payable Amount.";
            this.Payable.Name = "Payable";
            this.Payable.ReadOnly = true;
            this.Payable.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Payable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Payable.Width = 108;
            // 
            // BalanceDue
            // 
            this.BalanceDue.HeaderText = "Current Balance Due";
            this.BalanceDue.Name = "BalanceDue";
            this.BalanceDue.ReadOnly = true;
            this.BalanceDue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BalanceDue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BalanceDue.Width = 83;
            // 
            // CollectionDate
            // 
            this.CollectionDate.HeaderText = "Reservation Item Pickup Date";
            this.CollectionDate.Name = "CollectionDate";
            this.CollectionDate.ReadOnly = true;
            this.CollectionDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CollectionDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Reservation Item Return Date";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            this.ReturnDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ReturnDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Search Reservation Number:";
            // 
            // AnalysisReportButton
            // 
            this.AnalysisReportButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AnalysisReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalysisReportButton.Location = new System.Drawing.Point(870, 16);
            this.AnalysisReportButton.Name = "AnalysisReportButton";
            this.AnalysisReportButton.Size = new System.Drawing.Size(130, 23);
            this.AnalysisReportButton.TabIndex = 50;
            this.AnalysisReportButton.Text = "Analysis Report";
            this.AnalysisReportButton.UseVisualStyleBackColor = false;
            // 
            // ReservationsShowingCounterLabel
            // 
            this.ReservationsShowingCounterLabel.AutoSize = true;
            this.ReservationsShowingCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationsShowingCounterLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ReservationsShowingCounterLabel.Location = new System.Drawing.Point(876, 588);
            this.ReservationsShowingCounterLabel.Name = "ReservationsShowingCounterLabel";
            this.ReservationsShowingCounterLabel.Size = new System.Drawing.Size(123, 13);
            this.ReservationsShowingCounterLabel.TabIndex = 51;
            this.ReservationsShowingCounterLabel.Text = "Showing 00 reservations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 588);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Created by K0023328 for LIT, Applications Development";
            // 
            // ReservationFilterList
            // 
            this.ReservationFilterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReservationFilterList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ReservationFilterList.FormattingEnabled = true;
            this.ReservationFilterList.Location = new System.Drawing.Point(740, 545);
            this.ReservationFilterList.Name = "ReservationFilterList";
            this.ReservationFilterList.Size = new System.Drawing.Size(260, 24);
            this.ReservationFilterList.TabIndex = 54;
            this.ReservationFilterList.SelectedIndexChanged += new System.EventHandler(this.ReservationFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(691, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "View: ";
            // 
            // ReservationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1013, 615);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReservationFilterList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReservationsShowingCounterLabel);
            this.Controls.Add(this.AnalysisReportButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBarInput);
            this.Controls.Add(this.ManageReservationsLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.CreateBookingButton);
            this.Controls.Add(this.ReservationsGrid);
            this.Name = "ReservationManagement";
            this.Text = "ReservationManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReservationManagement_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchBarInput;
        private System.Windows.Forms.Label ManageReservationsLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button CreateBookingButton;
        private System.Windows.Forms.DataGridView ReservationsGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnalysisReportButton;
        private System.Windows.Forms.Label ReservationsShowingCounterLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ReservationFilterList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payable;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollectionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
    }
}