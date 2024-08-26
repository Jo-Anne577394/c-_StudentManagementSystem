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

//PRG2782 Project
//Jo-Anne van der Wath - 577394
//Henry Roux - 577440
//Caitlin Gerber - 577745
//Leonard Vermeer - 577309

namespace PRG282_Project.Presentation_Layer
{
    public partial class ModuleManagementForm : Form
    {
        public ModuleManagementForm()
        {
            InitializeComponent();
        }

        DatabaseHandler dbHandler = new DatabaseHandler();

        private void ModuleManagementForm_Load(object sender, EventArgs e)
        {
            dgv_ModuleDetails.DataSource = dbHandler.FetchAllData().Tables[1];
        }

        private void dgv_ModuleDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int max = dbHandler.FetchAllData().Tables[1].Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < max)
            {
                DataGridViewRow row = dgv_ModuleDetails.Rows[e.RowIndex];
                txt_ModuleCode.Text = row.Cells["ModuleCode"].Value.ToString();
                txt_ModuleName.Text = row.Cells["ModuleName"].Value.ToString();
                txt_ModuleDescription.Text = row.Cells["Description"].Value.ToString();
                txt_ModuleResources.Text = row.Cells["Links"].Value.ToString();
            }
            else if (e.RowIndex == max)
            {
                ClearAll();
            }
        }

        private void btn_searchModule_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_SearchModule.Text)) {
                DataTable dt = dbHandler.FetchSearchData("Module", txt_SearchModule.Text);
                if (dt.Rows.Count > 0) {
                    dgv_ModuleDetails.DataSource = dt;
                } else {
                    MessageBox.Show("Your search returned no results.");
                }
            } else {
                MessageBox.Show("Cannot search for a module without a module code");
            }
        }

        private void btn_CreateModule_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ModuleCode.Text) && !string.IsNullOrEmpty(txt_ModuleDescription.Text) && !string.IsNullOrEmpty(txt_ModuleName.Text) && !string.IsNullOrEmpty(txt_ModuleResources.Text)) {
                Module module = new Module(txt_ModuleCode.Text, txt_ModuleName.Text, txt_ModuleDescription.Text, txt_ModuleResources.Text);
                dbHandler.CreateRecord("Module", null, module);

                ModuleManagementForm_Load(sender, e);
            } else {
                MessageBox.Show("Fields may not be left empty.");
            }
        }

        private void btn_ReadModule_Click(object sender, EventArgs e)
        {
            ModuleManagementForm_Load(sender, e);
            ClearAll();
        }

        private void ClearAll()
        {
            txt_ModuleCode.Text = null;
            txt_ModuleName.Text = null;
            txt_ModuleDescription.Text = null;
            txt_ModuleResources.Text = null;
        }

        private void btn_UpdateModule_Click(object sender, EventArgs e)
        {
            Module module = new Module(txt_ModuleCode.Text, txt_ModuleName.Text, txt_ModuleDescription.Text, txt_ModuleResources.Text);
            dbHandler.UpdateRecord("Module", null, module);
            ModuleManagementForm_Load(sender, e);
        }

        private void btn_DeleteModule_Click(object sender, EventArgs e)
        {
            dbHandler.DeleteRecord("Module", txt_ModuleCode.Text);
            ModuleManagementForm_Load(sender, e);
        }

        private void btn_StudentDetails_Click(object sender, EventArgs e)
        {
            MainForm frmMain = new MainForm();
            this.Hide();
            frmMain.Show();
        }
    }
}
