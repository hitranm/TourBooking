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
        IBookingRepository bookingRepository = new BookingRepository();
        int tourID;
        public bool AddOrUpdate { get; set; } // false: add, true: update
        public bool IsOutOfDate { get; set; }
        public bool Status1 { get; set; }
        public TblTrip trip { get; set; }

        public frmAddNewTrip()
        {
            InitializeComponent();
            
        }

        private void frmAddNewTrip_Load(object sender, EventArgs e)
        {
            if (frmLogin.canLog == true)
            {
                try
                {
                    LoadTourlistInCbx();
                    if (AddOrUpdate == true && IsOutOfDate == false)
                    {
                        cbxListTourName.Text = tourRepository.GetTourByID(trip.TourId).TourName.ToString();
                        cbxListTourName.Enabled = false;
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
                    }else if(AddOrUpdate == true && IsOutOfDate == true)
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
                        cbTripStatus.Enabled = false;
                        cbxListTourName.Enabled = false;
                        DTPStartTime.Enabled = false;
                        DTPEndTime.Enabled = false;
                        mtxtPrice.Enabled = false;
                        NUDCapacity.Enabled = false;
                        txtAccommodation.Enabled = false;
                        txtDescription.Enabled = false;
                    }
                    else
                    {
                        cbTripStatus.Checked = true;
                        cbTripStatus.Enabled = false;
                        lbTripId.Visible = false;
                        txtTripID.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

                this.Hide();
                frmLogin frm = new frmLogin();
                frm.ShowDialog();

            }
        }

        private void cbxListTourName_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {


                ComboBox cb = sender as ComboBox;
                if (cb.SelectedValue != null)
                {
                    TblTour tour = cb.SelectedValue as TblTour;
                    tourID = tour.TourId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadTourlistInCbx()
        {
            try
            {
                var tours = tourRepository.GetTours();
                List<TblTour> listtour = new List<TblTour>();
                foreach (var c in tours)
                {
                    if (c.Status == true)
                    {
                        listtour.Add(c);
                    }
                }
                cbxListTourName.DataSource = listtour;
                cbxListTourName.DisplayMember = "TourName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {

            try
            {
                if (AddOrUpdate == false) // ADD
                {                                   
                    DialogResult result = MessageBox.Show("Are you sure want to add this trip ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        if (DateTime.Compare(DateTime.Now.AddDays(7), DTPStartTime.Value) > 0 || DateTime.Compare(DTPStartTime.Value, DTPEndTime.Value) > 0)
                        {
                            throw new Exception ("Please set the Start day beyond the present time at least 7 days and" +
                                " the end day beyond the start day !");                           
                        }
                        if (string.IsNullOrEmpty(mtxtPrice.Text))
                        {
                            throw new Exception("The Price field is required");
                        }                       
                        var tripA = new TblTrip
                        {
                            StartTime = DTPStartTime.Value,
                            Endtime = DTPEndTime.Value,
                            Price = decimal.Parse(mtxtPrice.Text),
                            Capacity = int.Parse(NUDCapacity.Value.ToString()),
                            Accommodation = txtAccommodation.Text,
                            Description = txtDescription.Text,
                            TourId = tourID,
                            Status = true
                        };
                        ValidationContext context = new ValidationContext(tripA, null, null);                     
                        IList<ValidationResult> errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(tripA, context, errors, true))
                        {
                            foreach (ValidationResult result1 in errors)
                            {
                                throw new Exception(result1.ErrorMessage);
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
                else // UPDATE
                {
                                       
                    DialogResult result = MessageBox.Show("Are you sure want to update this trip ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        if (DateTime.Compare(DateTime.Now.AddDays(3), DTPStartTime.Value) >0 || DateTime.Compare(DTPStartTime.Value, DTPEndTime.Value )> 0)
                        {
                            throw new Exception ("Please set the Start day beyond the present time 3 days and" +
                                " the end day beyond the start day !");
                            
                        }
                        if (string.IsNullOrEmpty(mtxtPrice.Text))
                        {
                            throw new Exception("The Price field is required");
                        }
                        var tripU = new TblTrip
                        {
                            TripId = int.Parse(txtTripID.Text.ToString()),
                            StartTime = DTPStartTime.Value,
                            Endtime = DTPEndTime.Value,
                            Price = decimal.Parse(mtxtPrice.Text),
                            Capacity = int.Parse(NUDCapacity.Value.ToString()),
                            Accommodation = txtAccommodation.Text,
                            Description = txtDescription.Text,
                            TourId = tourID,
                            Status = cbTripStatus.Checked
                        };                        
                        ValidationContext context = new ValidationContext(tripU, null, null);
                        IList<ValidationResult> errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(tripU, context, errors, true))
                        {
                            foreach (ValidationResult result1 in errors)
                            {
                                throw new Exception(result1.ErrorMessage);
                            }
                        }
                        else
                        {
                            tripRepository.UpdateTrip(tripU);
                            if (tripU.Status == false)
                            {
                                foreach (TblBooking booking in bookingRepository.GetBookingsByTripId(tripU.TripId))
                                {
                                    booking.Status = false;
                                    bookingRepository.UpdateBooking(booking);
                                }
                            }                           
                            var tri = tripRepository.GetTripByID(tripU.TripId);
                            if (tri != null)
                            {
                                MessageBox.Show("Update successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Update failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        
    }
}


