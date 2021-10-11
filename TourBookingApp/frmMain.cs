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
                btnManage.Enabled = false;
            }
            else btnManage.Enabled = true;

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
                if (tours.Count() == 0)
                {
                    ClearText();
                    btnDetail.Enabled = false;
                }
                else
                {
                    btnDetail.Enabled = true;
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
        private void btnLogout_Click(object sender, EventArgs e)
        {
            m = -1;
            this.Close();


        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            LoadTripList(int.Parse(txtTourID.Text));
        }
        private void LoadOneTour(string name)
        {
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
                MessageBox.Show(e.Message, "Load tour");
            }
            if (hasTour == false)
            {
                MessageBox.Show("There are no tours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTripList(int TourID)
        {
            var trips = tripRepository.GetTripByTourID(TourID);
            try
            {
                source = new BindingSource();
                source.DataSource = trips;



                dtgTripList.DataSource = null;
                dtgTripList.DataSource = source;
                if (trips == null)
                {
                    MessageBox.Show("No trip available", "Trip Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load trip list");
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            frmManagement frm = new frmManagement();
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadOneTour(txtTourName.Text);
        }

        private void txtSearchTour_TextChanged(object sender, EventArgs e)
        {
            if(txtTourName.Text== null)
            {
                LoadTourList();
            }
        }
    }
}
