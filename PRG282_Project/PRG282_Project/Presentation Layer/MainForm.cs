using PRG282_Project.Business_Logic_Layer;
using PRG282_Project.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Globalization;

//PRG2782 Project
//Jo-Anne van der Wath - 577394
//Henry Roux - 577440
//Caitlin Gerber - 577745
//Leonard Vermeer - 577309

namespace PRG282_Project.Presentation_Layer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        DatabaseHandler dbHandler = new DatabaseHandler();

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgv_StudentDetails.DataSource = dbHandler.FetchAllData().Tables[0];

            lb_AvailableModules.Items.Clear();
            lb_SelectedModules.Items.Clear();

            foreach (var module in dbHandler.FetchModuleCodes())
            {
                lb_AvailableModules.Items.Add(module);
            }
        }

        public void Form_Closing_Main(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void dgv_StudentDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //stops message dialog appearing after logging in because of errors with images
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_StudentNumber.Text)) {
                DataTable dt = dbHandler.FetchSearchData("Student", txt_StudentSearch.Text);
                if (dt.Rows.Count > 0) {
                    dgv_StudentDetails.DataSource = dt;
                } else {
                    MessageBox.Show("Your search returned no results.");
                }
            } else {
                MessageBox.Show("Cannot search for a student without their student number.");

            }
        }

        private void btn_Create_Click(object sender, EventArgs e) 
        {
            string gender;
            if (rdb_Female.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }

            if (imagePath == null)
            {
                imagePath = "default.png";
            }
            byte[] imageBytes = dbHandler.ImageToBytes(imagePath);

            try {
                if (!string.IsNullOrEmpty(txt_Address.Text) && !string.IsNullOrEmpty(txt_DOB.Text) && !string.IsNullOrEmpty(txt_Phone.Text) && !string.IsNullOrEmpty(txt_StudentFirstName.Text) && !string.IsNullOrEmpty(txt_StudentNumber.Text) && !string.IsNullOrEmpty(txt_StudentSurname.Text)) {
                    Student student = new Student(txt_StudentNumber.Text, txt_StudentFirstName.Text, txt_StudentSurname.Text, (imageBytes), DateTime.Parse(txt_DOB.Text).Date, gender, txt_Phone.Text, txt_Address.Text);
                    dbHandler.CreateRecord("Student", student, null);

                    foreach (var module in lb_SelectedModules.Items) {
                        dbHandler.AddStudentModule(txt_StudentNumber.Text, module.ToString());
                    }

                    dgv_StudentDetails.DataSource = dbHandler.FetchAllData().Tables[0];
                } else {
                    MessageBox.Show("Fields may not be left empty.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            dgv_StudentDetails.DataSource = dbHandler.FetchAllData().Tables[0];
            ClearAll();
        }

        private void ClearAll()
        {
            txt_StudentNumber.Text = null;
            txt_StudentFirstName.Text = null;
            txt_StudentSurname.Text = null;
            pic_StudentImage.Image = null;
            txt_DOB.Text = null;
            rdb_Female.Checked = false;
            rdb_Male.Checked = false;
            txt_Phone.Text = null;
            txt_Address.Text = null;
            lb_AvailableModules.Items.Clear();
            lb_SelectedModules.Items.Clear();

            foreach (var module in dbHandler.FetchModuleCodes())
            {
                lb_AvailableModules.Items.Add(module);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string gender;
            if (rdb_Female.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }

            if (imagePath == null)
            {
                imagePath = "default.png";
            }
            byte[] imageBytes = dbHandler.ImageToBytes(imagePath);

            try {
                Student student = new Student(txt_StudentNumber.Text, txt_StudentFirstName.Text, txt_StudentSurname.Text, (imageBytes), DateTime.Parse(txt_DOB.Text).Date, gender, txt_Phone.Text, txt_Address.Text);
                dbHandler.UpdateRecord("Student", student, null);

                dbHandler.DeleteStudentModule(txt_StudentNumber.Text);
                foreach (var module in lb_SelectedModules.Items) {
                    dbHandler.AddStudentModule(txt_StudentNumber.Text, module.ToString());
                }

                dgv_StudentDetails.DataSource = dbHandler.FetchAllData().Tables[0];
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_StudentNumber.Text)) {
                dbHandler.DeleteStudentModule(txt_StudentNumber.Text);

                dbHandler.DeleteRecord("Student", txt_StudentNumber.Text);
                dgv_StudentDetails.DataSource = dbHandler.FetchAllData().Tables[0];
            } else {
                MessageBox.Show("Cannot delete student without their student number.");
            }
        }

        private void btn_SelectModule_Click(object sender, EventArgs e)
        {
            string selected = lb_AvailableModules.GetItemText(lb_AvailableModules.SelectedItem);
            if (!(selected.Equals("")))
            {
                lb_AvailableModules.Items.Remove(selected);
                lb_SelectedModules.Items.Add(selected);
            }
        }

        private void btn_DeselectModule_Click(object sender, EventArgs e)
        {
            string selected = lb_SelectedModules.GetItemText(lb_SelectedModules.SelectedItem);
            if (!(selected.Equals("")))
            {
                lb_SelectedModules.Items.Remove(selected);
                lb_AvailableModules.Items.Add(selected);
            }
        }

        private void btn_ModuleManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuleManagementForm modulemanagementform = new ModuleManagementForm();
            modulemanagementform.Show();
            modulemanagementform.FormClosing += Form_Closing_Main;
        }

        private void dgv_StudentDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int max = dbHandler.FetchAllData().Tables[0].Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < max)
            {
                DataGridViewRow row = this.dgv_StudentDetails.Rows[e.RowIndex];
                txt_StudentNumber.Text = row.Cells["StudentID"].Value.ToString();
                txt_StudentFirstName.Text = row.Cells["Name"].Value.ToString();
                txt_StudentSurname.Text = row.Cells["Surname"].Value.ToString();

                byte[] imageDataBytes = (byte[])row.Cells["Image"].Value;
                pic_StudentImage.Image = dbHandler.BytesToImage(imageDataBytes);

                DateTime dob = Convert.ToDateTime(row.Cells["DOB"].Value.ToString()).Date;
                txt_DOB.Text = dob.ToString().Substring(0, 10);

                if (row.Cells["GENDER"].Value.ToString() == "Female")
                {
                    rdb_Female.Checked = true;
                }
                else if (row.Cells["GENDER"].Value.ToString() == "Male")
                {
                    rdb_Male.Checked = true;
                }

                txt_Phone.Text = row.Cells["Phone"].Value.ToString();
                txt_Address.Text = row.Cells["Address"].Value.ToString();

                lb_AvailableModules.Items.Clear();
                lb_SelectedModules.Items.Clear();
                List<string> allModules = dbHandler.FetchModuleCodes();
                List<string> studentModules = dbHandler.FetchStudentModule(txt_StudentNumber.Text.Trim());
                foreach (var module in studentModules)
                {
                    lb_SelectedModules.Items.Add(module);
                    allModules.Remove(module);
                }

                foreach (var module in allModules)
                {
                    lb_AvailableModules.Items.Add(module);
                }
            }
            else if (e.RowIndex == max)
            {
                ClearAll();
            }
        }

        string imagePath;

        private void btnImageUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico|All Files|*.*";
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    
                    pic_StudentImage.Image = Image.FromFile(imagePath);
                }
            }
        }
    }
}
