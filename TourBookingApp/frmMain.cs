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
    public partial class frmMain : Form
    {
        ITourRepository tourRepository = new TourRepository();
        ITripRepository tripRepository = new TripRepository();
        BindingSource source;
        public int m = 0;
        public Boolean isAdmin { get; set; }
        public int currentID { get; set; }
        public frmLogin frm { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadTourList();



            if (isAdmin == false)
            {
                manageToolStripMenuItem.Enabled = false;
            }
            else manageToolStripMenuItem.Enabled = true;

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

                bool isvisible;
                for (int i = 1; i < dtgTourList.RowCount - 1; i++)
                {
                    isvisible = bool.Parse(dtgTourList[dtgTourList.Columns["Status"].Index, i].Value.ToString());
                    if (isvisible == false)
                    {
                        dtgTourList.Rows[i].Visible = false;
                    }
                }
                dtgTourList.Columns[6].Visible = false;
                dtgTourList.Columns[5].Visible = false;


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



        private void LoadOneTour()
        {
            bool hasTour = false;

            var tour = new List<TblTour>();
            var tours = tourRepository.GetTours();
            try
            {
                foreach (var i in tours)
                {
                    if (i.TourName.Contains(txtSearchTour.Text) && i.Status == true)
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


            }
            catch (Exception e)
            {
                MessageBox.Show("There are no tours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (hasTour == false)
            {
                MessageBox.Show("There are no tours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTripList(int TourID)
        {
            var trips = tripRepository.GetTripByTourID(TourID);
            if (trips == null)
            {
                MessageBox.Show("No trip available", "Trip Error");
            }
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

                bool isvisible;
                for (int i = 1; i < dtgTripList.RowCount - 1; i++)
                {
                    isvisible = bool.Parse(dtgTripList[dtgTripList.Columns["Status"].Index, i].Value.ToString());
                    if (isvisible == false || DateTime.Parse(dtgTripList[dtgTripList.Columns["StartTime"].Index, i].Value.ToString()).Date.Day + 3 > DateTime.Now.Day)
                    {
                        dtgTripList.Rows[i].Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load trip list");
            }
        }

        private TblTrip GetTrip(DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            TblTrip trip = null;
            try
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
            frm.ShowDialog();
        }


        private void logoutToolStripMenuItem_Click_2(object sender, EventArgs e)
        {

            DialogResult msg = MessageBox.Show("Do you really want to logout?", "Messaage Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (msg == DialogResult.OK)
            {
                m = -1;
                this.Close();
            }
        }



        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadTourList();
        }

        private void dtgTourList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LoadTripList(int.Parse(txtTourID.Text));
        }

        private void dtgTripList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmBooking frmBooking = new frmBooking
            {
                TripRepository = tripRepository,
                TripInfo = GetTrip(e),
                userID = this.currentID
            };
            if (frmBooking.ShowDialog() == DialogResult.OK)
            {

            }


        }
    }
}



