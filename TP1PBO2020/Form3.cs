using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2020
{

    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '*';
            txtUsername.Select();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "pbo123")
            {
                MessageBox.Show("Login Success");
                this.Hide();
                
            }
            else if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Fill in the form");
            }
            else
            {
                MessageBox.Show("Login Failed : Wrong Password");
                txtPassword.Focus();
            }
        }
    }
}
