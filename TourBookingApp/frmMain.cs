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
    public partial class frmMain : Form
    {
        public int m = 0;
        public Boolean isAdmin { get; set; }
        public frmLogin frm { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            m = -1;
            this.Close();

           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }
    }
}
