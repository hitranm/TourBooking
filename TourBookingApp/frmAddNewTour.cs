using System;
using System.Windows.Forms;
using DataAccess.Repository;
using DataAccess.DataAccess;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TourBookingApp
{
    public partial class frmAddNewTour : Form
    {
        ITripRepository tripRepository = new TripRepository();
        IBookingRepository bookingRepository = new BookingRepository();
        public ITourRepository tourRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public TblTour TourInfo { get; set; }
        public frmAddNewTour()
        {
            InitializeComponent();
        }




        private void frmAddNewTour_Load(object sender, EventArgs e)
        {
            if (frmLogin.canLog == true)
            {
                txtTourID.Enabled = !InsertOrUpdate;
                if (InsertOrUpdate == true)
                {
                    
                    txtTourID.Text = TourInfo.TourId.ToString();
                    txtTourName.Text = TourInfo.TourName;
                    txtDeparture.Text = TourInfo.Departure;
                    txtDestination.Text = TourInfo.Destination;
                    txtDescription.Text = TourInfo.Description;
                    cbStatus.Checked = TourInfo.Status;
                    
                }
                else
                {
                    lbTourID.Visible = false;
                    txtTourID.Visible = false;
                    cbStatus.Enabled = false;
                }

            }
            else
            {

                frmLogin frm = new frmLogin();
                this.Hide();
                frm.ShowDialog();

            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult ms;
            if (InsertOrUpdate == true)
            {
                ms = MessageBox.Show("Do you want to update this tour?","Warning", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            else
            {
                 ms = MessageBox.Show("Do you want to add this tour?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            if (DialogResult.OK == ms)
            {


                try
                {
                    if (InsertOrUpdate == false)
                    {
                        var touAdd = new TblTour
                        {

                            TourName = txtTourName.Text,
                            Departure = txtDeparture.Text,
                            Destination = txtDestination.Text,
                            Description = txtDescription.Text,
                            Status = cbStatus.Checked,
                        };
                        ValidationContext context = new ValidationContext(touAdd, null, null);
                        IList<ValidationResult> errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(touAdd, context, errors, true))
                        {
                            foreach (ValidationResult result1 in errors)
                            {
                                MessageBox.Show(result1.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else
                        {
                            tourRepository.InsertTour(touAdd);
                            MessageBox.Show("Tour Added!!", "Add Tour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                    }
                    else

                    {
                        var touUp = new TblTour
                        {
                            TourId = int.Parse(txtTourID.Text),
                            TourName = txtTourName.Text,
                            Departure = txtDeparture.Text,
                            Destination = txtDestination.Text,
                            Description = txtDescription.Text,
                            Status = cbStatus.Checked,
                        };
                        ValidationContext context = new ValidationContext(touUp, null, null);
                        IList<ValidationResult> errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(touUp, context, errors, true))
                        {
                            foreach (ValidationResult result1 in errors)
                            {
                                MessageBox.Show(result1.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else
                        {
                            tourRepository.UpdateTour(touUp);
                            if (touUp.Status == false)
                            {
                                var triplist = tripRepository.GetTripByTourID(touUp.TourId);
                                foreach (var i in triplist)
                                {
                                    i.Status = false;
                                    tripRepository.UpdateTrip(i);
                                    foreach (TblBooking booking in bookingRepository.GetBookingsByTripId(i.TripId))
                                    {
                                        booking.Status = false;
                                        bookingRepository.UpdateBooking(booking);
                                    }
                                }
                            }
                            MessageBox.Show("Tour Updated!!", "Update Tour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a tour" : "Update a tour");
                }
            }
            else
            {
                this.Show();
            }
            
        }


    }
}
