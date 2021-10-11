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
        BindingSource source;
        public frmManagement()
        {
            InitializeComponent();
           
            
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewTour frm = new frmAddNewTour();
            frm.ShowDialog();
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
            var tour = tourRepository.GetTours();
            source = new BindingSource();
            source.DataSource = tour;
            dgvTour.DataSource = null;
            dgvTour.DataSource = source;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void frmManagement_Load(object sender, EventArgs e)
        {
            var tour = tourRepository.GetTours();
            source = new BindingSource();
            source.DataSource = tour;
            dgvTour.DataSource = null;
            dgvTour.DataSource = source;
        }
    }
}
