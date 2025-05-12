using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orionRameyC969
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //private class for Language SetLanguage();
        }

        //private void SetLanguage()

        private void loginUsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Retrieve user input
            string username = loginUsernameTextBox.Text.Trim();
            string password = loginPasswordTextBox.Text.Trim();

            // Check if any fields are empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(("EmptyFieldsError"),
                    ("ErrorTitle"));
                return;
            }
            try
            {
                // Connect to the database
                using (var conn = 
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
