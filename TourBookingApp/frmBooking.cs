using DataAccess.DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourBookingApp
{
    public partial class frmBooking : Form
    {
        public frmBooking()
        {
            InitializeComponent();
        }
        public ITripRepository TripRepository { get; set; }
        public IBookingRepository bookingRepository = new BookingRepository();
        public ITourRepository tourRepository = new TourRepository();
        public ICustomerRepository customerRepository = new CustomerRepository();
        public TblTrip TripInfo { get; set; }
        public int userID { get; set; }
        bool InsertOrUpdate; //true = update, false = insert 

        private void frmBooking_Load(object sender, EventArgs e)
        {
            lbTourInfo.Text = GetTourName(TripInfo.TourId);
            lbStartInfo.Text = TripInfo.StartTime.ToString();
            lbEndInfo.Text = TripInfo.Endtime.ToString();
            lbAccInfo.Text = TripInfo.Accommodation;
            lbDesInfo.Text = TripInfo.Description;
            lbPriceInfo.Text = TripInfo.Price.ToString();
            lbTotalInfo.Text = TripInfo.Price.ToString();
            txtEmail.Enabled = false;
            txtName.Enabled = false;
            dtpDOB.Enabled = false;
            cbSex.Enabled = false;
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(lbPriceInfo.Text);
            int quantity = Convert.ToInt32(numQuantity.Value);

            decimal total = price * quantity;
            lbTotalInfo.Text = total.ToString();
        }

        private string GetTourName(int tourID)
        {
            var tour = tourRepository.GetTourByID(tourID);
            return tour.TourName;
        }

        private void btCancel_Click(object sender, EventArgs e)
        => Close();

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {


                if (!Regex.IsMatch(txtPhone.Text, "[0-9]{10}") || txtPhone.Text.Length > 10)
                {
                    txtEmail.Enabled = false;
                    txtName.Enabled = false;
                    dtpDOB.Enabled = false;
                    cbSex.Enabled = false;
                    throw new Exception("Please enter 10 numbers for the phone number");
                }
                else
                {
                    txtEmail.Enabled = true;
                    txtName.Enabled = true;
                    dtpDOB.Enabled = true;
                    cbSex.Enabled = true;
                    txtName.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    dtpDOB.Value = DateTime.Now;
                    cbSex.SelectedItem = null;
                    var customer = customerRepository.SearchCustomer(txtPhone.Text);
                    if (customer != null)
                    {
                        InsertOrUpdate = true;
                        txtName.Text = customer.Name;
                        txtEmail.Text = customer.Email;
                        if (customer.Sex == true)
                        {
                            cbSex.Text = "Female";
                        }
                        else
                        {
                            cbSex.Text = "Male";
                        }

                        dtpDOB.Value = customer.Dob;
                    }
                    else
                    {
                        InsertOrUpdate = false;
                        throw new Exception("Cannot find the customer. Please add new one.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search customer!");
            }
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(txtPhone.Text, "[0-9]{10}") || txtPhone.Text.Length > 10)
                {
                    txtEmail.Enabled = false;
                    txtName.Enabled = false;
                    dtpDOB.Enabled = false;
                    cbSex.Enabled = false;
                    throw new Exception("Please enter 10 numbers for the phone number");
                }
                else if (txtName.Text.Length < 1 || txtEmail.Text.Length < 1 || cbSex.Text.Length < 1)
                {
                    throw new Exception("Please fill in all field.");
                }
                else
                {
                    //customer section
                    bool sex;
                    if (cbSex.Text == "Female")
                    {
                        sex = true;
                    }
                    else
                    {
                        sex = false;
                    }
                    TblCustomer customer = new TblCustomer
                    {
                        PhoneNo = txtPhone.Text,
                        Email = txtEmail.Text,
                        Name = txtName.Text,
                        Dob = dtpDOB.Value,
                        Sex = sex
                    };
                    if (InsertOrUpdate == false)
                    {
                        customerRepository.InsertCustomer(customer);
                    }
                    else
                    {
                        TblCustomer customerForUpdate = new TblCustomer
                        {
                            CustomerId = customerRepository.SearchCustomer(txtPhone.Text).CustomerId,
                            PhoneNo = txtPhone.Text,
                            Name = txtName.Text,
                            Email = txtEmail.Text,
                            Dob = dtpDOB.Value,
                            Sex = sex
                        };
                        customerRepository.UpdateCustomer(customerForUpdate);
                    }
                    //booking section
                    var customerForSearch = customerRepository.SearchCustomer(txtPhone.Text);
                    TblBooking booking = new TblBooking
                    {
                        UserId = this.userID,
                        TripId = TripInfo.TripId,
                        NoOfPeople = Convert.ToInt32(numQuantity.Value),
                        TotalPrice = decimal.Parse(lbTotalInfo.Text),
                        BookingDate = DateTime.Now,
                        Status = true,
                        CustomerId = customerForSearch.CustomerId

                    };
                    bookingRepository.InsertBooking(booking);
                    //trip section
                    int quantityLeft = TripInfo.Capacity - Convert.ToInt32(numQuantity.Value);
                    TblTrip trip = new TblTrip
                    {
                        TripId = TripInfo.TripId,
                        StartTime = TripInfo.StartTime,
                        Endtime = TripInfo.Endtime,
                        Price = TripInfo.Price,
                        Capacity = quantityLeft,
                        Accommodation = TripInfo.Accommodation,
                        Description = TripInfo.Description,
                        Status = TripInfo.Status,
                        TourId = TripInfo.TourId
                    };
                    TripRepository.UpdateTrip(trip);
                }
            }
            catch (Exception ex)
            {
                DialogResult d =  MessageBox.Show(ex.Message, "Tour booking", MessageBoxButtons.OKCancel);
                if (d==DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }
    }
}
