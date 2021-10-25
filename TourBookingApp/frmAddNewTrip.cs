using DataAccess.DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
                if (AddOrUpdate == false) // add
                {
                    var tripA = new TblTrip
                    {
                        StartTime = DTPStartTime.Value,
                        Endtime = DTPEndTime.Value,
                        Price = decimal.Parse(mtxtPrice.Text),
                        Capacity = int.Parse(NUDCapacity.Value.ToString()),
                        Accommodation = txtAccommodation.Text,
                        Description = txtDescription.Text,
                        TourId = tourID,
                        Status=true
                    };                   
                    DialogResult result = MessageBox.Show("Are you sure want to add this trip ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        if (DTPStartTime.Value.Date.Day < DateTime.Now.Day + 7 && DTPEndTime.Value.Date.Day < DTPStartTime.Value.Date.Day)
                        {
                            MessageBox.Show("Please set the Start day beyond the present time at least 7 days and" +
                                " the end day beyond the start day !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        ValidationContext context = new ValidationContext(tripA, null, null);
                        IList<ValidationResult> errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(tripA, context, errors, true))
                        {
                            foreach (ValidationResult result1 in errors)
                            {
                                MessageBox.Show(result1.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else
                        {
                            tripRepository.InsertTrip(tripA);
                            DialogResult result2 = MessageBox.Show("Trip added, Do you want to add another one ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
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
                    }
                    else
                    {
                        Close();
                    }
                }
                else // update
                {                   
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
                    DialogResult result = MessageBox.Show("Are you sure want to update this trip ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        if (DTPStartTime.Value.Date.Day < DateTime.Now.Day  && DTPEndTime.Value.Date.Day < DTPStartTime.Value.Date.Day)
                        {
                            MessageBox.Show("Please set the Start day beyond the present time and" +
                                " the end day beyond the start day !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        ValidationContext context = new ValidationContext(tripU, null, null);
                        IList<ValidationResult> errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(tripU, context, errors, true))
                        {
                            foreach (ValidationResult result1 in errors)
                            {
                                MessageBox.Show(result1.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else
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
                    }
                    else
                    {
                        Close();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("The Price field is required", AddOrUpdate == false ? "Add new trip" : "Update a trip");

            }
        }


        private void frmAddNewTrip_Load(object sender, EventArgs e)
        {
            if (AddOrUpdate == true)
            {
                cbxListTourName.Text = tourRepository.GetTourByID(trip.TourId).TourName.ToString();               
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
                if (tourRepository.GetTourByID(trip.TourId).Status == false)
                {
                    cbTripStatus.Enabled = false;
                }
                else
                {
                    cbTripStatus.Enabled = true;
                }
            }
            else
            {
                cbTripStatus.Checked = true;
                cbTripStatus.Enabled = false;
            }
        }

        
    }
}


