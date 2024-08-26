using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//PRG2782 Project
//Jo-Anne van der Wath - 577394
//Henry Roux - 577440
//Caitlin Gerber - 577745
//Leonard Vermeer - 577309

namespace PRG282_Project {
    internal class Student 
    {
        public string StudentID {  get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte[] Image { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Student(string studentID, string name, string surname, byte[] image, DateTime dOB, string gender, string phone, string address)
        {
            StudentID = studentID;
            Name = name;
            Surname = surname;
            Image = image;
            DOB = dOB;
            Gender = gender;
            Phone = phone;
            Address = address;
        }
    }
}
