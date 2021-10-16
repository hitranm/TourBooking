using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using DataAccess.DataAccess;

namespace TourBookingApp
{
    public partial class frmManagement : Form
    {
        ITourRepository tourRepository = new TourRepository();
        ITripRepository tripRepository = new TripRepository();
        ICustomerRepository customerRepository = new CustomerRepository();
        IBookingRepository bookingRepository = new BookingRepository();
        BindingSource source;

        public frmManagement()
        {
            InitializeComponent();
            LoadTourList();
            LoadTripList();
        }


        public void LoadTourList()
        {
            var tours = tourRepository.GetTours();

            try
            {
                source = new BindingSource();
                source.DataSource = tours;

                dtgListTour.DataSource = null;
                dtgListTour.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Tour list");
            }
        }

        void LoadTripList()
        {
            var trips = tripRepository.GetTrips();

            try
            {
                source = new BindingSource();
                source.DataSource = trips;

                dtgTripList.DataSource = null;
                dtgTripList.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Trip list");
            }

        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            frmAddNewTrip frm = new frmAddNewTrip();
            frm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTripList();
        }

        private void cboSelect_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cboSelect.SelectedItem.ToString() == "Customer")
            {
                dgvBooking.DataSource = null;
                LoadCustomerList();
            }
            else
            {
                dgvBooking.DataSource = null;
                LoadTripForBooking();
            }
        }

        private void LoadCustomerList()
        {
            try
            {
                source = new BindingSource();
                source.DataSource = customerRepository.GetCustomers();
                dgvSelectList.DataSource = null;
                dgvSelectList.DataSource = source;
                dgvSelectList.Columns["TblBookings"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load customer list");
            }
        }

        private void LoadTripForBooking()
        {
            try
            {
                source = new BindingSource();
                source.DataSource = tripRepository.GetTrips();
                dgvSelectList.DataSource = null;
                dgvSelectList.DataSource = source;
                dgvSelectList.Columns["TblBookings"].Visible = false;
                dgvSelectList.Columns["Tour"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load trip list");
            }
        }

        private void dgvSelectList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                source = new BindingSource();
                if (cboSelect.SelectedItem.ToString() == "Customer")
                {
                    source.DataSource = bookingRepository.GetBookingsByCustomerId(GetCustomerObject(e).CustomerId);
                    dgvBooking.DataSource = null;
                    dgvBooking.DataSource = source;
                    dgvBooking.Columns["Customer"].Visible = false;
                    dgvBooking.Columns["Trip"].Visible = false;
                    dgvBooking.Columns["User"].Visible = false;
                    dgvBooking.Columns["CustomerId"].Visible = false;
                }
                else
                {
                    source.DataSource = bookingRepository.GetBookingsByTripId(GetTripObject(e).TripId);
                    dgvBooking.DataSource = null;
                    dgvBooking.DataSource = source;
                    dgvBooking.Columns["Customer"].Visible = false;
                    dgvBooking.Columns["Trip"].Visible = false;
                    dgvBooking.Columns["User"].Visible = false;
                    dgvBooking.Columns["TripId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load booking list");
            }
        }

        private TblTrip GetTripObject(DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            TblTrip trip = null;

            try
            {
                trip = new TblTrip
                {
                    TripId = int.Parse(dgvSelectList[dgvSelectList.Columns["TripId"].Index, rowIndex].Value.ToString()),
                    StartTime = DateTime.Parse(dgvSelectList[dgvSelectList.Columns["StartTime"].Index, rowIndex].Value.ToString()),
                    Endtime = DateTime.Parse(dgvSelectList[dgvSelectList.Columns["Endtime"].Index, rowIndex].Value.ToString()),
                    Accommodation = dgvSelectList[dgvSelectList.Columns["Accommodation"].Index, rowIndex].Value.ToString(),
                    Capacity = int.Parse(dgvSelectList[dgvSelectList.Columns["Capacity"].Index, rowIndex].Value.ToString()),
                    Price = decimal.Parse(dgvSelectList[dgvSelectList.Columns["Price"].Index, rowIndex].Value.ToString()),
                    Description = dgvSelectList[dgvSelectList.Columns["Description"].Index, rowIndex].Value.ToString(),
                    TourId = int.Parse(dgvSelectList[dgvSelectList.Columns["TourId"].Index, rowIndex].Value.ToString())
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return trip;
        }

        private TblCustomer GetCustomerObject(DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            TblCustomer customer = null;

            try
            {
                customer = new TblCustomer
                {
                    CustomerId = int.Parse(dgvSelectList[dgvSelectList.Columns["CustomerId"].Index, rowIndex].Value.ToString()),
                    Name = dgvSelectList[dgvSelectList.Columns["Name"].Index, rowIndex].Value.ToString(),
                    Email = dgvSelectList[dgvSelectList.Columns["Email"].Index, rowIndex].Value.ToString(),
                    PhoneNo = dgvSelectList[dgvSelectList.Columns["PhoneNo"].Index, rowIndex].Value.ToString(),
                    Dob = DateTime.Parse(dgvSelectList[dgvSelectList.Columns["Dob"].Index, rowIndex].Value.ToString()),
                    Sex = bool.Parse(dgvSelectList[dgvSelectList.Columns["Sex"].Index, rowIndex].Value.ToString())
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return customer;
        }
    }
}

