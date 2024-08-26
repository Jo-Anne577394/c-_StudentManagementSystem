using PRG282_Project.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//PRG2782 Project
//Jo-Anne van der Wath - 577394
//Henry Roux - 577440
//Caitlin Gerber - 577745
//Leonard Vermeer - 577309

namespace PRG282_Project.Presentation_Layer
{
    public partial class RegisterUserForm : Form
    {
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        DataHandler handler = new DataHandler();

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Please make sure to enter a username and password.");
            }
            else
            {
                if (handler.Register(txt_Username.Text, txt_Password.Text))
                {
                    this.Hide();
                    MessageBox.Show($"Registration successful. You are now welcome to login.");
                    LoginForm loginform = new LoginForm();
                    loginform.Show();
                }
            }
        }
    }
}
