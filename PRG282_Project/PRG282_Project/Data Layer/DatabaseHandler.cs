using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Web;

//PRG2782 Project
//Jo-Anne van der Wath - 577394
//Henry Roux - 577440
//Caitlin Gerber - 577745
//Leonard Vermeer - 577309

namespace PRG282_Project.Data_Layer
{
    internal class DatabaseHandler
    {
        string connect = "Server = .; Initial Catalog = BC_Students; Integrated Security = SSPI;";

        public DataSet FetchAllData()
        {
            SqlConnection conn = new SqlConnection(connect);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("spFetchAllData", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return null;
        }


        public List<string> FetchModuleCodes()
        {
            SqlConnection conn = new SqlConnection(connect);
            List<string> modules = new List<string>();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("spFetchModuleCodes", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    modules.Add(row["ModuleCode"].ToString());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return modules;
        }

        public DataTable FetchSearchData(string dbTable, string searchAttribute)
        {
            SqlConnection conn = new SqlConnection(connect);
            DataTable table = new DataTable();

            try
            {
                if (dbTable == "Student")
                {
                    SqlCommand cmd = new SqlCommand("spSearchStudent", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", searchAttribute);
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                }
                else if (dbTable == "Module")
                {
                    SqlCommand cmd = new SqlCommand("spSearchModule", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ModuleCode", searchAttribute);
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return table;
        }

        public void CreateRecord(string dbTable, Student student, Module module)
        {
            SqlConnection conn = new SqlConnection(connect);

            try
            {
                SqlCommand cmd;
                if (dbTable == "Student")
                {
                    cmd = new SqlCommand("spAddStudent", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@Surname", student.Surname);
                    cmd.Parameters.AddWithValue("@Image", student.Image);
                    cmd.Parameters.AddWithValue("@DOB", student.DOB.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Gender", student.Gender);
                    cmd.Parameters.AddWithValue("@Phone", student.Phone);
                    cmd.Parameters.AddWithValue("@Address", student.Address);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Record created for {student.Name} {student.Surname}.");
                }
                else if (dbTable == "Module")
                {
                    cmd = new SqlCommand("spAddModule", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ModuleCode", module.ModuleCode);
                    cmd.Parameters.AddWithValue("@ModuleName", module.ModuleName);
                    cmd.Parameters.AddWithValue("@Description", module.Description);
                    cmd.Parameters.AddWithValue("@Links", module.Links);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Record created for {module.ModuleCode}.");
                }
            }
            catch (Exception ex) { MessageBox.Show("Could not create the record. " + ex.Message); }
            finally { conn.Close(); }
        }

        public void DeleteRecord(string dbTable, string deleteAttribute)
        {
            SqlConnection conn = new SqlConnection(connect);

            try
            {
                SqlCommand cmd;
                if (dbTable == "Student")
                {
                    cmd = new SqlCommand("spDeleteStudent", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", deleteAttribute);

                    DeleteStudentModule(deleteAttribute);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Record deleted for {deleteAttribute}.");
                }
                else if (dbTable == "Module")
                {
                    cmd = new SqlCommand("spDeleteModule", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ModuleCode", deleteAttribute);

                    DeleteModule(deleteAttribute);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Record updated for {deleteAttribute}.");
                }
            }
            catch (Exception ex) { MessageBox.Show("Could not delete the record. " + ex.Message); }
            finally { conn.Close(); }
        }

        public void UpdateRecord(string dbTable, Student student, Module module)
        {
            SqlConnection conn = new SqlConnection(connect);

            try
            {
                SqlCommand cmd;
                if (dbTable == "Student")
                {
                    cmd = new SqlCommand("spUpdateStudent", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@Surname", student.Surname);
                    cmd.Parameters.AddWithValue("@Image", student.Image);
                    cmd.Parameters.AddWithValue("@DOB", student.DOB.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Gender", student.Gender);
                    cmd.Parameters.AddWithValue("@Phone", student.Phone);
                    cmd.Parameters.AddWithValue("@Address", student.Address);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Record updated for {student.Name} {student.Surname}.");
                }
                else if (dbTable == "Module")
                {
                    cmd = new SqlCommand("spUpdateModule", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ModuleCode", module.ModuleCode);
                    cmd.Parameters.AddWithValue("@ModuleName", module.ModuleName);
                    cmd.Parameters.AddWithValue("@Description", module.Description);
                    cmd.Parameters.AddWithValue("@Links", module.Links);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Record updated for {module.ModuleCode}.");
                }
            }
            catch (Exception e) { MessageBox.Show("Could not update the record." + e.Message); }
            finally { conn.Close(); }
        }

        public List<string> FetchStudentModule(string studentID)
        {
            SqlConnection conn = new SqlConnection(connect);
            DataTable table = new DataTable();
            List<string> modules = new List<string>();

            try
            {
                SqlCommand cmd = new SqlCommand("spFetchStudentModules", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    modules.Add(row["ModuleCode"].ToString());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return modules;
        }

        public void DeleteStudentModule(string studentID)
        {
            SqlConnection conn = new SqlConnection(connect);

            try
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudentFromStudentModule", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentID", studentID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show("Could not delete the record. " + ex.Message); }
            finally { conn.Close(); }
        }

        public void DeleteModule(string moduleCode)
        {
            SqlConnection conn = new SqlConnection(connect);

            try
            {
                SqlCommand cmd = new SqlCommand("spDeleteModuleFromStudentModule", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ModuleCode", moduleCode);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show("Could not delete the record. " + ex.Message); }
            finally { conn.Close(); }
        }

        public void AddStudentModule(string studentID, string module)
        {
            SqlConnection conn = new SqlConnection(connect);

            try
            {
                SqlCommand cmd = new SqlCommand("spAddStudentModule", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.Parameters.AddWithValue("@ModuleCode", module);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { MessageBox.Show("Could not update the record." + e.Message); }
            finally { conn.Close(); }
        }


        //////////////////////////////////////
        ///
       public Image BytesToImage(byte[] bytesArr)
       {

            try
            {
                if (bytesArr == null || bytesArr.Length == 0)
                {
                    return null; 
                }

                using (MemoryStream ms = new MemoryStream(bytesArr))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error converting byte array to image: {ex.Message}");
                return null;
            }
       }     
        
        public byte[] ImageToBytes(string imagePath)
        {
            try
            {
                return File.ReadAllBytes(imagePath);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error converting image to byte array: {ex.Message}");

                return null;
            }
        }
    }
}
