namespace VucchiBags.Reservations
{
    partial class ReservationEditor
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
            this.ReservationScreen = new System.Windows.Forms.Label();
            this.ReturnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CollectionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.d = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReservationsShowingCounterLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.GenerateDataButton = new System.Windows.Forms.Button();
            this.ForgeNewFormButton = new System.Windows.Forms.Button();
            this.CustomerDetailsLabel = new System.Windows.Forms.Label();
            this.ProductDetailsLabel = new System.Windows.Forms.Label();
            this.CustomerAccountLabel = new System.Windows.Forms.Label();
            this.DiscountOfferLabel = new System.Windows.Forms.Label();
            this.ReturnDateLabel = new System.Windows.Forms.Label();
            this.CollectionDateLabel = new System.Windows.Forms.Label();
            this.ProductItemLabel = new System.Windows.Forms.Label();
            this.DiscountOfferBox = new System.Windows.Forms.ComboBox();
            this.ProductItemList = new System.Windows.Forms.ComboBox();
            this.CustomerAccountList = new System.Windows.Forms.ComboBox();
            this.ReservationGUIDLabel = new System.Windows.Forms.Label();
            this.ReservationGuidOutput = new System.Windows.Forms.TextBox();
            this.BalanceRemainingLabel = new System.Windows.Forms.Label();
            this.BalanceRemainingOutput = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerPhoneNumberLabel = new System.Windows.Forms.Label();
            this.CustomerAddressLabel = new System.Windows.Forms.Label();
            this.CustomerPassportNumberLabel = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductValueLabel = new System.Windows.Forms.Label();
            this.ProductCategoryLabel = new System.Windows.Forms.Label();
            this.ProductDescriptionLabel = new System.Windows.Forms.Label();
            this.ProductBrandLabel = new System.Windows.Forms.Label();
            this.CustomerIDOutput = new System.Windows.Forms.Label();
            this.CustomerNameOutput = new System.Windows.Forms.Label();
            this.CustomerPhoneNumberOutput = new System.Windows.Forms.Label();
            this.CustomerAddressOutput = new System.Windows.Forms.Label();
            this.CustomerPassportNumberOutput = new System.Windows.Forms.Label();
            this.ProductIDOutput = new System.Windows.Forms.Label();
            this.ProductBrandOutput = new System.Windows.Forms.Label();
            this.ProductDescriptionOutput = new System.Windows.Forms.Label();
            this.ProductCategoryOutput = new System.Windows.Forms.Label();
            this.ProductValueOutput = new System.Windows.Forms.Label();
            this.ProductDailyRateOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PaymentAmountInput = new System.Windows.Forms.TextBox();
            this.MakePaymentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReservationScreen
            // 
            this.ReservationScreen.AutoSize = true;
            this.ReservationScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationScreen.Location = new System.Drawing.Point(14, 9);
            this.ReservationScreen.Name = "ReservationScreen";
            this.ReservationScreen.Size = new System.Drawing.Size(0, 18);
            this.ReservationScreen.TabIndex = 100;
            // 
            // ReturnDatePicker
            // 
            this.ReturnDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ReturnDatePicker.Location = new System.Drawing.Point(154, 247);
            this.ReturnDatePicker.Name = "ReturnDatePicker";
            this.ReturnDatePicker.Size = new System.Drawing.Size(432, 22);
            this.ReturnDatePicker.TabIndex = 10;
            this.ReturnDatePicker.ValueChanged += new System.EventHandler(this.ReturnDatePicker_ValueChanged);
            // 
            // CollectionDatePicker
            // 
            this.CollectionDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CollectionDatePicker.Location = new System.Drawing.Point(154, 215);
            this.CollectionDatePicker.Name = "CollectionDatePicker";
            this.CollectionDatePicker.Size = new System.Drawing.Size(432, 22);
            this.CollectionDatePicker.TabIndex = 9;
            this.CollectionDatePicker.ValueChanged += new System.EventHandler(this.CollectionDatePicker_ValueChanged);
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.Location = new System.Drawing.Point(8, 16);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(163, 24);
            this.d.TabIndex = 101;
            this.d.Text = "Reservation Editor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Created by K0023328 for LIT, Applications Development";
            // 
            // ReservationsShowingCounterLabel
            // 
            this.ReservationsShowingCounterLabel.AutoSize = true;
            this.ReservationsShowingCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationsShowingCounterLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ReservationsShowingCounterLabel.Location = new System.Drawing.Point(810, 479);
            this.ReservationsShowingCounterLabel.Name = "ReservationsShowingCounterLabel";
            this.ReservationsShowingCounterLabel.Size = new System.Drawing.Size(16, 13);
            this.ReservationsShowingCounterLabel.TabIndex = 106;
            this.ReservationsShowingCounterLabel.Text = "=)";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(355, 432);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 33);
            this.SaveButton.TabIndex = 105;
            this.SaveButton.Text = "&Save Changes";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // GenerateDataButton
            // 
            this.GenerateDataButton.BackColor = System.Drawing.SystemColors.Control;
            this.GenerateDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateDataButton.ForeColor = System.Drawing.Color.Black;
            this.GenerateDataButton.Location = new System.Drawing.Point(11, 432);
            this.GenerateDataButton.Name = "GenerateDataButton";
            this.GenerateDataButton.Size = new System.Drawing.Size(150, 33);
            this.GenerateDataButton.TabIndex = 104;
            this.GenerateDataButton.Text = "&Generate Data";
            this.GenerateDataButton.UseVisualStyleBackColor = false;
            // 
            // ForgeNewFormButton
            // 
            this.ForgeNewFormButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ForgeNewFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgeNewFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgeNewFormButton.ForeColor = System.Drawing.Color.Black;
            this.ForgeNewFormButton.Location = new System.Drawing.Point(624, 432);
            this.ForgeNewFormButton.Name = "ForgeNewFormButton";
            this.ForgeNewFormButton.Size = new System.Drawing.Size(202, 33);
            this.ForgeNewFormButton.TabIndex = 103;
            this.ForgeNewFormButton.Text = "&Forge another Reservation";
            this.ForgeNewFormButton.UseVisualStyleBackColor = false;
            // 
            // CustomerDetailsLabel
            // 
            this.CustomerDetailsLabel.AutoSize = true;
            this.CustomerDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CustomerDetailsLabel.Location = new System.Drawing.Point(621, 58);
            this.CustomerDetailsLabel.Name = "CustomerDetailsLabel";
            this.CustomerDetailsLabel.Size = new System.Drawing.Size(164, 17);
            this.CustomerDetailsLabel.TabIndex = 110;
            this.CustomerDetailsLabel.Text = "Inspect Customer Details";
            // 
            // ProductDetailsLabel
            // 
            this.ProductDetailsLabel.AutoSize = true;
            this.ProductDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProductDetailsLabel.Location = new System.Drawing.Point(621, 198);
            this.ProductDetailsLabel.Name = "ProductDetailsLabel";
            this.ProductDetailsLabel.Size = new System.Drawing.Size(153, 17);
            this.ProductDetailsLabel.TabIndex = 111;
            this.ProductDetailsLabel.Text = "Inspect Product Details";
            // 
            // CustomerAccountLabel
            // 
            this.CustomerAccountLabel.AutoSize = true;
            this.CustomerAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CustomerAccountLabel.Location = new System.Drawing.Point(9, 93);
            this.CustomerAccountLabel.Name = "CustomerAccountLabel";
            this.CustomerAccountLabel.Size = new System.Drawing.Size(119, 16);
            this.CustomerAccountLabel.TabIndex = 113;
            this.CustomerAccountLabel.Text = "Customer Account:";
            // 
            // DiscountOfferLabel
            // 
            this.DiscountOfferLabel.AutoSize = true;
            this.DiscountOfferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DiscountOfferLabel.Location = new System.Drawing.Point(9, 161);
            this.DiscountOfferLabel.Name = "DiscountOfferLabel";
            this.DiscountOfferLabel.Size = new System.Drawing.Size(94, 16);
            this.DiscountOfferLabel.TabIndex = 114;
            this.DiscountOfferLabel.Text = "Discount Offer:";
            // 
            // ReturnDateLabel
            // 
            this.ReturnDateLabel.AutoSize = true;
            this.ReturnDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ReturnDateLabel.Location = new System.Drawing.Point(9, 252);
            this.ReturnDateLabel.Name = "ReturnDateLabel";
            this.ReturnDateLabel.Size = new System.Drawing.Size(82, 16);
            this.ReturnDateLabel.TabIndex = 115;
            this.ReturnDateLabel.Text = "Return Date:";
            // 
            // CollectionDateLabel
            // 
            this.CollectionDateLabel.AutoSize = true;
            this.CollectionDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CollectionDateLabel.Location = new System.Drawing.Point(9, 219);
            this.CollectionDateLabel.Name = "CollectionDateLabel";
            this.CollectionDateLabel.Size = new System.Drawing.Size(102, 16);
            this.CollectionDateLabel.TabIndex = 116;
            this.CollectionDateLabel.Text = "Collection Date:";
            // 
            // ProductItemLabel
            // 
            this.ProductItemLabel.AutoSize = true;
            this.ProductItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ProductItemLabel.Location = new System.Drawing.Point(9, 127);
            this.ProductItemLabel.Name = "ProductItemLabel";
            this.ProductItemLabel.Size = new System.Drawing.Size(85, 16);
            this.ProductItemLabel.TabIndex = 117;
            this.ProductItemLabel.Text = "Product Item:";
            // 
            // DiscountOfferBox
            // 
            this.DiscountOfferBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DiscountOfferBox.FormattingEnabled = true;
            this.DiscountOfferBox.Items.AddRange(new object[] {
            "5%",
            "10%",
            "20%",
            "25%",
            "30%",
            "35%",
            "50%",
            "No Discount"});
            this.DiscountOfferBox.Location = new System.Drawing.Point(154, 158);
            this.DiscountOfferBox.Name = "DiscountOfferBox";
            this.DiscountOfferBox.Size = new System.Drawing.Size(432, 24);
            this.DiscountOfferBox.TabIndex = 118;
            this.DiscountOfferBox.Text = "No Discount";
            this.DiscountOfferBox.SelectedIndexChanged += new System.EventHandler(this.DiscountOfferBox_SelectedIndexChanged);
            // 
            // ProductItemList
            // 
            this.ProductItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ProductItemList.FormattingEnabled = true;
            this.ProductItemList.Location = new System.Drawing.Point(154, 124);
            this.ProductItemList.Name = "ProductItemList";
            this.ProductItemList.Size = new System.Drawing.Size(432, 24);
            this.ProductItemList.TabIndex = 119;
            this.ProductItemList.SelectedIndexChanged += new System.EventHandler(this.ProductItemList_SelectedIndexChanged);
            // 
            // CustomerAccountList
            // 
            this.CustomerAccountList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CustomerAccountList.FormattingEnabled = true;
            this.CustomerAccountList.Location = new System.Drawing.Point(154, 90);
            this.CustomerAccountList.Name = "CustomerAccountList";
            this.CustomerAccountList.Size = new System.Drawing.Size(432, 24);
            this.CustomerAccountList.TabIndex = 120;
            this.CustomerAccountList.SelectedIndexChanged += new System.EventHandler(this.CustomerAccountList_SelectedIndexChanged);
            // 
            // ReservationGUIDLabel
            // 
            this.ReservationGUIDLabel.AutoSize = true;
            this.ReservationGUIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ReservationGUIDLabel.Location = new System.Drawing.Point(9, 61);
            this.ReservationGUIDLabel.Name = "ReservationGUIDLabel";
            this.ReservationGUIDLabel.Size = new System.Drawing.Size(120, 16);
            this.ReservationGUIDLabel.TabIndex = 121;
            this.ReservationGUIDLabel.Text = "Reservation GUID:";
            // 
            // ReservationGuidOutput
            // 
            this.ReservationGuidOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ReservationGuidOutput.Location = new System.Drawing.Point(154, 58);
            this.ReservationGuidOutput.Name = "ReservationGuidOutput";
            this.ReservationGuidOutput.ReadOnly = true;
            this.ReservationGuidOutput.Size = new System.Drawing.Size(432, 22);
            this.ReservationGuidOutput.TabIndex = 122;
            // 
            // BalanceRemainingLabel
            // 
            this.BalanceRemainingLabel.AutoSize = true;
            this.BalanceRemainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceRemainingLabel.Location = new System.Drawing.Point(12, 339);
            this.BalanceRemainingLabel.Name = "BalanceRemainingLabel";
            this.BalanceRemainingLabel.Size = new System.Drawing.Size(129, 16);
            this.BalanceRemainingLabel.TabIndex = 123;
            this.BalanceRemainingLabel.Text = "Balance Remaining:";
            // 
            // BalanceRemainingOutput
            // 
            this.BalanceRemainingOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BalanceRemainingOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceRemainingOutput.Location = new System.Drawing.Point(12, 365);
            this.BalanceRemainingOutput.Name = "BalanceRemainingOutput";
            this.BalanceRemainingOutput.ReadOnly = true;
            this.BalanceRemainingOutput.Size = new System.Drawing.Size(814, 31);
            this.BalanceRemainingOutput.TabIndex = 124;
            this.BalanceRemainingOutput.Text = "N/A";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(181, 432);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 33);
            this.CancelButton.TabIndex = 127;
            this.CancelButton.Text = "&Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(621, 103);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(85, 13);
            this.CustomerNameLabel.TabIndex = 128;
            this.CustomerNameLabel.Text = "Customer Name:";
            // 
            // CustomerPhoneNumberLabel
            // 
            this.CustomerPhoneNumberLabel.AutoSize = true;
            this.CustomerPhoneNumberLabel.Location = new System.Drawing.Point(621, 123);
            this.CustomerPhoneNumberLabel.Name = "CustomerPhoneNumberLabel";
            this.CustomerPhoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.CustomerPhoneNumberLabel.TabIndex = 129;
            this.CustomerPhoneNumberLabel.Text = "Phone Number:";
            // 
            // CustomerAddressLabel
            // 
            this.CustomerAddressLabel.AutoSize = true;
            this.CustomerAddressLabel.Location = new System.Drawing.Point(621, 143);
            this.CustomerAddressLabel.Name = "CustomerAddressLabel";
            this.CustomerAddressLabel.Size = new System.Drawing.Size(48, 13);
            this.CustomerAddressLabel.TabIndex = 130;
            this.CustomerAddressLabel.Text = "Address:";
            // 
            // CustomerPassportNumberLabel
            // 
            this.CustomerPassportNumberLabel.AutoSize = true;
            this.CustomerPassportNumberLabel.Location = new System.Drawing.Point(621, 163);
            this.CustomerPassportNumberLabel.Name = "CustomerPassportNumberLabel";
            this.CustomerPassportNumberLabel.Size = new System.Drawing.Size(71, 13);
            this.CustomerPassportNumberLabel.TabIndex = 131;
            this.CustomerPassportNumberLabel.Text = "Passport No.:";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(621, 83);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(68, 13);
            this.CustomerIDLabel.TabIndex = 140;
            this.CustomerIDLabel.Text = "Customer ID:";
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Location = new System.Drawing.Point(621, 224);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(61, 13);
            this.ProductIDLabel.TabIndex = 145;
            this.ProductIDLabel.Text = "Product ID:";
            // 
            // ProductValueLabel
            // 
            this.ProductValueLabel.AutoSize = true;
            this.ProductValueLabel.Location = new System.Drawing.Point(621, 304);
            this.ProductValueLabel.Name = "ProductValueLabel";
            this.ProductValueLabel.Size = new System.Drawing.Size(37, 13);
            this.ProductValueLabel.TabIndex = 144;
            this.ProductValueLabel.Text = "Value:";
            // 
            // ProductCategoryLabel
            // 
            this.ProductCategoryLabel.AutoSize = true;
            this.ProductCategoryLabel.Location = new System.Drawing.Point(621, 284);
            this.ProductCategoryLabel.Name = "ProductCategoryLabel";
            this.ProductCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.ProductCategoryLabel.TabIndex = 143;
            this.ProductCategoryLabel.Text = "Category:";
            // 
            // ProductDescriptionLabel
            // 
            this.ProductDescriptionLabel.AutoSize = true;
            this.ProductDescriptionLabel.Location = new System.Drawing.Point(621, 264);
            this.ProductDescriptionLabel.Name = "ProductDescriptionLabel";
            this.ProductDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.ProductDescriptionLabel.TabIndex = 142;
            this.ProductDescriptionLabel.Text = "Description:";
            // 
            // ProductBrandLabel
            // 
            this.ProductBrandLabel.AutoSize = true;
            this.ProductBrandLabel.Location = new System.Drawing.Point(621, 244);
            this.ProductBrandLabel.Name = "ProductBrandLabel";
            this.ProductBrandLabel.Size = new System.Drawing.Size(38, 13);
            this.ProductBrandLabel.TabIndex = 141;
            this.ProductBrandLabel.Text = "Brand:";
            // 
            // CustomerIDOutput
            // 
            this.CustomerIDOutput.AutoSize = true;
            this.CustomerIDOutput.Location = new System.Drawing.Point(686, 83);
            this.CustomerIDOutput.Name = "CustomerIDOutput";
            this.CustomerIDOutput.Size = new System.Drawing.Size(27, 13);
            this.CustomerIDOutput.TabIndex = 151;
            this.CustomerIDOutput.Text = "N/A";
            // 
            // CustomerNameOutput
            // 
            this.CustomerNameOutput.AutoSize = true;
            this.CustomerNameOutput.Location = new System.Drawing.Point(703, 105);
            this.CustomerNameOutput.Name = "CustomerNameOutput";
            this.CustomerNameOutput.Size = new System.Drawing.Size(27, 13);
            this.CustomerNameOutput.TabIndex = 152;
            this.CustomerNameOutput.Text = "N/A";
            // 
            // CustomerPhoneNumberOutput
            // 
            this.CustomerPhoneNumberOutput.AutoSize = true;
            this.CustomerPhoneNumberOutput.Location = new System.Drawing.Point(699, 123);
            this.CustomerPhoneNumberOutput.Name = "CustomerPhoneNumberOutput";
            this.CustomerPhoneNumberOutput.Size = new System.Drawing.Size(27, 13);
            this.CustomerPhoneNumberOutput.TabIndex = 153;
            this.CustomerPhoneNumberOutput.Text = "N/A";
            // 
            // CustomerAddressOutput
            // 
            this.CustomerAddressOutput.AutoSize = true;
            this.CustomerAddressOutput.Location = new System.Drawing.Point(666, 143);
            this.CustomerAddressOutput.Name = "CustomerAddressOutput";
            this.CustomerAddressOutput.Size = new System.Drawing.Size(27, 13);
            this.CustomerAddressOutput.TabIndex = 154;
            this.CustomerAddressOutput.Text = "N/A";
            // 
            // CustomerPassportNumberOutput
            // 
            this.CustomerPassportNumberOutput.AutoSize = true;
            this.CustomerPassportNumberOutput.Location = new System.Drawing.Point(689, 163);
            this.CustomerPassportNumberOutput.Name = "CustomerPassportNumberOutput";
            this.CustomerPassportNumberOutput.Size = new System.Drawing.Size(27, 13);
            this.CustomerPassportNumberOutput.TabIndex = 155;
            this.CustomerPassportNumberOutput.Text = "N/A";
            // 
            // ProductIDOutput
            // 
            this.ProductIDOutput.AutoSize = true;
            this.ProductIDOutput.Location = new System.Drawing.Point(679, 224);
            this.ProductIDOutput.Name = "ProductIDOutput";
            this.ProductIDOutput.Size = new System.Drawing.Size(27, 13);
            this.ProductIDOutput.TabIndex = 156;
            this.ProductIDOutput.Text = "N/A";
            // 
            // ProductBrandOutput
            // 
            this.ProductBrandOutput.AutoSize = true;
            this.ProductBrandOutput.Location = new System.Drawing.Point(653, 244);
            this.ProductBrandOutput.Name = "ProductBrandOutput";
            this.ProductBrandOutput.Size = new System.Drawing.Size(27, 13);
            this.ProductBrandOutput.TabIndex = 157;
            this.ProductBrandOutput.Text = "N/A";
            // 
            // ProductDescriptionOutput
            // 
            this.ProductDescriptionOutput.AutoSize = true;
            this.ProductDescriptionOutput.Location = new System.Drawing.Point(682, 264);
            this.ProductDescriptionOutput.Name = "ProductDescriptionOutput";
            this.ProductDescriptionOutput.Size = new System.Drawing.Size(27, 13);
            this.ProductDescriptionOutput.TabIndex = 158;
            this.ProductDescriptionOutput.Text = "N/A";
            // 
            // ProductCategoryOutput
            // 
            this.ProductCategoryOutput.AutoSize = true;
            this.ProductCategoryOutput.Location = new System.Drawing.Point(669, 284);
            this.ProductCategoryOutput.Name = "ProductCategoryOutput";
            this.ProductCategoryOutput.Size = new System.Drawing.Size(27, 13);
            this.ProductCategoryOutput.TabIndex = 159;
            this.ProductCategoryOutput.Text = "N/A";
            // 
            // ProductValueOutput
            // 
            this.ProductValueOutput.AutoSize = true;
            this.ProductValueOutput.Location = new System.Drawing.Point(655, 304);
            this.ProductValueOutput.Name = "ProductValueOutput";
            this.ProductValueOutput.Size = new System.Drawing.Size(27, 13);
            this.ProductValueOutput.TabIndex = 160;
            this.ProductValueOutput.Text = "N/A";
            // 
            // ProductDailyRateOutput
            // 
            this.ProductDailyRateOutput.AutoSize = true;
            this.ProductDailyRateOutput.Location = new System.Drawing.Point(677, 322);
            this.ProductDailyRateOutput.Name = "ProductDailyRateOutput";
            this.ProductDailyRateOutput.Size = new System.Drawing.Size(27, 13);
            this.ProductDailyRateOutput.TabIndex = 162;
            this.ProductDailyRateOutput.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 161;
            this.label3.Text = "Daily Rate:";
            // 
            // PaymentAmountInput
            // 
            this.PaymentAmountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PaymentAmountInput.Location = new System.Drawing.Point(26, 299);
            this.PaymentAmountInput.Name = "PaymentAmountInput";
            this.PaymentAmountInput.Size = new System.Drawing.Size(429, 22);
            this.PaymentAmountInput.TabIndex = 163;
            // 
            // MakePaymentButton
            // 
            this.MakePaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.MakePaymentButton.Location = new System.Drawing.Point(461, 299);
            this.MakePaymentButton.Name = "MakePaymentButton";
            this.MakePaymentButton.Size = new System.Drawing.Size(125, 23);
            this.MakePaymentButton.TabIndex = 164;
            this.MakePaymentButton.Text = "Make Payment";
            this.MakePaymentButton.UseVisualStyleBackColor = true;
            this.MakePaymentButton.Click += new System.EventHandler(this.MakePaymentButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(9, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 165;
            this.label1.Text = "$";
            // 
            // ReservationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(838, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MakePaymentButton);
            this.Controls.Add(this.PaymentAmountInput);
            this.Controls.Add(this.ProductDailyRateOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductValueOutput);
            this.Controls.Add(this.ProductCategoryOutput);
            this.Controls.Add(this.ProductDescriptionOutput);
            this.Controls.Add(this.ProductBrandOutput);
            this.Controls.Add(this.ProductIDOutput);
            this.Controls.Add(this.CustomerPassportNumberOutput);
            this.Controls.Add(this.CustomerAddressOutput);
            this.Controls.Add(this.CustomerPhoneNumberOutput);
            this.Controls.Add(this.CustomerNameOutput);
            this.Controls.Add(this.CustomerIDOutput);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.ProductValueLabel);
            this.Controls.Add(this.ProductCategoryLabel);
            this.Controls.Add(this.ProductDescriptionLabel);
            this.Controls.Add(this.ProductBrandLabel);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.CustomerPassportNumberLabel);
            this.Controls.Add(this.CustomerAddressLabel);
            this.Controls.Add(this.CustomerPhoneNumberLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BalanceRemainingOutput);
            this.Controls.Add(this.BalanceRemainingLabel);
            this.Controls.Add(this.ReservationGuidOutput);
            this.Controls.Add(this.ReservationGUIDLabel);
            this.Controls.Add(this.CustomerAccountList);
            this.Controls.Add(this.ProductItemList);
            this.Controls.Add(this.DiscountOfferBox);
            this.Controls.Add(this.ProductItemLabel);
            this.Controls.Add(this.CollectionDateLabel);
            this.Controls.Add(this.ReturnDateLabel);
            this.Controls.Add(this.DiscountOfferLabel);
            this.Controls.Add(this.CustomerAccountLabel);
            this.Controls.Add(this.ProductDetailsLabel);
            this.Controls.Add(this.CustomerDetailsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReservationsShowingCounterLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GenerateDataButton);
            this.Controls.Add(this.ForgeNewFormButton);
            this.Controls.Add(this.d);
            this.Controls.Add(this.CollectionDatePicker);
            this.Controls.Add(this.ReturnDatePicker);
            this.Controls.Add(this.ReservationScreen);
            this.Name = "ReservationEditor";
            this.Text = "Reservation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReservationEditor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ReservationScreen;
        private System.Windows.Forms.DateTimePicker ReturnDatePicker;
        private System.Windows.Forms.DateTimePicker CollectionDatePicker;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ReservationsShowingCounterLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button GenerateDataButton;
        private System.Windows.Forms.Button ForgeNewFormButton;
        private System.Windows.Forms.Label CustomerDetailsLabel;
        private System.Windows.Forms.Label ProductDetailsLabel;
        private System.Windows.Forms.Label CustomerAccountLabel;
        private System.Windows.Forms.Label DiscountOfferLabel;
        private System.Windows.Forms.Label ReturnDateLabel;
        private System.Windows.Forms.Label CollectionDateLabel;
        private System.Windows.Forms.Label ProductItemLabel;
        private System.Windows.Forms.ComboBox DiscountOfferBox;
        private System.Windows.Forms.ComboBox ProductItemList;
        private System.Windows.Forms.ComboBox CustomerAccountList;
        private System.Windows.Forms.Label ReservationGUIDLabel;
        private System.Windows.Forms.TextBox ReservationGuidOutput;
        private System.Windows.Forms.Label BalanceRemainingLabel;
        private System.Windows.Forms.TextBox BalanceRemainingOutput;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label CustomerPhoneNumberLabel;
        private System.Windows.Forms.Label CustomerAddressLabel;
        private System.Windows.Forms.Label CustomerPassportNumberLabel;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ProductValueLabel;
        private System.Windows.Forms.Label ProductCategoryLabel;
        private System.Windows.Forms.Label ProductDescriptionLabel;
        private System.Windows.Forms.Label ProductBrandLabel;
        private System.Windows.Forms.Label CustomerIDOutput;
        private System.Windows.Forms.Label CustomerNameOutput;
        private System.Windows.Forms.Label CustomerPhoneNumberOutput;
        private System.Windows.Forms.Label CustomerAddressOutput;
        private System.Windows.Forms.Label CustomerPassportNumberOutput;
        private System.Windows.Forms.Label ProductIDOutput;
        private System.Windows.Forms.Label ProductBrandOutput;
        private System.Windows.Forms.Label ProductDescriptionOutput;
        private System.Windows.Forms.Label ProductCategoryOutput;
        private System.Windows.Forms.Label ProductValueOutput;
        private System.Windows.Forms.Label ProductDailyRateOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PaymentAmountInput;
        private System.Windows.Forms.Button MakePaymentButton;
        private System.Windows.Forms.Label label1;
    }
}