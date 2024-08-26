namespace PRG282_Project.Presentation_Layer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_StudentDetails = new System.Windows.Forms.DataGridView();
            this.lbl_StudNumber = new System.Windows.Forms.Label();
            this.txt_StudentNumber = new System.Windows.Forms.TextBox();
            this.lbl_StudFirstName = new System.Windows.Forms.Label();
            this.txt_StudentFirstName = new System.Windows.Forms.TextBox();
            this.lbl_StudImage = new System.Windows.Forms.Label();
            this.pic_StudentImage = new System.Windows.Forms.PictureBox();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.txt_DOB = new System.Windows.Forms.TextBox();
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.gbx_Gender = new System.Windows.Forms.GroupBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_ModuleCodes = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lb_AvailableModules = new System.Windows.Forms.ListBox();
            this.lb_SelectedModules = new System.Windows.Forms.ListBox();
            this.lbl_AvailableModules = new System.Windows.Forms.Label();
            this.lbl_SelectedModule = new System.Windows.Forms.Label();
            this.btn_SelectModule = new System.Windows.Forms.Button();
            this.btn_DeselectModule = new System.Windows.Forms.Button();
            this.btn_ModuleManagement = new System.Windows.Forms.Button();
            this.gbx_SearchStudent = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_StudentSearch = new System.Windows.Forms.TextBox();
            this.lbl_StudNumSearch = new System.Windows.Forms.Label();
            this.lbl_StudentInfo = new System.Windows.Forms.Label();
            this.lbl_StudSurname = new System.Windows.Forms.Label();
            this.txt_StudentSurname = new System.Windows.Forms.TextBox();
            this.btnImageUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_StudentImage)).BeginInit();
            this.gbx_Gender.SuspendLayout();
            this.gbx_SearchStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_StudentDetails
            // 
            this.dgv_StudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StudentDetails.Location = new System.Drawing.Point(285, 52);
            this.dgv_StudentDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_StudentDetails.Name = "dgv_StudentDetails";
            this.dgv_StudentDetails.RowHeadersWidth = 51;
            this.dgv_StudentDetails.RowTemplate.Height = 24;
            this.dgv_StudentDetails.Size = new System.Drawing.Size(587, 402);
            this.dgv_StudentDetails.TabIndex = 0;
            this.dgv_StudentDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StudentDetails_CellClick);
            this.dgv_StudentDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_StudentDetails_DataError);
            // 
            // lbl_StudNumber
            // 
            this.lbl_StudNumber.AutoSize = true;
            this.lbl_StudNumber.Location = new System.Drawing.Point(12, 55);
            this.lbl_StudNumber.Name = "lbl_StudNumber";
            this.lbl_StudNumber.Size = new System.Drawing.Size(106, 16);
            this.lbl_StudNumber.TabIndex = 1;
            this.lbl_StudNumber.Text = "Student Number:";
            // 
            // txt_StudentNumber
            // 
            this.txt_StudentNumber.Location = new System.Drawing.Point(121, 52);
            this.txt_StudentNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentNumber.Name = "txt_StudentNumber";
            this.txt_StudentNumber.Size = new System.Drawing.Size(159, 22);
            this.txt_StudentNumber.TabIndex = 2;
            // 
            // lbl_StudFirstName
            // 
            this.lbl_StudFirstName.AutoSize = true;
            this.lbl_StudFirstName.Location = new System.Drawing.Point(40, 82);
            this.lbl_StudFirstName.Name = "lbl_StudFirstName";
            this.lbl_StudFirstName.Size = new System.Drawing.Size(75, 16);
            this.lbl_StudFirstName.TabIndex = 3;
            this.lbl_StudFirstName.Text = "First Name:";
            // 
            // txt_StudentFirstName
            // 
            this.txt_StudentFirstName.Location = new System.Drawing.Point(121, 80);
            this.txt_StudentFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentFirstName.Name = "txt_StudentFirstName";
            this.txt_StudentFirstName.Size = new System.Drawing.Size(159, 22);
            this.txt_StudentFirstName.TabIndex = 4;
            // 
            // lbl_StudImage
            // 
            this.lbl_StudImage.AutoSize = true;
            this.lbl_StudImage.Location = new System.Drawing.Point(67, 142);
            this.lbl_StudImage.Name = "lbl_StudImage";
            this.lbl_StudImage.Size = new System.Drawing.Size(48, 16);
            this.lbl_StudImage.TabIndex = 5;
            this.lbl_StudImage.Text = "Image:";
            // 
            // pic_StudentImage
            // 
            this.pic_StudentImage.Location = new System.Drawing.Point(121, 142);
            this.pic_StudentImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_StudentImage.Name = "pic_StudentImage";
            this.pic_StudentImage.Size = new System.Drawing.Size(157, 89);
            this.pic_StudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_StudentImage.TabIndex = 6;
            this.pic_StudentImage.TabStop = false;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Location = new System.Drawing.Point(36, 246);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(82, 16);
            this.lbl_DOB.TabIndex = 7;
            this.lbl_DOB.Text = "Date of Birth:";
            // 
            // txt_DOB
            // 
            this.txt_DOB.Location = new System.Drawing.Point(120, 240);
            this.txt_DOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DOB.Name = "txt_DOB";
            this.txt_DOB.Size = new System.Drawing.Size(159, 22);
            this.txt_DOB.TabIndex = 8;
            // 
            // rdb_Female
            // 
            this.rdb_Female.AutoSize = true;
            this.rdb_Female.Location = new System.Drawing.Point(60, 21);
            this.rdb_Female.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_Female.Name = "rdb_Female";
            this.rdb_Female.Size = new System.Drawing.Size(74, 20);
            this.rdb_Female.TabIndex = 10;
            this.rdb_Female.TabStop = true;
            this.rdb_Female.Text = "Female";
            this.rdb_Female.UseVisualStyleBackColor = true;
            // 
            // rdb_Male
            // 
            this.rdb_Male.AutoSize = true;
            this.rdb_Male.Location = new System.Drawing.Point(155, 21);
            this.rdb_Male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_Male.Name = "rdb_Male";
            this.rdb_Male.Size = new System.Drawing.Size(58, 20);
            this.rdb_Male.TabIndex = 11;
            this.rdb_Male.TabStop = true;
            this.rdb_Male.Text = "Male";
            this.rdb_Male.UseVisualStyleBackColor = true;
            // 
            // gbx_Gender
            // 
            this.gbx_Gender.Controls.Add(this.rdb_Female);
            this.gbx_Gender.Controls.Add(this.rdb_Male);
            this.gbx_Gender.Location = new System.Drawing.Point(60, 268);
            this.gbx_Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_Gender.Name = "gbx_Gender";
            this.gbx_Gender.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_Gender.Size = new System.Drawing.Size(219, 50);
            this.gbx_Gender.TabIndex = 12;
            this.gbx_Gender.TabStop = false;
            this.gbx_Gender.Text = "Gender";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(57, 325);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(49, 16);
            this.lbl_Phone.TabIndex = 13;
            this.lbl_Phone.Text = "Phone:";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(120, 322);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(159, 22);
            this.txt_Phone.TabIndex = 14;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(57, 356);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(61, 16);
            this.lbl_Address.TabIndex = 15;
            this.lbl_Address.Text = "Address:";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(120, 350);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(159, 61);
            this.txt_Address.TabIndex = 16;
            // 
            // lbl_ModuleCodes
            // 
            this.lbl_ModuleCodes.AutoSize = true;
            this.lbl_ModuleCodes.Location = new System.Drawing.Point(879, 55);
            this.lbl_ModuleCodes.Name = "lbl_ModuleCodes";
            this.lbl_ModuleCodes.Size = new System.Drawing.Size(98, 16);
            this.lbl_ModuleCodes.TabIndex = 17;
            this.lbl_ModuleCodes.Text = "Module Codes:";
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(285, 463);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(136, 44);
            this.btn_Create.TabIndex = 19;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(436, 463);
            this.btn_Read.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(136, 44);
            this.btn_Read.TabIndex = 20;
            this.btn_Read.Text = "All Records";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(736, 462);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(136, 44);
            this.btn_Delete.TabIndex = 21;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(585, 463);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(136, 44);
            this.btn_Update.TabIndex = 22;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lb_AvailableModules
            // 
            this.lb_AvailableModules.FormattingEnabled = true;
            this.lb_AvailableModules.ItemHeight = 16;
            this.lb_AvailableModules.Location = new System.Drawing.Point(883, 101);
            this.lb_AvailableModules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_AvailableModules.Name = "lb_AvailableModules";
            this.lb_AvailableModules.Size = new System.Drawing.Size(143, 356);
            this.lb_AvailableModules.TabIndex = 23;
            // 
            // lb_SelectedModules
            // 
            this.lb_SelectedModules.FormattingEnabled = true;
            this.lb_SelectedModules.ItemHeight = 16;
            this.lb_SelectedModules.Location = new System.Drawing.Point(1089, 98);
            this.lb_SelectedModules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_SelectedModules.Name = "lb_SelectedModules";
            this.lb_SelectedModules.Size = new System.Drawing.Size(145, 356);
            this.lb_SelectedModules.TabIndex = 24;
            // 
            // lbl_AvailableModules
            // 
            this.lbl_AvailableModules.AutoSize = true;
            this.lbl_AvailableModules.Location = new System.Drawing.Point(879, 80);
            this.lbl_AvailableModules.Name = "lbl_AvailableModules";
            this.lbl_AvailableModules.Size = new System.Drawing.Size(119, 16);
            this.lbl_AvailableModules.TabIndex = 25;
            this.lbl_AvailableModules.Text = "Available Modules";
            // 
            // lbl_SelectedModule
            // 
            this.lbl_SelectedModule.AutoSize = true;
            this.lbl_SelectedModule.Location = new System.Drawing.Point(1089, 80);
            this.lbl_SelectedModule.Name = "lbl_SelectedModule";
            this.lbl_SelectedModule.Size = new System.Drawing.Size(116, 16);
            this.lbl_SelectedModule.TabIndex = 26;
            this.lbl_SelectedModule.Text = "Selected Modules";
            // 
            // btn_SelectModule
            // 
            this.btn_SelectModule.Location = new System.Drawing.Point(1029, 196);
            this.btn_SelectModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SelectModule.Name = "btn_SelectModule";
            this.btn_SelectModule.Size = new System.Drawing.Size(56, 43);
            this.btn_SelectModule.TabIndex = 27;
            this.btn_SelectModule.Text = ">>";
            this.btn_SelectModule.UseVisualStyleBackColor = true;
            this.btn_SelectModule.Click += new System.EventHandler(this.btn_SelectModule_Click);
            // 
            // btn_DeselectModule
            // 
            this.btn_DeselectModule.Location = new System.Drawing.Point(1029, 245);
            this.btn_DeselectModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DeselectModule.Name = "btn_DeselectModule";
            this.btn_DeselectModule.Size = new System.Drawing.Size(56, 44);
            this.btn_DeselectModule.TabIndex = 28;
            this.btn_DeselectModule.Text = "<<";
            this.btn_DeselectModule.UseVisualStyleBackColor = true;
            this.btn_DeselectModule.Click += new System.EventHandler(this.btn_DeselectModule_Click);
            // 
            // btn_ModuleManagement
            // 
            this.btn_ModuleManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModuleManagement.Location = new System.Drawing.Point(879, 462);
            this.btn_ModuleManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ModuleManagement.Name = "btn_ModuleManagement";
            this.btn_ModuleManagement.Size = new System.Drawing.Size(357, 44);
            this.btn_ModuleManagement.TabIndex = 29;
            this.btn_ModuleManagement.Text = "Module Management";
            this.btn_ModuleManagement.UseVisualStyleBackColor = true;
            this.btn_ModuleManagement.Click += new System.EventHandler(this.btn_ModuleManagement_Click);
            // 
            // gbx_SearchStudent
            // 
            this.gbx_SearchStudent.Controls.Add(this.btn_Search);
            this.gbx_SearchStudent.Controls.Add(this.txt_StudentSearch);
            this.gbx_SearchStudent.Controls.Add(this.lbl_StudNumSearch);
            this.gbx_SearchStudent.Location = new System.Drawing.Point(25, 417);
            this.gbx_SearchStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_SearchStudent.Name = "gbx_SearchStudent";
            this.gbx_SearchStudent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_SearchStudent.Size = new System.Drawing.Size(253, 89);
            this.gbx_SearchStudent.TabIndex = 30;
            this.gbx_SearchStudent.TabStop = false;
            this.gbx_SearchStudent.Text = "Search Students";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(13, 48);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(235, 34);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_StudentSearch
            // 
            this.txt_StudentSearch.Location = new System.Drawing.Point(117, 20);
            this.txt_StudentSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentSearch.Name = "txt_StudentSearch";
            this.txt_StudentSearch.Size = new System.Drawing.Size(129, 22);
            this.txt_StudentSearch.TabIndex = 4;
            // 
            // lbl_StudNumSearch
            // 
            this.lbl_StudNumSearch.AutoSize = true;
            this.lbl_StudNumSearch.Location = new System.Drawing.Point(5, 23);
            this.lbl_StudNumSearch.Name = "lbl_StudNumSearch";
            this.lbl_StudNumSearch.Size = new System.Drawing.Size(106, 16);
            this.lbl_StudNumSearch.TabIndex = 3;
            this.lbl_StudNumSearch.Text = "Student Number:";
            // 
            // lbl_StudentInfo
            // 
            this.lbl_StudentInfo.AutoSize = true;
            this.lbl_StudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentInfo.Location = new System.Drawing.Point(9, 9);
            this.lbl_StudentInfo.Name = "lbl_StudentInfo";
            this.lbl_StudentInfo.Size = new System.Drawing.Size(1235, 32);
            this.lbl_StudentInfo.TabIndex = 31;
            this.lbl_StudentInfo.Text = "                                                                  Student Informa" +
    "tion                                                                         ";
            // 
            // lbl_StudSurname
            // 
            this.lbl_StudSurname.AutoSize = true;
            this.lbl_StudSurname.Location = new System.Drawing.Point(51, 114);
            this.lbl_StudSurname.Name = "lbl_StudSurname";
            this.lbl_StudSurname.Size = new System.Drawing.Size(64, 16);
            this.lbl_StudSurname.TabIndex = 32;
            this.lbl_StudSurname.Text = "Surname:";
            // 
            // txt_StudentSurname
            // 
            this.txt_StudentSurname.Location = new System.Drawing.Point(120, 108);
            this.txt_StudentSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentSurname.Name = "txt_StudentSurname";
            this.txt_StudentSurname.Size = new System.Drawing.Size(159, 22);
            this.txt_StudentSurname.TabIndex = 33;
            // 
            // btnImageUpload
            // 
            this.btnImageUpload.Location = new System.Drawing.Point(12, 161);
            this.btnImageUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnImageUpload.Name = "btnImageUpload";
            this.btnImageUpload.Size = new System.Drawing.Size(100, 69);
            this.btnImageUpload.TabIndex = 34;
            this.btnImageUpload.Text = "Upload";
            this.btnImageUpload.UseVisualStyleBackColor = true;
            this.btnImageUpload.Click += new System.EventHandler(this.btnImageUpload_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 514);
            this.Controls.Add(this.btnImageUpload);
            this.Controls.Add(this.txt_StudentSurname);
            this.Controls.Add(this.lbl_StudSurname);
            this.Controls.Add(this.lbl_StudentInfo);
            this.Controls.Add(this.gbx_SearchStudent);
            this.Controls.Add(this.btn_ModuleManagement);
            this.Controls.Add(this.btn_DeselectModule);
            this.Controls.Add(this.btn_SelectModule);
            this.Controls.Add(this.lbl_SelectedModule);
            this.Controls.Add(this.lbl_AvailableModules);
            this.Controls.Add(this.lb_SelectedModules);
            this.Controls.Add(this.lb_AvailableModules);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.lbl_ModuleCodes);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.gbx_Gender);
            this.Controls.Add(this.txt_DOB);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.pic_StudentImage);
            this.Controls.Add(this.lbl_StudImage);
            this.Controls.Add(this.txt_StudentFirstName);
            this.Controls.Add(this.lbl_StudFirstName);
            this.Controls.Add(this.txt_StudentNumber);
            this.Controls.Add(this.lbl_StudNumber);
            this.Controls.Add(this.dgv_StudentDetails);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Student Infomation";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_StudentImage)).EndInit();
            this.gbx_Gender.ResumeLayout(false);
            this.gbx_Gender.PerformLayout();
            this.gbx_SearchStudent.ResumeLayout(false);
            this.gbx_SearchStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_StudentDetails;
        private System.Windows.Forms.Label lbl_StudNumber;
        private System.Windows.Forms.TextBox txt_StudentNumber;
        private System.Windows.Forms.Label lbl_StudFirstName;
        private System.Windows.Forms.TextBox txt_StudentFirstName;
        private System.Windows.Forms.Label lbl_StudImage;
        private System.Windows.Forms.PictureBox pic_StudentImage;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.TextBox txt_DOB;
        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.GroupBox gbx_Gender;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_ModuleCodes;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ListBox lb_AvailableModules;
        private System.Windows.Forms.ListBox lb_SelectedModules;
        private System.Windows.Forms.Label lbl_AvailableModules;
        private System.Windows.Forms.Label lbl_SelectedModule;
        private System.Windows.Forms.Button btn_SelectModule;
        private System.Windows.Forms.Button btn_DeselectModule;
        private System.Windows.Forms.Button btn_ModuleManagement;
        private System.Windows.Forms.GroupBox gbx_SearchStudent;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_StudentSearch;
        private System.Windows.Forms.Label lbl_StudNumSearch;
        private System.Windows.Forms.Label lbl_StudentInfo;
        private System.Windows.Forms.Label lbl_StudSurname;
        private System.Windows.Forms.TextBox txt_StudentSurname;
        private System.Windows.Forms.Button btnImageUpload;
    }
}