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
    public partial class frmAddNewTour : Form
    {
        ITourRepository tour = new TourRepository();
        public frmAddNewTour()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmAddNewTour_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmManagement frm = new frmManagement();

            var tou = new TblTour() { TourName = txtTourName.Text, Departure = txtDeparture.Text, Destination = txtDestination.Text, Description = txtDescription.Text, Status = cbStatus.Checked };
            if (txtTourName.Text == "" && txtDestination.Text == "" && txtDescription.Text
                == "" && txtDeparture.Text == "")
            {
                MessageBox.Show("Empty infromation !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else tour.InsertTour(tou);
            MessageBox.Show("Tour Added !!", "Successfully", MessageBoxButtons.OK);
            this.Close();
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
