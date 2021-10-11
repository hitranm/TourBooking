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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddNewTour frm = new frmAddNewTour();
            frm.ShowDialog();
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

        private void dtgTripList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
