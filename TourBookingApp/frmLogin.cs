using DataAccess.Repository;
using System;
using System.Windows.Forms;

namespace TourBookingApp
{
    public partial class frmLogin : Form
    {
        private UserRepository userRepository = new UserRepository();
     
        public frmLogin()
        {
            InitializeComponent();
        }

        public int canLog = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            bool isMem = false;
            var user = userRepository.GetUsers();
            foreach(var i in user)
            {
                if (i.UserName.Equals(txtUserName.Text) && i.Password.Equals(txtPassword.Text)&&i.RoleId==1)
                {
                    Program.canLog=true;
                   
                    frmMain frm = new frmMain
                    {
                        isAdmin = false,
                        currentID = i.UserId,
                        
                    };
                    this.Hide();
                    
                    frm.ShowDialog();
                    
                    isMem = true;

                    if (frm.m < 0)
                        this.Show();
                    else
                    {
                        
                        this.Close();
                    }

                    break;
                }
                if (i.UserName.Equals(txtUserName.Text) && i.Password.Equals(txtPassword.Text) && i.RoleId == 2)
                {
                    Program.canLog = true;


                    frmMain frm = new frmMain
                    {
                        isAdmin = true,
                        currentID = i.UserId,
                    };
                    this.Hide();
                    frm.ShowDialog();
                    isMem = true;

                    if (frm.m < 0)
                        this.Show();
                    else
                    {   
                       
                        this.Close(); 
                    }
                
                    
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
