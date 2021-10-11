using DataAccess.DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourBookingApp
{
    public partial class frmAddNewTrip : Form
    {
        ITourRepository tourRepository = new TourRepository();
        ITripRepository tripRepository = new TripRepository();
        int tourID;

        public frmAddNewTrip()
        {
            InitializeComponent();
        }

        private void lbTripName_Click(object sender, EventArgs e)
        {

        }
        private void  cbxListTourName_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                TblTour tour = cb.SelectedValue as TblTour;
                 tourID = tour.TourId;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var trip = new TblTrip
                {
                     StartTime = DTPStartTime.Value,
                     Endtime = DTPEndTime.Value,
                     Price = Decimal.Parse(mtxtPrice.Text),
                     Capacity = Convert.ToInt32(NUDCapacity.Value),
                     Accommodation = txtAccomodation.Text,
                     Description = txtDescription.Text,
                     Status = true,
                     TourId = tourID

                };
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm trip này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if(result == DialogResult.Yes)
                {
                    tripRepository.InsertTrip(trip);
                    DialogResult result2 = MessageBox.Show("Đã thêm, bạn có muốn thêm trip nào khác ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                    if(result2 == DialogResult.No)
                    {
                        Close();
                    }
                    else
                    {
                        mtxtPrice.Text = string.Empty;
                        NUDCapacity.Value = 1;
                        txtAccomodation.Text = string.Empty;
                        txtDescription.Text = string.Empty;
                    }
                }
                else
                {
                    Close();
                }
                    
                
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
  

        private void btnLoadTourName_Click(object sender, EventArgs e)
        {
            var tours = tourRepository.GetTours();
            cbxListTourName.DataSource = tours;
            cbxListTourName.DisplayMember = "TourName";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
