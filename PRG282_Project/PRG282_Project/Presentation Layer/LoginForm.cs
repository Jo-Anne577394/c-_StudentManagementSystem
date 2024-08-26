using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Project.Business_Logic_Layer;
using PRG282_Project.Presentation_Layer;

//PRG2782 Project
//Jo-Anne van der Wath - 577394
//Henry Roux - 577440
//Caitlin Gerber - 577745
//Leonard Vermeer - 577309

namespace PRG282_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void Form_Closing_Login(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        DataHandler handler = new DataHandler();

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Please make sure to enter a username and password.");
            }
            else
            {
                if (handler.Login(txt_Username.Text, txt_Password.Text))
                {
                    MainForm frmMain = new MainForm();
                    this.Hide();
                    frmMain.Show();
                    frmMain.FormClosing += Form_Closing_Login;

                    MessageBox.Show($"Login successful. Welcome {txt_Username.Text}.");
                    txt_Username.Text = "";
                    txt_Password.Text = "";
                }
                else
                {
                    MessageBox.Show("Login unsuccessful. Please enter valid credentials.");
                }
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            RegisterUserForm frmRegister = new RegisterUserForm();

            this.Hide();
            frmRegister.Show();
            frmRegister.FormClosing += Form_Closing_Login;
        }
    }
}
