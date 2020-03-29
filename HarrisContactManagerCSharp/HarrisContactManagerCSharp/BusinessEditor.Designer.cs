namespace HarrisContactManagerCSharp
{
    partial class BusinessEditor
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
            this.dGVBusinessRecords = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFname = new System.Windows.Forms.Label();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddr1 = new System.Windows.Forms.Label();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddr1 = new System.Windows.Forms.TextBox();
            this.lblAddr2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblBusinessTel = new System.Windows.Forms.Label();
            this.tbAddr2 = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbBusinessTel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBusinessRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVBusinessRecords
            // 
            this.dGVBusinessRecords.AllowUserToResizeColumns = false;
            this.dGVBusinessRecords.AllowUserToResizeRows = false;
            this.dGVBusinessRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBusinessRecords.Location = new System.Drawing.Point(12, 158);
            this.dGVBusinessRecords.Name = "dGVBusinessRecords";
            this.dGVBusinessRecords.ReadOnly = true;
            this.dGVBusinessRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVBusinessRecords.Size = new System.Drawing.Size(1041, 280);
            this.dGVBusinessRecords.TabIndex = 0;
            this.dGVBusinessRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBusinessRecords_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(923, 105);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(923, 8);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Enabled = false;
            this.btnSaveNew.Location = new System.Drawing.Point(923, 51);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNew.TabIndex = 3;
            this.btnSaveNew.Text = "Save New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(782, 7);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 52);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Selected";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(640, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 52);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(795, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Selected";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(12, 10);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(57, 13);
            this.lblFname.TabIndex = 7;
            this.lblFname.Text = "First Name";
            // 
            // tbFname
            // 
            this.tbFname.Enabled = false;
            this.tbFname.Location = new System.Drawing.Point(84, 10);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(100, 20);
            this.tbFname.TabIndex = 8;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(9, 46);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(58, 13);
            this.lblLname.TabIndex = 9;
            this.lblLname.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 88);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblAddr1
            // 
            this.lblAddr1.AutoSize = true;
            this.lblAddr1.Location = new System.Drawing.Point(12, 126);
            this.lblAddr1.Name = "lblAddr1";
            this.lblAddr1.Size = new System.Drawing.Size(76, 13);
            this.lblAddr1.TabIndex = 11;
            this.lblAddr1.Text = "Address line 1 ";
            // 
            // tbLname
            // 
            this.tbLname.Enabled = false;
            this.tbLname.Location = new System.Drawing.Point(84, 46);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(100, 20);
            this.tbLname.TabIndex = 12;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(84, 85);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 13;
            // 
            // tbAddr1
            // 
            this.tbAddr1.Enabled = false;
            this.tbAddr1.Location = new System.Drawing.Point(84, 123);
            this.tbAddr1.Name = "tbAddr1";
            this.tbAddr1.Size = new System.Drawing.Size(100, 20);
            this.tbAddr1.TabIndex = 14;
            // 
            // lblAddr2
            // 
            this.lblAddr2.AutoSize = true;
            this.lblAddr2.Location = new System.Drawing.Point(270, 5);
            this.lblAddr2.Name = "lblAddr2";
            this.lblAddr2.Size = new System.Drawing.Size(76, 13);
            this.lblAddr2.TabIndex = 15;
            this.lblAddr2.Text = "Address line 2 ";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(270, 43);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "City";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(270, 81);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblPostcode.TabIndex = 17;
            this.lblPostcode.Text = "Postcode";
            this.lblPostcode.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblBusinessTel
            // 
            this.lblBusinessTel.AutoSize = true;
            this.lblBusinessTel.Location = new System.Drawing.Point(270, 126);
            this.lblBusinessTel.Name = "lblBusinessTel";
            this.lblBusinessTel.Size = new System.Drawing.Size(84, 13);
            this.lblBusinessTel.TabIndex = 18;
            this.lblBusinessTel.Text = "BusinessTel. No";
            // 
            // tbAddr2
            // 
            this.tbAddr2.Enabled = false;
            this.tbAddr2.Location = new System.Drawing.Point(360, 2);
            this.tbAddr2.Name = "tbAddr2";
            this.tbAddr2.Size = new System.Drawing.Size(100, 20);
            this.tbAddr2.TabIndex = 19;
            // 
            // tbCity
            // 
            this.tbCity.Enabled = false;
            this.tbCity.Location = new System.Drawing.Point(360, 43);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 20;
            // 
            // tbPostcode
            // 
            this.tbPostcode.Enabled = false;
            this.tbPostcode.Location = new System.Drawing.Point(360, 78);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(100, 20);
            this.tbPostcode.TabIndex = 21;
            // 
            // tbBusinessTel
            // 
            this.tbBusinessTel.Enabled = false;
            this.tbBusinessTel.Location = new System.Drawing.Point(360, 119);
            this.tbBusinessTel.Name = "tbBusinessTel";
            this.tbBusinessTel.Size = new System.Drawing.Size(100, 20);
            this.tbBusinessTel.TabIndex = 22;
            // 
            // BusinessEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.tbBusinessTel);
            this.Controls.Add(this.tbPostcode);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddr2);
            this.Controls.Add(this.lblBusinessTel);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddr2);
            this.Controls.Add(this.tbAddr1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.lblAddr1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dGVBusinessRecords);
            this.Name = "BusinessEditor";
            this.Text = "BusinessEditor";
            this.Load += new System.EventHandler(this.BusinessEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBusinessRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVBusinessRecords;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddr1;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddr1;
        private System.Windows.Forms.Label lblAddr2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblBusinessTel;
        private System.Windows.Forms.TextBox tbAddr2;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbBusinessTel;
    }
}