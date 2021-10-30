using DataAccess.Repository;
using System;
using System.Windows.Forms;

namespace TourBookingApp
{
    public partial class frmLogin : Form
    {
        private UserRepository userRepository = new UserRepository();
        public static bool canLog = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            bool isMem = false;
            var user = userRepository.GetUsers();
            foreach(var i in user)
            {
                if (i.UserName.Equals(txtUserName.Text) && i.Password.Equals(txtPassword.Text)&&i.RoleId==1)
                {
                    canLog = true;
                   
                    frmMain frm = new frmMain
                    {
                        isAdmin = false,
                        currentID = i.UserId,
                        
                    };
                    this.Hide();
                    
                    frm.ShowDialog();
                    
                    isMem = true;
                    break;
                }
                if (i.UserName.Equals(txtUserName.Text) && i.Password.Equals(txtPassword.Text) && i.RoleId == 2)
                {
                    canLog = true;


                    frmMain frm = new frmMain
                    {
                        isAdmin = true,
                        currentID = i.UserId,
                    };
                    this.Hide();
                    isMem = true;
                    frm.ShowDialog();
                    break;
                }
            }
           
           
            if (isMem == false)
            {
                var mss=MessageBox.Show("Wrong user name or pass word, please try again", "Wrong user", MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (mss == DialogResult.OK)
                {
                    this.DialogResult=DialogResult.None;
                    this.Show();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
