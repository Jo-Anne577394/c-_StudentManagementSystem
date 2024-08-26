namespace PRG282_Project.Presentation_Layer
{
    partial class ModuleManagementForm
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
            this.lbl_ModuleCode = new System.Windows.Forms.Label();
            this.lbl_ModuleName = new System.Windows.Forms.Label();
            this.lbl_ModuleDescription = new System.Windows.Forms.Label();
            this.txt_ModuleCode = new System.Windows.Forms.TextBox();
            this.txt_ModuleName = new System.Windows.Forms.TextBox();
            this.txt_ModuleDescription = new System.Windows.Forms.TextBox();
            this.lbl_OnlineResources = new System.Windows.Forms.Label();
            this.dgv_ModuleDetails = new System.Windows.Forms.DataGridView();
            this.txt_ModuleResources = new System.Windows.Forms.TextBox();
            this.btn_CreateModule = new System.Windows.Forms.Button();
            this.btn_ReadModule = new System.Windows.Forms.Button();
            this.btn_UpdateModule = new System.Windows.Forms.Button();
            this.btn_DeleteModule = new System.Windows.Forms.Button();
            this.gbx_SearchModules = new System.Windows.Forms.GroupBox();
            this.btn_searchModule = new System.Windows.Forms.Button();
            this.txt_SearchModule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_StudentDetails = new System.Windows.Forms.Button();
            this.lbl_ModuleManagement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ModuleDetails)).BeginInit();
            this.gbx_SearchModules.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ModuleCode
            // 
            this.lbl_ModuleCode.AutoSize = true;
            this.lbl_ModuleCode.Location = new System.Drawing.Point(35, 47);
            this.lbl_ModuleCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ModuleCode.Name = "lbl_ModuleCode";
            this.lbl_ModuleCode.Size = new System.Drawing.Size(73, 13);
            this.lbl_ModuleCode.TabIndex = 0;
            this.lbl_ModuleCode.Text = "Module Code:";
            // 
            // lbl_ModuleName
            // 
            this.lbl_ModuleName.AutoSize = true;
            this.lbl_ModuleName.Location = new System.Drawing.Point(32, 73);
            this.lbl_ModuleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ModuleName.Name = "lbl_ModuleName";
            this.lbl_ModuleName.Size = new System.Drawing.Size(76, 13);
            this.lbl_ModuleName.TabIndex = 1;
            this.lbl_ModuleName.Text = "Module Name:";
            // 
            // lbl_ModuleDescription
            // 
            this.lbl_ModuleDescription.AutoSize = true;
            this.lbl_ModuleDescription.Location = new System.Drawing.Point(9, 97);
            this.lbl_ModuleDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ModuleDescription.Name = "lbl_ModuleDescription";
            this.lbl_ModuleDescription.Size = new System.Drawing.Size(101, 13);
            this.lbl_ModuleDescription.TabIndex = 2;
            this.lbl_ModuleDescription.Text = "Module Description:";
            // 
            // txt_ModuleCode
            // 
            this.txt_ModuleCode.Location = new System.Drawing.Point(108, 42);
            this.txt_ModuleCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ModuleCode.Name = "txt_ModuleCode";
            this.txt_ModuleCode.Size = new System.Drawing.Size(120, 20);
            this.txt_ModuleCode.TabIndex = 3;
            // 
            // txt_ModuleName
            // 
            this.txt_ModuleName.Location = new System.Drawing.Point(108, 71);
            this.txt_ModuleName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ModuleName.Name = "txt_ModuleName";
            this.txt_ModuleName.Size = new System.Drawing.Size(120, 20);
            this.txt_ModuleName.TabIndex = 4;
            // 
            // txt_ModuleDescription
            // 
            this.txt_ModuleDescription.Location = new System.Drawing.Point(108, 97);
            this.txt_ModuleDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ModuleDescription.Multiline = true;
            this.txt_ModuleDescription.Name = "txt_ModuleDescription";
            this.txt_ModuleDescription.Size = new System.Drawing.Size(120, 131);
            this.txt_ModuleDescription.TabIndex = 5;
            // 
            // lbl_OnlineResources
            // 
            this.lbl_OnlineResources.AutoSize = true;
            this.lbl_OnlineResources.Location = new System.Drawing.Point(9, 238);
            this.lbl_OnlineResources.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_OnlineResources.Name = "lbl_OnlineResources";
            this.lbl_OnlineResources.Size = new System.Drawing.Size(94, 13);
            this.lbl_OnlineResources.TabIndex = 6;
            this.lbl_OnlineResources.Text = "Online Resources:";
            // 
            // dgv_ModuleDetails
            // 
            this.dgv_ModuleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ModuleDetails.Location = new System.Drawing.Point(237, 42);
            this.dgv_ModuleDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_ModuleDetails.Name = "dgv_ModuleDetails";
            this.dgv_ModuleDetails.RowHeadersWidth = 51;
            this.dgv_ModuleDetails.RowTemplate.Height = 24;
            this.dgv_ModuleDetails.Size = new System.Drawing.Size(526, 281);
            this.dgv_ModuleDetails.TabIndex = 7;
            this.dgv_ModuleDetails.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ModuleDetails_RowEnter);
            // 
            // txt_ModuleResources
            // 
            this.txt_ModuleResources.Location = new System.Drawing.Point(108, 236);
            this.txt_ModuleResources.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ModuleResources.Name = "txt_ModuleResources";
            this.txt_ModuleResources.Size = new System.Drawing.Size(120, 20);
            this.txt_ModuleResources.TabIndex = 8;
            // 
            // btn_CreateModule
            // 
            this.btn_CreateModule.Location = new System.Drawing.Point(237, 328);
            this.btn_CreateModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CreateModule.Name = "btn_CreateModule";
            this.btn_CreateModule.Size = new System.Drawing.Size(102, 33);
            this.btn_CreateModule.TabIndex = 9;
            this.btn_CreateModule.Text = "Create";
            this.btn_CreateModule.UseVisualStyleBackColor = true;
            this.btn_CreateModule.Click += new System.EventHandler(this.btn_CreateModule_Click);
            // 
            // btn_ReadModule
            // 
            this.btn_ReadModule.Location = new System.Drawing.Point(344, 328);
            this.btn_ReadModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ReadModule.Name = "btn_ReadModule";
            this.btn_ReadModule.Size = new System.Drawing.Size(102, 33);
            this.btn_ReadModule.TabIndex = 10;
            this.btn_ReadModule.Text = "All Records";
            this.btn_ReadModule.UseVisualStyleBackColor = true;
            this.btn_ReadModule.Click += new System.EventHandler(this.btn_ReadModule_Click);
            // 
            // btn_UpdateModule
            // 
            this.btn_UpdateModule.Location = new System.Drawing.Point(450, 328);
            this.btn_UpdateModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_UpdateModule.Name = "btn_UpdateModule";
            this.btn_UpdateModule.Size = new System.Drawing.Size(102, 33);
            this.btn_UpdateModule.TabIndex = 11;
            this.btn_UpdateModule.Text = "Update";
            this.btn_UpdateModule.UseVisualStyleBackColor = true;
            this.btn_UpdateModule.Click += new System.EventHandler(this.btn_UpdateModule_Click);
            // 
            // btn_DeleteModule
            // 
            this.btn_DeleteModule.Location = new System.Drawing.Point(556, 328);
            this.btn_DeleteModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DeleteModule.Name = "btn_DeleteModule";
            this.btn_DeleteModule.Size = new System.Drawing.Size(102, 33);
            this.btn_DeleteModule.TabIndex = 12;
            this.btn_DeleteModule.Text = "Delete";
            this.btn_DeleteModule.UseVisualStyleBackColor = true;
            this.btn_DeleteModule.Click += new System.EventHandler(this.btn_DeleteModule_Click);
            // 
            // gbx_SearchModules
            // 
            this.gbx_SearchModules.Controls.Add(this.btn_searchModule);
            this.gbx_SearchModules.Controls.Add(this.txt_SearchModule);
            this.gbx_SearchModules.Controls.Add(this.label1);
            this.gbx_SearchModules.Location = new System.Drawing.Point(11, 258);
            this.gbx_SearchModules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbx_SearchModules.Name = "gbx_SearchModules";
            this.gbx_SearchModules.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbx_SearchModules.Size = new System.Drawing.Size(215, 103);
            this.gbx_SearchModules.TabIndex = 13;
            this.gbx_SearchModules.TabStop = false;
            this.gbx_SearchModules.Text = "Search Modules";
            // 
            // btn_searchModule
            // 
            this.btn_searchModule.Location = new System.Drawing.Point(52, 65);
            this.btn_searchModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_searchModule.Name = "btn_searchModule";
            this.btn_searchModule.Size = new System.Drawing.Size(102, 33);
            this.btn_searchModule.TabIndex = 10;
            this.btn_searchModule.Text = "Search";
            this.btn_searchModule.UseVisualStyleBackColor = true;
            this.btn_searchModule.Click += new System.EventHandler(this.btn_searchModule_Click);
            // 
            // txt_SearchModule
            // 
            this.txt_SearchModule.Location = new System.Drawing.Point(44, 44);
            this.txt_SearchModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_SearchModule.Name = "txt_SearchModule";
            this.txt_SearchModule.Size = new System.Drawing.Size(120, 20);
            this.txt_SearchModule.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Module Code:";
            // 
            // btn_StudentDetails
            // 
            this.btn_StudentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StudentDetails.Location = new System.Drawing.Point(663, 328);
            this.btn_StudentDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_StudentDetails.Name = "btn_StudentDetails";
            this.btn_StudentDetails.Size = new System.Drawing.Size(102, 33);
            this.btn_StudentDetails.TabIndex = 14;
            this.btn_StudentDetails.Text = "Student Details";
            this.btn_StudentDetails.UseVisualStyleBackColor = true;
            this.btn_StudentDetails.Click += new System.EventHandler(this.btn_StudentDetails_Click);
            // 
            // lbl_ModuleManagement
            // 
            this.lbl_ModuleManagement.AutoSize = true;
            this.lbl_ModuleManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ModuleManagement.Location = new System.Drawing.Point(0, 7);
            this.lbl_ModuleManagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ModuleManagement.Name = "lbl_ModuleManagement";
            this.lbl_ModuleManagement.Size = new System.Drawing.Size(852, 26);
            this.lbl_ModuleManagement.TabIndex = 32;
            this.lbl_ModuleManagement.Text = "                                                     Module Management           " +
    "                                          ";
            // 
            // ModuleManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 373);
            this.Controls.Add(this.lbl_ModuleManagement);
            this.Controls.Add(this.btn_StudentDetails);
            this.Controls.Add(this.gbx_SearchModules);
            this.Controls.Add(this.btn_DeleteModule);
            this.Controls.Add(this.btn_UpdateModule);
            this.Controls.Add(this.btn_ReadModule);
            this.Controls.Add(this.btn_CreateModule);
            this.Controls.Add(this.txt_ModuleResources);
            this.Controls.Add(this.dgv_ModuleDetails);
            this.Controls.Add(this.lbl_OnlineResources);
            this.Controls.Add(this.txt_ModuleDescription);
            this.Controls.Add(this.txt_ModuleName);
            this.Controls.Add(this.txt_ModuleCode);
            this.Controls.Add(this.lbl_ModuleDescription);
            this.Controls.Add(this.lbl_ModuleName);
            this.Controls.Add(this.lbl_ModuleCode);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModuleManagementForm";
            this.Text = "Module Management";
            this.Load += new System.EventHandler(this.ModuleManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ModuleDetails)).EndInit();
            this.gbx_SearchModules.ResumeLayout(false);
            this.gbx_SearchModules.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ModuleCode;
        private System.Windows.Forms.Label lbl_ModuleName;
        private System.Windows.Forms.Label lbl_ModuleDescription;
        private System.Windows.Forms.TextBox txt_ModuleCode;
        private System.Windows.Forms.TextBox txt_ModuleName;
        private System.Windows.Forms.TextBox txt_ModuleDescription;
        private System.Windows.Forms.Label lbl_OnlineResources;
        private System.Windows.Forms.DataGridView dgv_ModuleDetails;
        private System.Windows.Forms.TextBox txt_ModuleResources;
        private System.Windows.Forms.Button btn_CreateModule;
        private System.Windows.Forms.Button btn_ReadModule;
        private System.Windows.Forms.Button btn_UpdateModule;
        private System.Windows.Forms.Button btn_DeleteModule;
        private System.Windows.Forms.GroupBox gbx_SearchModules;
        private System.Windows.Forms.Button btn_searchModule;
        private System.Windows.Forms.TextBox txt_SearchModule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_StudentDetails;
        private System.Windows.Forms.Label lbl_ModuleManagement;
    }
}