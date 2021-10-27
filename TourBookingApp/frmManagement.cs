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
        public int tourID;

        public frmManagement()
        {
            InitializeComponent();
            
        }       
        private void frmManagement_Load_1(object sender, EventArgs e)
        {
            LoadTourList();
            LoadTripList();
        }



        //*TOUR ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



        private void dtgListTour_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var tour = new TblTour
            {
                TourId = int.Parse(dtgListTour[dtgListTour.Columns["TourId"].Index, dtgListTour.CurrentRow.Index].Value.ToString()),
                TourName = (dtgListTour[dtgListTour.Columns["TourName"].Index, dtgListTour.CurrentRow.Index].Value.ToString()),
                Departure = (dtgListTour[dtgListTour.Columns["Departure"].Index, dtgListTour.CurrentRow.Index].Value.ToString()),
                Destination = (dtgListTour[dtgListTour.Columns["Destination"].Index, dtgListTour.CurrentRow.Index].Value.ToString()),
                Description = (dtgListTour[dtgListTour.Columns["Description"].Index, dtgListTour.CurrentRow.Index].Value.ToString()),
                Status = bool.Parse(dtgListTour[dtgListTour.Columns["Status"].Index, dtgListTour.CurrentRow.Index].Value.ToString()),
            };

            frmAddNewTour frm = new frmAddNewTour
            {
                Text = "Update Tour",
                InsertOrUpdate = true,
                TourInfo = tour,
                tourRepository = tourRepository

            };
            frm.FormClosing += new FormClosingEventHandler(this.frmAddNewTour_FormClosing);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadTours();
                source.Position = source.Count - 1;
            }
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            frmAddNewTour frm = new frmAddNewTour
            {
                Text = "Add tour",
                InsertOrUpdate = false,
                tourRepository = tourRepository

            };
            frm.FormClosing += new FormClosingEventHandler(this.frmAddNewTour_FormClosing);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadTours();
                source.Position = source.Count - 1;
            }
        }

        private void frmAddNewTour_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadTourList();
        }

        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            var tou = tourRepository.GetTourByID(tourID);
            try
            {
                if (tou != null && tou.Status == false)
                {

                    MessageBox.Show("This tour hase been already deleted !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tou == null)
                {
                    MessageBox.Show("Please choose a tour first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tou != null && tou.Status == true)
                {

                    DialogResult result = MessageBox.Show("Are you sure want to delete this tour ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        tou.Status = false;
                        tourRepository.UpdateTour(tou);
                        MessageBox.Show("Delete successfully","Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }


                    List<TblTrip> listtrip = new List<TblTrip>();
                    listtrip = (List<TblTrip>)tripRepository.GetTripByTourID(tourID);
                    foreach (var c in listtrip)
                    {
                        c.Status = false;
                        tripRepository.UpdateTrip(c);
                    }

                    LoadTourList();
                    LoadTripList();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Tour");
            }
        }

    private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadOneTour();
        }

        private void dtgListTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            tourID = (int)dtgListTour.Rows[rowIndex].Cells[0].Value;

        }

        private void LoadOneTour()
        {
            ITourRepository tourRepository = new TourRepository();
            bool hasTour = false;

            var tour = new List<TblTour>();
            var tours = tourRepository.GetTours();
            try
            {
                foreach (var i in tours)
                {
                    if (i.TourName.Contains(txtSearchTour.Text))
                    {
                        hasTour = true;
                        tour.Add(i);
                    }
                }
                        source = new BindingSource();
                        source.DataSource = tour;


                        dtgListTour.DataSource = null;
                        dtgListTour.DataSource = source;
                        dtgListTour.Columns[6].Visible = false;
                        dtgListTour.Columns[4].Width = 400;
                        dtgListTour.Columns[5].Width = 75;
                        dtgListTour.Columns[0].Width = 75;
                        dtgListTour.Columns[2].Width = 200;
                        dtgListTour.Columns[3].Width = 200;
                        
                    
                
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
           
        public void LoadTourList()
        {
            var tours = tourRepository.GetTours();

            try
            {
                source = new BindingSource();
                source.DataSource = tours;

                dtgListTour.DataSource = null;
                dtgListTour.DataSource = source;
                dtgListTour.Columns[6].Visible = false;
                dtgListTour.Columns[4].Width = 400;
                dtgListTour.Columns[5].Width = 75;
                dtgListTour.Columns[0].Width = 75;
                dtgListTour.Columns[2].Width = 200;
                dtgListTour.Columns[3].Width = 200;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Tour list");
            }
        }

        private void LoadTours()
        {
            var tour = tourRepository.GetTours();
            source = new BindingSource();
            source.DataSource = tour;
            dtgListTour.DataSource = null;
            dtgListTour.DataSource = source;
            

        }



        //* TRIP ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



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

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            frmAddNewTrip frm = new frmAddNewTrip
            {
                Text = "Add Trip",
                AddOrUpdate = false,
            };
            frm.FormClosing += new FormClosingEventHandler(this.frmAddNewTrip_FormClosing);
            frm.ShowDialog();

        }

        private void frmAddNewTrip_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadTripList();
        }

        private void dtgTripList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAddNewTrip frmDetails = new frmAddNewTrip
            {
                Text = "Update Trip",
                AddOrUpdate = true,
                trip = GetTripInfor(e),
            };
            frmDetails.FormClosing += new FormClosingEventHandler(this.frmAddNewTrip_FormClosing);
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
                LoadTripList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Trip");
            }
        }



        //* BOOKING ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


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

 
        
       
