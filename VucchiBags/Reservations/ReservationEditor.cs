using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VucchiBags.Customers;
using VucchiBags.Products;
using VucchiBags.Rentals;

namespace VucchiBags.Reservations
{
    internal partial class ReservationEditor : Form
    {

        private readonly FileStorage _storage;

        private readonly ReservationManagement _managerForm;

        private readonly Reservation _reservation;

        private Product _product; // since combo box gives us data, lets use that

        private Customer _customer; // since combo box gives us data, lets use that

        public ReservationEditor(ReservationManagement managerForm, FileStorage fileStorage, Reservation reservation)
        {
            InitializeComponent();

            _managerForm = managerForm;

            _storage = fileStorage;

            _reservation = reservation; // generate the new GUID.

            SetupFormDataForReservationObject();
        }

        private void SetupFormDataForReservationObject()
        {
            if (_reservation.ProductID == 0)
            {
                ReservationGuidOutput.Text = $@"#{_reservation.Id.ToString()}";

                GenerateSelectableObjectList();

                return;
            }

            _customer = _storage.Customers.First(x => x.Id == _reservation.CustomerID);
            _product = _storage.Products.First(x => x.Id == _reservation.ProductID);
            ReservationGuidOutput.Text = _reservation.Id.ToString();
            CustomerAccountList.Items.Add($@"{_customer.FullName} #{_customer.Id}");
            CustomerAccountList.SelectedIndex = 0;
            ProductItemList.Items.Add($@"{_product.Category} #{_product.Id}");
            ProductItemList.SelectedIndex = 0;
            DiscountOfferBox.Text = _reservation.DiscountPercent.ToString();
            CollectionDatePicker.Value = _reservation.CollectDate.Date;
            ReturnDatePicker.Value = _reservation.ReturnDate.Date;
            UpdateBalanceRemaining();
        }

        private void ReservationEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            _managerForm.Show();
        }

        private void GenerateSelectableObjectList()
        {
            foreach (Customer customer in _storage.Customers)
            {
                CustomerAccountList.Items.Add($@"{customer.FullName} #{customer.Id}");
            }

            foreach (Product product in _storage.Products)
            {
                ProductItemList.Items.Add($@"{product.Category} #{product.Id}");
            }
        }

        private void CustomerAccountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _customer = _storage.Customers.ElementAt(CustomerAccountList.SelectedIndex);
            CustomerIDOutput.Text = _customer.Id.ToString();
            CustomerNameOutput.Text = _customer.FullName;
            CustomerPhoneNumberOutput.Text = _customer.PhoneNumber;
            CustomerAddressOutput.Text = _customer.Address;
            CustomerPassportNumberOutput.Text = _customer.PassportNumber;
            _reservation.CustomerID = _customer.Id; // lookups
        }

        private void ProductItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _product = _storage.Products.ElementAt(ProductItemList.SelectedIndex);
            ProductIDOutput.Text = _product.Id.ToString();
            ProductBrandOutput.Text = _product.Brand.ToString();
            ProductDescriptionOutput.Text = _product.ShortDescription.Substring(0, 25);
            ProductCategoryOutput.Text = _product.Category.ToString();
            ProductValueOutput.Text = _product.Value.ToString(CultureInfo.CurrentCulture);
            ProductDailyRateOutput.Text = $@"${_product.DailyRateAddedEuros().ToString()}";
            _reservation.ProductID = _product.Id; // lookups

            UpdateBalanceRemaining();
        }

        private void UpdateBalanceRemaining()
        {
            BalanceRemainingOutput.Text = @"$" + _reservation.BalanceDueOn(_product).ToString(CultureInfo.CurrentCulture);
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            // generate an object to handle the randomness.
            Random rand = new Random();

            // a fake reservation needs a random existing customer.
            Customer Customer = _storage.Customers.ElementAt(rand.Next(1, _storage.Customers.Count()));

            // a fake reservation needs a random existing rental.
            Product Product = _storage.Products.ElementAt(rand.Next(1, _storage.Products.Count()));

            // create the fake reservation.
            Reservation Reservation = new FakeReservation(Product, Customer);

            // display it to the form.
            //CustomerNameText.Text = $"{Customer.Forename} {Customer.Surname}";
        }

        private void CollectionDatePicker_ValueChanged(object sender, EventArgs e)
        {
            var picker = sender as DateTimePicker;

            Debug.Assert(picker != null, nameof(picker) + " != null");

            _reservation.CollectDate = DateTime.Parse(picker.Value.Date.ToShortDateString());

            UpdateBalanceRemaining();
        }

        private void ReturnDatePicker_ValueChanged(object sender, EventArgs e)
        {
            var picker = sender as DateTimePicker;

            Debug.Assert(picker != null, nameof(picker) + " != null");

            _reservation.ReturnDate = DateTime.Parse(picker.Value.Date.ToShortDateString());

            UpdateBalanceRemaining();
        }

        private void DiscountOfferBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;

            Debug.Assert(box != null, nameof(box) + " != null");

            if (!box.SelectedItem.ToString().Contains("%"))
            {
                _reservation.DiscountPercent = 0;
            }
            else
            {
                _reservation.DiscountPercent = Convert.ToInt32(box.SelectedItem.ToString().Replace("%", ""));
            }

            UpdateBalanceRemaining();
        }

        private void MakePaymentButton_Click(object sender, EventArgs e)
        {

        }

        private void MakePaymentButton_Click_1(object sender, EventArgs e)
        {
            _reservation.CurrentPayedAmount += Convert.ToDecimal(PaymentAmountInput.Text);

            UpdateBalanceRemaining();
        }
    }
}
