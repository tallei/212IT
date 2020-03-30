namespace HarrisContactManagerCSharp
{
    partial class ContactMenu
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
            this.btn_personal = new System.Windows.Forms.Button();
            this.btn_business = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_personal
            // 
            this.btn_personal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_personal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_personal.Location = new System.Drawing.Point(704, 28);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Size = new System.Drawing.Size(324, 55);
            this.btn_personal.TabIndex = 0;
            this.btn_personal.Text = "Personal Contacts";
            this.btn_personal.UseVisualStyleBackColor = false;
            this.btn_personal.Click += new System.EventHandler(this.btn_personal_Click);
            // 
            // btn_business
            // 
            this.btn_business.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_business.Location = new System.Drawing.Point(704, 115);
            this.btn_business.Name = "btn_business";
            this.btn_business.Size = new System.Drawing.Size(324, 58);
            this.btn_business.TabIndex = 1;
            this.btn_business.Text = "Business Contacts";
            this.btn_business.UseVisualStyleBackColor = false;
            this.btn_business.Click += new System.EventHandler(this.btn_business_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Black;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblCompanyName.Location = new System.Drawing.Point(342, 28);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(167, 13);
            this.lblCompanyName.TabIndex = 3;
            this.lblCompanyName.Text = "Harris & Sons Consulting LTD";
            // 
            // ContactMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::HarrisContactManagerCSharp.Properties.Resources.Contact_us_1600x602_jpg_imgix_banner;
            this.ClientSize = new System.Drawing.Size(1050, 469);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_business);
            this.Controls.Add(this.btn_personal);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "ContactMenu";
            this.Text = "Harris Contact Manager";
            this.Load += new System.EventHandler(this.ContactMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_personal;
        private System.Windows.Forms.Button btn_business;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompanyName;
    }
}

