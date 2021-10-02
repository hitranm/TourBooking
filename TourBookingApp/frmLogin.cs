using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.DataAccess;
using DataAccess.Repository;

namespace TourBookingApp
{
    public partial class frmLogin : Form
    {
        private UserRepository userRepository = new UserRepository();
     
        public frmLogin()
        {
            InitializeComponent();
        }
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            bool isMem = false;
            var user = userRepository.GetUsers();
            foreach(var i in user)
            {
                if (i.UserName.Equals(txtUserName.Text) && i.Password.Equals(txtPassword.Text)&&i.RoleId==1)
                {
                    frmMain frm = new frmMain
                    {
                        isAdmin = false
                    };
                    this.Hide();
                    frm.ShowDialog();
                    
                    isMem = true;

                    if (frm.m < 0)
                        this.Show();
                    else this.Close();
                    break;
                }
                if (i.UserName.Equals(txtUserName.Text) && i.Password.Equals(txtPassword.Text) && i.RoleId == 2)
                {
                    frmMain frm = new frmMain
                    {
                        isAdmin = true
                    };
                    this.Hide();
                    frm.ShowDialog();
                    isMem = true;

                    if (frm.m < 0)
                        this.Show();
                    else this.Close();
                   
                    break;
                }
            }
           
           
            if (isMem == false)
            {
                MessageBox.Show("Wrong user name or pass word, please try again", "Wrong user");
               
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
