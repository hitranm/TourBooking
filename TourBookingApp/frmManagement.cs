using DataAccess.DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace TourBookingApp
{
    public partial class frmManagement : Form
    {
        ITourRepository tourRepository = new TourRepository();
        ITripRepository tripRepository = new TripRepository();
        ICustomerRepository customerRepository = new CustomerRepository();
        IBookingRepository bookingRepository = new BookingRepository();
        BindingSource source;
        public int tripID;

        public frmManagement()
        {
            InitializeComponent();
            LoadTourList();
            LoadTripList();
        }

        private void LoadOneTour(string name)
        {
            ITourRepository tourRepository = new TourRepository();
            bool hasTour = false;

            var tour = new List<TblTour>();
            var tours = tourRepository.GetTours();
            try
            {
                foreach (var i in tours)
                {
                    if (i.TourName.Contains(txtSearch.Text))
                    {
                        hasTour = true;
                        tour.Add(i);
                    }
                    source = new BindingSource();
                    source.DataSource = tour;
                    

                    dgvTour.DataSource = null;
                    dgvTour.DataSource = source;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Load tour");
            }
            if (hasTour == false)
            {
                MessageBox.Show("There are no tours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                //dtgTripList.Columns[7].Visible = false;
                //dtgTripList.Columns[8].Visible = false;
                dtgTripList.Columns[9].Visible = false;
                dtgTripList.Columns[10].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Trip list");
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }
      
        
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewTour frm = new frmAddNewTour
            {
                Text = "Add tour",
                InsertOrUpdate = false,
                tourRepository = tourRepository

            };
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadTours();
                source.Position = source.Count - 1;
            }
           

        }
     


        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            frmAddNewTrip frm = new frmAddNewTrip
            {
                Text = "Add Trip",
                AddOrUpdate = false,
            };
            frm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadTours();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }
        private void LoadTours()
        {
            var tour = tourRepository.GetTours();
            source = new BindingSource();
            source.DataSource = tour;
            dgvTour.DataSource = null;
            dgvTour.DataSource = source;

        }

        private void frmManagement_Load(object sender, EventArgs e)
        {
            var tour = tourRepository.GetTours();
            source = new BindingSource();
            source.DataSource = tour;
            dgvTour.DataSource = null;
            dgvTour.DataSource = source;
        }



        private void dgvTour_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var tour = new TblTour
            {
                TourId = int.Parse(dgvTour[dgvTour.Columns["TourID"].Index, dgvTour.CurrentRow.Index].Value.ToString()),
                TourName = (dgvTour[dgvTour.Columns["TourName"].Index, dgvTour.CurrentRow.Index].Value.ToString()),
                Departure = (dgvTour[dgvTour.Columns["Departure"].Index, dgvTour.CurrentRow.Index].Value.ToString()),
                Destination = (dgvTour[dgvTour.Columns["Destination"].Index, dgvTour.CurrentRow.Index].Value.ToString()),
                Description = (dgvTour[dgvTour.Columns["Description"].Index, dgvTour.CurrentRow.Index].Value.ToString()),
                Status = bool.Parse(dgvTour[dgvTour.Columns["Status"].Index, dgvTour.CurrentRow.Index].Value.ToString()),
            };

            frmAddNewTour frm = new frmAddNewTour
            {
                Text = "Update Tour",
                InsertOrUpdate = true,
                TourInfo = tour,
                tourRepository = tourRepository

            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadTours();
                source.Position = source.Count - 1;
            }
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

        private void dtgTripList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAddNewTrip frmDetails = new frmAddNewTrip
            {
                Text = "Update Trip",
                AddOrUpdate = true,
                trip = GetTripInfor(e),
            };
            frmDetails.ShowDialog();

        }
        private TblTrip GetTripInfor(DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            TblTrip trip = null;
            try
            {
                trip = new TblTrip
                {
                    TripId = int.Parse(dtgTripList[dtgTripList.Columns["TripId"].Index, rowIndex].Value.ToString()),
                    StartTime = DateTime.Parse(dtgTripList[dtgTripList.Columns["StartTime"].Index, rowIndex].Value.ToString()),
                    Endtime = DateTime.Parse(dtgTripList[dtgTripList.Columns["EndTime"].Index, rowIndex].Value.ToString()),
                    Accommodation = dtgTripList[dtgTripList.Columns["Accommodation"].Index, rowIndex].Value.ToString(),
                    Description = dtgTripList[dtgTripList.Columns["Description"].Index, rowIndex].Value.ToString(),
                    Price = decimal.Parse(dtgTripList[dtgTripList.Columns["Price"].Index, rowIndex].Value.ToString()),
                    Capacity = int.Parse(dtgTripList[dtgTripList.Columns["Capacity"].Index, rowIndex].Value.ToString()),
                    Status = bool.Parse(dtgTripList[dtgTripList.Columns["Status"].Index, rowIndex].Value.ToString()),
                    TourId = int.Parse(dtgTripList[dtgTripList.Columns["TourId"].Index, rowIndex].Value.ToString()),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Trip");
            }
            return trip;
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

        

        private void dtgTripList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            tripID = (int)dtgTripList.Rows[rowIndex].Cells[0].Value;
        }


        private void btnDeleteTrip_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure want to delete this trip ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    var tri = tripRepository.GetTripByID(tripID);
                    if (tri != null)
                    {
                        tri.Status = false;
                        tripRepository.UpdateTrip(tri);
                        MessageBox.Show("Delete successfully");
                    }
                }            
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Trip");
            }
        }
    }
}

 
        
       
