using DataAccess.DataAccess;
using DataAccess.Repository;
using System;
using System.Windows.Forms;

namespace TourBookingApp
{
    public partial class frmAddNewTour : Form
    {
       
        public ITourRepository tourRepository { get; set; }
        public bool InsertOrUpdate{get;set;}
        public TblTour TourInfo { get; set; }
        public frmAddNewTour()
        {
            InitializeComponent();
        }

       
       

        private void frmAddNewTour_Load(object sender, EventArgs e)
        {
            txtTourID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
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
            }
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            try {
                if (InsertOrUpdate == false)
                {
                    var touAdd = new TblTour
                    {

                        TourName = txtTourName.Text,
                        Departure = txtDeparture.Text,
                        Destination = txtDeparture.Text,
                        Description = txtDescription.Text,
                        Status = cbStatus.Checked,
                    };
                    if (txtTourName.Text=="" ||txtDeparture.Text=="" || txtDescription.Text=="" || txtDestination.Text=="")
                    {
                        MessageBox.Show("Please fill in all fields!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                    else {
                        tourRepository.InsertTour(touAdd);
                        MessageBox.Show("Tour Added!!", "Add Tour", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else

                {
                    var touUp = new TblTour
                    {
                        TourId= int.Parse(txtTourID.Text),
                        TourName = txtTourName.Text,
                        Departure = txtDeparture.Text,
                        Destination = txtDeparture.Text,
                        Description = txtDescription.Text,
                        Status = cbStatus.Checked,
                    };
                    if (txtTourName.Text == "" || txtDeparture.Text == "" || txtDescription.Text == "" || txtDestination.Text == "")
                    {
                        MessageBox.Show("Please fill in all fields!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        tourRepository.UpdateTour(touUp);
                        MessageBox.Show("Tour Updated!!", "Update Tour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a tour" : "Update a tour");
                }
     }
    }
}
