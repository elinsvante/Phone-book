namespace SvantessonElin_Lab3
{
    partial class Form1
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
            this.txtNewContact = new System.Windows.Forms.TextBox();
            this.btnSaveContact = new System.Windows.Forms.Button();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.chkIsSecret = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewContact
            // 
            this.txtNewContact.Location = new System.Drawing.Point(28, 29);
            this.txtNewContact.Name = "txtNewContact";
            this.txtNewContact.Size = new System.Drawing.Size(272, 20);
            this.txtNewContact.TabIndex = 0;
            this.txtNewContact.TextChanged += new System.EventHandler(this.E);
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.Location = new System.Drawing.Point(319, 27);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(75, 23);
            this.btnSaveContact.TabIndex = 1;
            this.btnSaveContact.Text = "Save";
            this.btnSaveContact.UseVisualStyleBackColor = true;
            this.btnSaveContact.Click += new System.EventHandler(this.btnSaveContact_Click);
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(28, 92);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(272, 225);
            this.lstContacts.TabIndex = 2;
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(319, 108);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.TextChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(319, 165);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(319, 227);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Location = new System.Drawing.Point(321, 294);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteContact.TabIndex = 6;
            this.btnDeleteContact.Text = "Delete";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // chkIsSecret
            // 
            this.chkIsSecret.AutoSize = true;
            this.chkIsSecret.Location = new System.Drawing.Point(433, 31);
            this.chkIsSecret.Name = "chkIsSecret";
            this.chkIsSecret.Size = new System.Drawing.Size(101, 17);
            this.chkIsSecret.TabIndex = 7;
            this.chkIsSecret.Text = "Hemligt nummer";
            this.chkIsSecret.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Förnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefonnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Namn,Efternamn,Telefonnummer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kontakter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 347);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkIsSecret);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lstContacts);
            this.Controls.Add(this.btnSaveContact);
            this.Controls.Add(this.txtNewContact);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewContact;
        private System.Windows.Forms.Button btnSaveContact;
        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.CheckBox chkIsSecret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

