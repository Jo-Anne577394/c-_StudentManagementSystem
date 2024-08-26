using PRG282_Project.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//PRG2782 Project
//Jo-Anne van der Wath - 577394
//Henry Roux - 577440
//Caitlin Gerber - 577745
//Leonard Vermeer - 577309

namespace PRG282_Project.Business_Logic_Layer 
{
    internal class DataHandler
    {
        FileHandler fileHandler = new FileHandler();

        public bool Login(string username, string password)
        {
            List<string[]> users =  fileHandler.ReadFromFile();

            foreach (var user in users)
            {
                if (user[0].Trim() == username && user[1].Trim() == password)
                {
                    return true;
                }
            }

            return false;
        }

        public bool Register(string username, string password)
        {
            List<string[]> users = fileHandler.ReadFromFile();

            if (ValidatePassword(password))
            {
                foreach (var user in users)
                {
                    if (user[0].Trim() != username)
                    {
                        string line = $"\n{username.Trim()}, {password.Trim()}";
                        return fileHandler.WriteToFile(line);
                    }
                    else
                    {
                        MessageBox.Show("This username already exists.");
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please ensure that your password contains at least one capital letter and one number.");
            }
            

            return false;
        }

        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, "^(?=.*[A-Z])(?=.*[0-9])");
        }
    }
}
