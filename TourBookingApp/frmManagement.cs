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
        IUserRepository userRepository = new UserRepository();
        BindingSource source;
        public int tripID;
        public int tourID;
        private int tempBookingId;
        public List<TblTrip> listTripFilter = null;

        public frmManagement()
        {
            InitializeComponent();

        }
        private void frmManagement_Load_1(object sender, EventArgs e)
        {
            if (frmLogin.canLog == true)
            {
                LoadTourList();
                LoadTripList();
                CheckStatus();
                btnCancelBooking.Enabled = false;
                cboSelect.SelectedIndex = 0;
                
            }
            else
            {
                this.Hide();

                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }
        }

        private void CheckStatus()
        {
            bool checkstatus = false;
            List<TblTour> tourcheck = (List<TblTour>)tourRepository.GetTours();
            for (int i = 0; i < tourcheck.Count; i++)
            {
                if (tourcheck[i].Status == true)
                {
                    checkstatus = true;
                }
            }
            if (checkstatus == true)
            {
                btnAddTrip.Enabled = true;
            }
            else
            {
                btnAddTrip.Enabled = false;
            }
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
            LoadTripList();
            CheckStatus();
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
                        MessageBox.Show("Delete successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    List<TblTrip> listtrip = new List<TblTrip>();
                    listtrip = (List<TblTrip>)tripRepository.GetTripByTourID(tourID);
                    foreach (var c in listtrip)
                    {
                        c.Status = false;
                        tripRepository.UpdateTrip(c);
                        foreach (TblBooking booking in bookingRepository.GetBookingsByTripId(c.TripId))
                        {
                            booking.Status = false;
                            bookingRepository.UpdateBooking(booking);
                        }
                    }
                }
                LoadTourList();
                LoadTripList();
                cboSelect_SelectedValueChanged(cboSelect, EventArgs.Empty);
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
            if (rowIndex >= 0)
            {
                tourID = (int)dtgListTour.Rows[rowIndex].Cells[0].Value;
            }
            else
            {
                tourID = 0;
            }

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
                dtgListTour.Columns[4].Width = 528;
                dtgListTour.Columns[5].Width = 80;
                dtgListTour.Columns[0].Width = 78;
                dtgListTour.Columns[2].Width = 200;
                dtgListTour.Columns[3].Width = 205;



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
                dtgListTour.Columns[4].Width = 528;
                dtgListTour.Columns[5].Width = 80;
                dtgListTour.Columns[0].Width = 78;
                dtgListTour.Columns[2].Width = 200;
                dtgListTour.Columns[3].Width = 205;


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



        private void LoadTripList()
        {
            var trips = tripRepository.GetTrips();

            try
            {
                source = new BindingSource();
                source.DataSource = trips;

                dtgTripList.DataSource = null;
                dtgTripList.DataSource = source;
                dtgTripList.Columns[10].Visible = false;
                dtgTripList.Columns[9].Visible = false;
                dtgTripList.Columns[6].Width = 200;
                dtgTripList.Columns[8].Width = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Trip list");
            }

        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddNewTrip frm = new frmAddNewTrip
                {
                    Text = "Add Trip",
                    AddOrUpdate = false,
                };
                frm.FormClosing += new FormClosingEventHandler(this.frmAddNewTrip_FormClosing);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmAddNewTrip_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadTripList();
        }

        private void dtgTripList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GetTripInfor(e) != null)
                {
                    if (DateTime.Compare(DateTime.Now.AddDays(3), GetTripInfor(e).StartTime) > 0)
                    {
                        frmAddNewTrip frmDetails = new frmAddNewTrip
                        {
                            Text = "Update Trip",
                            AddOrUpdate = true,
                            IsOutOfDate = true,
                            trip = GetTripInfor(e),
                        };
                        frmDetails.FormClosing += new FormClosingEventHandler(this.frmAddNewTrip_FormClosing);
                        frmDetails.ShowDialog();
                    }
                    else
                    {
                        frmAddNewTrip frmDetails = new frmAddNewTrip
                        {
                            Text = "Update Trip",
                            AddOrUpdate = true,
                            IsOutOfDate = false,
                            trip = GetTripInfor(e),
                        };
                        frmDetails.FormClosing += new FormClosingEventHandler(this.frmAddNewTrip_FormClosing);
                        frmDetails.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private TblTrip GetTripInfor(DataGridViewCellEventArgs e)
        {
            
            TblTrip trip = null;
            try
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0)
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Trip");
            }
            return trip;
        }

        private void dtgTripList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var rowIndex = e.RowIndex;
                if (rowIndex >= 0)
                {
                    tripID = (int)dtgTripList.Rows[rowIndex].Cells[0].Value;
                }
                else
                {
                    tripID = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteTrip_Click(object sender, EventArgs e)
        {
            var tri = tripRepository.GetTripByID(tripID);
            try
            {
                if (tri != null && tri.Status == false)
                {

                    MessageBox.Show("This trip hase been already deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tri == null)
                {
                    MessageBox.Show("Please choose a trip first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tri != null && tri.Status == true)
                {

                    DialogResult result = MessageBox.Show("Are you sure want to delete this trip ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        tri.Status = false;
                        tripRepository.UpdateTrip(tri);
                        foreach (TblBooking booking in bookingRepository.GetBookingsByTripId(tri.TripId))
                        {
                            booking.Status = false;
                            bookingRepository.UpdateBooking(booking);
                        }
                        MessageBox.Show("Delete successfully");

                    }
                }
                LoadTripList();
                cboSelect_SelectedValueChanged(cboSelect, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Trip");
            }
        }

        private void cbxTripFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (listTripFilter != null)
                {
                    if (cbxTripFilter.SelectedIndex == 0)
                    {
                        source = new BindingSource();
                        source.DataSource = listTripFilter;

                        dtgTripList.DataSource = null;
                        dtgTripList.DataSource = source;
                        dtgTripList.Columns[10].Visible = false;
                        dtgTripList.Columns[9].Visible = false;
                        dtgTripList.Columns[6].Width = 200;
                        dtgTripList.Columns[8].Width = 100;
                    }
                    else if (cbxTripFilter.SelectedIndex == 1)
                    {
                        List<TblTrip> listtrip = new List<TblTrip>();
                        foreach (var c in listTripFilter)
                        {
                            if (c.Status == true)
                            {
                                listtrip.Add(c);
                            }
                        }
                        source = new BindingSource();
                        source.DataSource = listtrip;

                        dtgTripList.DataSource = null;
                        dtgTripList.DataSource = source;
                        dtgTripList.Columns[10].Visible = false;
                        dtgTripList.Columns[9].Visible = false;
                        dtgTripList.Columns[6].Width = 200;
                        dtgTripList.Columns[8].Width = 100;
                    }
                    else
                    {
                        List<TblTrip> listtrip = new List<TblTrip>();
                        foreach (var c in listTripFilter)
                        {
                            if (c.Status == false)
                            {
                                listtrip.Add(c);
                            }
                        }
                        source = new BindingSource();
                        source.DataSource = listtrip;

                        dtgTripList.DataSource = null;
                        dtgTripList.DataSource = source;
                        dtgTripList.Columns[10].Visible = false;
                        dtgTripList.Columns[9].Visible = false;
                        dtgTripList.Columns[6].Width = 200;
                        dtgTripList.Columns[8].Width = 100;
                    }

                }
                else
                {
                    if (cbxTripFilter.SelectedIndex == 0)
                    {
                        LoadTripList();
                    }
                    else if (cbxTripFilter.SelectedIndex == 1)
                    {
                        List<TblTrip> listtrip = new List<TblTrip>();
                        var trip = tripRepository.GetTrips();
                        foreach (var c in trip)
                        {
                            if (c.Status == true)
                            {
                                listtrip.Add(c);
                            }
                        }
                        source = new BindingSource();
                        source.DataSource = listtrip;

                        dtgTripList.DataSource = null;
                        dtgTripList.DataSource = source;
                        dtgTripList.Columns[10].Visible = false;
                        dtgTripList.Columns[9].Visible = false;
                    }
                    else
                    {
                        List<TblTrip> listtrip = new List<TblTrip>();
                        var trip = tripRepository.GetTrips();
                        foreach (var c in trip)
                        {
                            if (c.Status == false)
                            {
                                listtrip.Add(c);
                            }
                        }
                        source = new BindingSource();
                        source.DataSource = listtrip;

                        dtgTripList.DataSource = null;
                        dtgTripList.DataSource = source;
                        dtgTripList.Columns[10].Visible = false;
                        dtgTripList.Columns[9].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindTrip_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Compare(DTPFilterStart.Value, DTPFilterEnd.Value) > 0)
                {
                    MessageBox.Show("Please choose the End Day beyond Start day", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var trip = tripRepository.GetTrips();
                    List<TblTrip> listtrip = new List<TblTrip>();
                    foreach (var t in trip)
                    {
                        if (DateTime.Compare(t.StartTime, DTPFilterStart.Value) >= 0 && DateTime.Compare(t.Endtime, DTPFilterEnd.Value) <= 0)
                        {
                            listtrip.Add(t);
                        }
                    }
                    if (listtrip.Count == 0)
                    {
                        MessageBox.Show("There are no trips", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        source = new BindingSource();
                        source.DataSource = listtrip;

                        dtgTripList.DataSource = null;
                        dtgTripList.DataSource = source;
                        listTripFilter = listtrip;
                        dtgTripList.Columns[10].Visible = false;
                        dtgTripList.Columns[9].Visible = false;
                        dtgTripList.Columns[6].Width = 200;
                        dtgTripList.Columns[8].Width = 100;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshTrip_Click(object sender, EventArgs e)
        {
            try
            {
                LoadTripList();
                listTripFilter = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //* BOOKING ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        private void cboSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvBooking.Columns.Clear();
            dgvSelectList.Columns.Clear();
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
                dgvSelectList.Columns.Add("TourName", "TourName");
                dgvSelectList.Columns["TblBookings"].Visible = false;
                dgvSelectList.Columns["TourId"].DisplayIndex = 1;
                dgvSelectList.Columns["TourName"].DisplayIndex = 2;
                for (int i = 0; i < dgvSelectList.RowCount; i++)
                {
                    int tourId = Int32.Parse(dgvSelectList.Rows[i].Cells[8].Value.ToString());
                    //MessageBox.Show();
                    dgvSelectList.Rows[i].Cells[11].Value = tourRepository.GetTourByID(tourId).TourName;
                }
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
                dgvBooking.Columns.Clear();
                source = new BindingSource();
                if (cboSelect.SelectedItem.ToString() == "Customer")
                {
                    if (GetCustomerObject(e) != null)
                    {
                        source.DataSource = bookingRepository.GetBookingsByCustomerId(GetCustomerObject(e).CustomerId);
                        dgvBooking.DataSource = null;
                        dgvBooking.DataSource = source;
                        dgvBooking.Columns["Customer"].Visible = false;
                        dgvBooking.Columns["Trip"].Visible = false;
                        dgvBooking.Columns["User"].Visible = false;
                        dgvBooking.Columns["CustomerId"].Visible = false;
                        dgvBooking.Columns.Add("Tour", "Tour");
                        dgvBooking.Columns.Add("UserName", "UserName");
                        dgvBooking.Columns["Tour"].DisplayIndex = 2;
                        dgvBooking.Columns["UserName"].DisplayIndex = 4;
                        for (int i = 0; i < dgvBooking.RowCount; i++)
                        {
                            int tripId = Int32.Parse(dgvBooking.Rows[i].Cells[1].Value.ToString());
                            //MessageBox.Show();
                            dgvBooking.Rows[i].Cells[11].Value = tourRepository.GetTourByID(tripRepository.GetTripByID(tripId).TourId).TourName;
                            int userId = Int32.Parse(dgvBooking.Rows[i].Cells[2].Value.ToString());
                            dgvBooking.Rows[i].Cells[12].Value = userRepository.GetUserByID(userId).Name;
                        }
                    }

                }
                else
                {
                    if (GetTripObject(e) != null)
                    {
                        source.DataSource = bookingRepository.GetBookingsByTripId(GetTripObject(e).TripId);
                        dgvBooking.DataSource = null;
                        dgvBooking.DataSource = source;
                        dgvBooking.Columns["Customer"].Visible = false;
                        dgvBooking.Columns["Trip"].Visible = false;
                        dgvBooking.Columns["User"].Visible = false;
                        dgvBooking.Columns["TripId"].Visible = false;
                        dgvBooking.Columns.Add("CustomerName", "CustomerName");
                        dgvBooking.Columns.Add("CustomerEmail", "CustomerEmail");
                        dgvBooking.Columns.Add("UserName", "UserName");
                        dgvBooking.Columns["CustomerId"].DisplayIndex = 1;
                        dgvBooking.Columns["CustomerName"].DisplayIndex = 2;
                        dgvBooking.Columns["CustomerEmail"].DisplayIndex = 3;
                        dgvBooking.Columns["UserId"].DisplayIndex = 4;
                        dgvBooking.Columns["UserName"].DisplayIndex = 5;
                        for (int i = 0; i < dgvBooking.RowCount; i++)
                        {
                            int customerId = Int32.Parse(dgvBooking.Rows[i].Cells[3].Value.ToString());
                            dgvBooking.Rows[i].Cells[11].Value = customerRepository.GetCustomerByID(customerId).Name;
                            dgvBooking.Rows[i].Cells[12].Value = customerRepository.GetCustomerByID(customerId).Email;
                            int userId = Int32.Parse(dgvBooking.Rows[i].Cells[2].Value.ToString());
                            dgvBooking.Rows[i].Cells[13].Value = userRepository.GetUserByID(userId).Name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load booking list");
            }
        }

        private TblTrip GetTripObject(DataGridViewCellEventArgs e)
        {

            TblTrip trip = null;

            try
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0)
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return trip;
        }

        private TblCustomer GetCustomerObject(DataGridViewCellEventArgs e)
        {

            TblCustomer customer = null;

            try
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0)
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return customer;
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (tempBookingId != 0)
                {

                    DialogResult result = MessageBox.Show("Are you sure to cancel this booking?", "Booking management - Cancel", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        TblBooking booking = bookingRepository.GetBookingByID(tempBookingId);
                        if (booking.Status == false)
                        {
                            tempBookingId = 0;
                            btnCancelBooking.Enabled = false;
                            throw new Exception("This booking has been cancelled");
                        }
                        if (DateTime.Compare(DateTime.Now.AddDays(3), tripRepository.GetTripByID(booking.TripId).StartTime) > 0)
                        {
                            tempBookingId = 0;
                            btnCancelBooking.Enabled = false;
                            throw new Exception("Booking can only be canceled at least 3 days before the trip");
                        }
                        else
                        {
                            booking.Status = false;
                            bookingRepository.UpdateBooking(booking);
                        }
                    }
                }
                else
                {
                    btnCancelBooking.Enabled = false;
                    throw new Exception("Please select a booking to cancel");
                }
                if (this.dgvSelectList.CurrentCell != null && this.dgvSelectList.CurrentRow != null)
                {
                    dgvSelectList_CellDoubleClick(this.dgvSelectList, new DataGridViewCellEventArgs(this.dgvSelectList.CurrentCell.ColumnIndex, this.dgvSelectList.CurrentRow.Index));
                }
                //reset tempBookingID value
                tempBookingId = 0;
                btnCancelBooking.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cancel booking");
            }
        }

        private void dgvBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvBooking.Rows[e.RowIndex];
                    this.tempBookingId = int.Parse(row.Cells["BookingId"].Value.ToString());
                }
                if (tempBookingId != 0)
                {
                    btnCancelBooking.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cancel booking");
            }
        }

        private void frmManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}




