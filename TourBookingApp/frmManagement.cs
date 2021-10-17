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
        BindingSource source;

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
     

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadOneTour(txtSearch.Text);
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
                tourRepository=tourRepository

            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadTours();
                source.Position = source.Count - 1;
            }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTripList();
        }

        
    }
}
