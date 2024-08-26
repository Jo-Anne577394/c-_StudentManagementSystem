using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//PRG2782 Project
//Jo-Anne van der Wath - 577394
//Henry Roux - 577440
//Caitlin Gerber - 577745
//Leonard Vermeer - 577309

namespace PRG282_Project.Data_Access_Layer {
    internal class FileHandler {

        string path = "RegisteredUsers.txt";

        public bool WriteToFile(string text) 
        {
            if (File.Exists(path))
            {
                File.AppendAllLines(path, new[] { text });
                return true;
            }
            return false;
        }

        public List<string[]> ReadFromFile() 
        {
            List<string[]> users = new List<string[]>();

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string txt;
                    while ((txt = reader.ReadLine()) != null)
                    {
                        string[] parts = txt.Split(',');
                        users.Add(parts);
                    }
                }
            }

            return users;
        }
    }
}
