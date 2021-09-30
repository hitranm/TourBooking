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
        public bool isAdmin { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (isAdmin == false)
            {
                textBox1.Text = "Tui là nhân viên";
            }
            else
                textBox1.Text = "Tui là admin";

        }
    }
}
