using DataAccess.DataAccess;
using DataAccess.Repository;
using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
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
        int tempCustomerID;

        private void frmBooking_Load(object sender, EventArgs e)
        {
            if (frmLogin.canLog == true)
            {
                lbTourInfo.Text = GetTourName(TripInfo.TourId);
                lbStartInfo.Text = TripInfo.StartTime.ToString("dd/MM/yyyy");
                lbEndInfo.Text = TripInfo.Endtime.ToString("dd/MM/yyyy");
                lbAccInfo.Text = TripInfo.Accommodation;
                lbDesInfo.Text = TripInfo.Description;
                lbPriceInfo.Text = TripInfo.Price.ToString("n2");
                lbTotalInfo.Text = TripInfo.Price.ToString("n2");
                lbCapaInfo.Text = TripInfo.Capacity.ToString();
                dtpDOB.MaxDate = DateTime.Now.AddYears(-18).AddDays(1);
                dtpDOB.Value = DateTime.Now.AddYears(-18);
                txtEmail.Enabled = false;
                txtName.Enabled = false;
                dtpDOB.Enabled = false;
                cbSex.Enabled = false;
            }
            else
            {
                this.Hide();

                frmLogin frm = new frmLogin();
                frm.ShowDialog();

            }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(lbPriceInfo.Text);
            int quantity = Convert.ToInt32(numQuantity.Value);

            decimal total = price * quantity;
            lbTotalInfo.Text = total.ToString("n2");
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
                    dtpDOB.Value = DateTime.Now.AddYears(-18);
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
                        tempCustomerID = customer.CustomerId;
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
                else if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(cbSex.Text))
                {
                    throw new Exception("Please fill in all field.");
                }
                try
                {
                    MailAddress email = new MailAddress(txtEmail.Text);
                }
                catch
                {
                    throw new Exception("Please enter correct format for email");
                }
                if (txtEmail.Text.Length > 100)
                {
                    throw new Exception("Email max length is 100 characters");
                }
                if (txtName.Text.Length > 50)
                {
                    throw new Exception("Name max length is 50 characters");
                }

                if (customerRepository.SearchCustomer(txtPhone.Text) != null && customerRepository.SearchCustomer(txtPhone.Text).CustomerId != tempCustomerID)
                {
                    throw new Exception("This phone number already exists!");
                }

                if (numQuantity.Value > TripInfo.Capacity)
                {
                    throw new Exception("There are not enough capacity left");
                }
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
                        CustomerId = tempCustomerID,
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
                TripInfo.Capacity -= Convert.ToInt32(numQuantity.Value);
                TripRepository.UpdateTrip(TripInfo);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                DialogResult d = MessageBox.Show(ex.Message, "Tour booking", MessageBoxButtons.OKCancel);
                if (d == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }
    }
}
