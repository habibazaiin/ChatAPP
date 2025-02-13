using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAPP
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please enter your user name.");
                txtUserName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Please enter your full name.");
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please enter your phone.");
                txtPhone.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter your password.");
                txtPassword.Focus();
                return;
            }

            string UserName = DB.GetValue($"select UserID from Users where UserName = '{txtUserName.Text}'");

            if (UserName != null)
            {
                MessageBox.Show("The user is already exist.");
                txtUserName.Focus();
                return;
            }

            string Phone = DB.GetValue($"select UserID from Users where Phone = '{txtPhone.Text}'");

            if (Phone != null)
            {
                MessageBox.Show("Sorry, this Phone is already in use.");
                txtPhone.Focus();
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match. Please try again.");
                txtConfirmPassword.Focus();
                return;
            }

            string sql = $"INSERT INTO Users(UserName,FullName,Phone,Password, GroupID) VALUES('{txtUserName.Text}','{txtFullName.Text}','{txtPhone.Text}','{txtPassword.Text}',{cmbGroup.SelectedValue})";

            DB.Execute(sql);

            this.Hide();

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            DB.FillComboBox("select GroupID, GroupName from Groups order by GroupName", cmbGroup);
        }
    }
}
