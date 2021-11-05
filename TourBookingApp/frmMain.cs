using DataAccess.DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace TourBookingApp
{
    public partial class frmMain : Form
    {

        ITourRepository tourRepository = new TourRepository();
        ITripRepository tripRepository = new TripRepository();
        BindingSource source;
        public static int m = 0;
        public bool isAdmin { get; set; }

        public int currentID { get; set; }
        public frmLogin frm { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (frmLogin.canLog == true)
            {
                LoadTourList();
              


                if (isAdmin == false)
                {
                    manageToolStripMenuItem.Enabled = false;
                }
                else manageToolStripMenuItem.Enabled = true;
            }

            else
            {
                this.Hide();
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }
        }
        private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult msg = MessageBox.Show("Do you really want to logout?", "Messaage Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (msg == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }



        public void LoadTourList()
        {
            var tours = tourRepository.GetTours();
            try
            {

                source = new BindingSource();
                source.DataSource = tours;
                txtTourName.DataBindings.Clear();
                txtTourID.DataBindings.Clear();
                txtDestination.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtDeparture.DataBindings.Clear();

                txtTourID.DataBindings.Add("Text", source, "TourID");
                txtTourName.DataBindings.Add("Text", source, "TourName");
                txtDeparture.DataBindings.Add("Text", source, "Departure");
                txtDestination.DataBindings.Add("Text", source, "Destination");
                txtDescription.DataBindings.Add("Text", source, "Description");

                dtgTourList.DataSource = null;
                dtgTourList.DataSource = source;
                dtgTourList.Columns[6].Visible = false;
                dtgTourList.Columns[5].Visible = false;
                dtgTourList.Columns[4].Width = 230;
                dtgTourList.Columns[0].Width = 60;

                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtgTourList.DataSource];
                currencyManager1.SuspendBinding();

                bool isvisible = true;
                bool isok = false;
                for (int i = 0; i <= dtgTourList.RowCount - 1; i++)
                {
                    isvisible = bool.Parse(dtgTourList[dtgTourList.Columns["Status"].Index, i].Value.ToString());
                    if (isvisible == false)
                    {
                        dtgTourList.Rows[i].Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                    else
                    {
                        isok = true;
                        currencyManager1.ResumeBinding();

                    }
                }
                if (isok == false)
                {
                    ClearText();

                    MessageBox.Show("There are no tours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load tour list");
            }

        }

        private void ClearText()
        {
            txtTourID.Text = string.Empty;
            txtTourName.Text = string.Empty;
            txtDestination.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtDeparture.Text = string.Empty;

        }

        private void LoadTripList(int TourID)
        {

            var trips = tripRepository.GetTripByTourID(TourID);
            if (trips.Count == 0)
            {
                MessageBox.Show("No trip available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtgTripList.DataSource = null;

            }
            else
            {
                try
                {
                    source = new BindingSource();
                    source.DataSource = trips;



                    dtgTripList.DataSource = null;
                    dtgTripList.DataSource = source;
                    dtgTripList.Columns[7].Visible = false;
                    dtgTripList.Columns[8].Visible = false;
                    dtgTripList.Columns[9].Visible = false;
                    dtgTripList.Columns[10].Visible = false;
                    dtgTripList.Columns[6].Width = 298;
                    DateTime now = DateTime.Now;
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtgTripList.DataSource];
                    currencyManager1.SuspendBinding();
                    bool isok = false;
                    bool isvisible = true;
                    for (int i = 0; i <= dtgTripList.RowCount - 1; i++)
                    {
                        var time = DateTime.Parse(dtgTripList[dtgTripList.Columns["StartTime"].Index, i].Value.ToString());
                        isvisible = bool.Parse(dtgTripList[dtgTripList.Columns["Status"].Index, i].Value.ToString());
                        if (isvisible == false || DateTime.Compare(now.AddDays(7), time) > 0)
                        {
                            dtgTripList.Rows[i].Visible = false;
                            currencyManager1.ResumeBinding();
                        }
                        else
                        {
                            isok = true;
                        }
                    }
                    if (isok == false)
                    {
                        MessageBox.Show("No trip available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtgTripList.DataSource = null;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load trip list");
                }
            }
        }



        private void LoadOneTour()
        {
            bool hasTour = false;

            var tour = new List<TblTour>();
            var tours = tourRepository.GetTours();
            try
            {
                foreach (var i in tours)
                {
                    if (i.TourName.ToUpper().Contains(txtSearchTour.Text.ToUpper()) && i.Status == true)
                    {
                        hasTour = true;
                        tour.Add(i);
                    }
                }
                source = new BindingSource();
                source.DataSource = tour;
                txtTourID.DataBindings.Clear();
                txtTourName.DataBindings.Clear();
                txtDeparture.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtDestination.DataBindings.Clear();

                txtTourID.DataBindings.Add("Text", source, "TourId");
                txtTourName.DataBindings.Add("Text", source, "TourName");
                txtDeparture.DataBindings.Add("Text", source, "Departure");
                txtDescription.DataBindings.Add("Text", source, "Description");
                txtDestination.DataBindings.Add("Text", source, "Destination");

                dtgTourList.DataSource = null;
                dtgTourList.DataSource = source;
                dtgTourList.Columns[6].Visible = false;
                dtgTourList.Columns[5].Visible = false;
                dtgTourList.Columns[4].Width = 230;
                dtgTourList.Columns[0].Width = 60;


            }
            catch (Exception)
            {
                MessageBox.Show("There are no tours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (hasTour == false)
            {
                MessageBox.Show("There are no tours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private TblTrip GetTrip(DataGridViewCellEventArgs e)
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
                        Endtime = DateTime.Parse(dtgTripList[dtgTripList.Columns["Endtime"].Index, rowIndex].Value.ToString()),
                        Accommodation = dtgTripList[dtgTripList.Columns["Accommodation"].Index, rowIndex].Value.ToString(),
                        Description = dtgTripList[dtgTripList.Columns["Description"].Index, rowIndex].Value.ToString(),
                        Price = decimal.Parse(dtgTripList[dtgTripList.Columns["Price"].Index, rowIndex].Value.ToString()),
                        Capacity = int.Parse(dtgTripList[dtgTripList.Columns["Capacity"].Index, rowIndex].Value.ToString()),
                        Status = bool.Parse(dtgTripList[dtgTripList.Columns["Status"].Index, rowIndex].Value.ToString()),
                        TourId = int.Parse(dtgTripList[dtgTripList.Columns["TourId"].Index, rowIndex].Value.ToString())
                    };
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Trip Details Error");
            }
            return trip;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadOneTour();
        }

        private void txtSearchTour_TextChanged(object sender, EventArgs e)
        {
            if (txtTourName.Text == null)
            {
                LoadTourList();
            }
        }



        private void manageToolStripMenuItem_Click_2(object sender, EventArgs e)
        {

            frmManagement frm = new frmManagement();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadTourList();
                dtgTripList.DataSource = null;
            }

        }


        private void logoutToolStripMenuItem_Click_2(object sender, EventArgs e)

        {

            DialogResult msg = MessageBox.Show("Do you really want to logout?", "Messaage Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (msg == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                m = -1;
                this.Close();
            }
        }



        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadTourList();
        }

        private void dtgTripList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GetTrip(e) != null)
            {
                frmBooking frmBooking = new frmBooking
                {
                    TripRepository = tripRepository,
                    TripInfo = GetTrip(e),
                    userID = this.currentID
                };
                if (frmBooking.ShowDialog() == DialogResult.OK)
                {
                    
                    if (this.dtgTourList.CurrentCell != null && this.dtgTourList.CurrentRow != null)
                    {
                        dtgTourList_CellDoubleClick(this.dtgTourList, new DataGridViewCellEventArgs(this.dtgTourList.CurrentCell.ColumnIndex, this.dtgTourList.CurrentRow.Index));
                    }
                    MessageBox.Show("Book trip successfully");
                }
            }
        }

        private void dtgTourList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadTripList(int.Parse(txtTourID.Text));
        }

    }
}



