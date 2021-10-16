using DataAccess.DataAccess;
using DataAccess.Repository;
using System;
using System.Windows.Forms;

namespace TourBookingApp
{
    public partial class frmAddNewTrip : Form
    {
        ITourRepository tourRepository = new TourRepository();
        ITripRepository tripRepository = new TripRepository();
        int tourID;
        public bool AddOrUpdate { get; set; } // false: add, true: update
        public bool Status1 { get; set; }
        public TblTrip trip { get; set; }

        public frmAddNewTrip()
        {
            InitializeComponent();
            LoadTourlistInCbx();
        }


        private void cbxListTourName_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                TblTour tour = cb.SelectedValue as TblTour;
                tourID = tour.TourId;
            }
        }

        private void LoadTourlistInCbx()
        {
            var tours = tourRepository.GetTours();
            cbxListTourName.DataSource = tours;
            cbxListTourName.DisplayMember = "TourName";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {

            try
            {

                if (AddOrUpdate == false)
                {
                    var tripA = new TblTrip
                    {
                        StartTime = DTPStartTime.Value,
                        Endtime = DTPEndTime.Value,
                        Price = decimal.Parse(mtxtPrice.Text),
                        Capacity = int.Parse(NUDCapacity.Value.ToString()),
                        Accommodation = txtAccommodation.Text,
                        Description = txtDescription.Text,
                        TourId = tourID
                    };
                    if (cbTripStatus.CheckState == CheckState.Checked)
                    {
                        tripA.Status = true;
                    }
                    else
                    {
                        tripA.Status = false;
                    }
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm trip này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        tripRepository.InsertTrip(tripA);
                        DialogResult result2 = MessageBox.Show("Đã thêm, bạn có muốn thêm trip nào khác ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);
                        if (result2 == DialogResult.No)
                        {
                            Close();
                        }
                        else
                        {
                            mtxtPrice.Text = string.Empty;
                            NUDCapacity.Value = 1;
                            txtAccommodation.Text = string.Empty;
                            txtDescription.Text = string.Empty;
                        }
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    //cbTripStatus.Enabled = true;
                    var tripU = new TblTrip
                    {
                        TripId = int.Parse(txtTripID.Text.ToString()),
                        StartTime = DTPStartTime.Value,
                        Endtime = DTPEndTime.Value,
                        Price = decimal.Parse(mtxtPrice.Text),
                        Capacity = int.Parse(NUDCapacity.Value.ToString()),
                        Accommodation = txtAccommodation.Text,
                        Description = txtDescription.Text,
                        TourId = tourID
                    };
                    if (cbTripStatus.CheckState == CheckState.Checked)
                    {
                        tripU.Status = true;
                    }
                    else
                    {
                        tripU.Status = false;
                    }
                    try
                    {
                        tripRepository.UpdateTrip(tripU);
                        var tri = tripRepository.GetTripByID(tripU.TripId);
                        if (tri != null)
                        {
                            MessageBox.Show("Update successfully");
                        }
                        else
                        {
                            MessageBox.Show("Update failed");
                        }
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Update Trip");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AddOrUpdate == false ? "Add new trip" : "Update a trip");

            }
        }


        private void frmAddNewTrip_Load(object sender, EventArgs e)
        {
            if (AddOrUpdate == true)
            {
                //cbxListTourName.SelectedValue = tourRepository.GetTourByID(trip.TourId).TourName.ToString();
                txtTripID.Text = trip.TripId.ToString();
                DTPStartTime.Value = trip.StartTime;
                DTPEndTime.Value = trip.Endtime;
                mtxtPrice.Text = trip.Price.ToString();
                NUDCapacity.Value = trip.Capacity;
                txtAccommodation.Text = trip.Accommodation.ToString();
                txtDescription.Text = trip.Description.ToString();
                if (trip.Status == true)
                {
                    cbTripStatus.Checked = true;
                }
                else
                {
                    cbTripStatus.Checked = false;
                }
            }
        }


    }
}


