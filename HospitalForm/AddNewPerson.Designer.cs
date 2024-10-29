namespace HospitalForm
{
    partial class AddNewPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNameAdmin = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.txtBoxIllness = new System.Windows.Forms.TextBox();
            this.comboBoxSpecialty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabNewPerson = new System.Windows.Forms.TabControl();
            this.tabDoctors = new System.Windows.Forms.TabPage();
            this.tabPatient = new System.Windows.Forms.TabPage();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.txtBoxDoctor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxNamePatient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericAgePatient = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericAgeDoctor = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericAgeAdmin = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.butCancelNewPerson = new System.Windows.Forms.Button();
            this.butSubmitNewPerson = new System.Windows.Forms.Button();
            this.tabNewPerson.SuspendLayout();
            this.tabDoctors.SuspendLayout();
            this.tabPatient.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgePatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Illness:";
            // 
            // txtBoxNameAdmin
            // 
            this.txtBoxNameAdmin.Location = new System.Drawing.Point(62, 20);
            this.txtBoxNameAdmin.Name = "txtBoxNameAdmin";
            this.txtBoxNameAdmin.Size = new System.Drawing.Size(108, 22);
            this.txtBoxNameAdmin.TabIndex = 4;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(62, 79);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(108, 22);
            this.txtBoxPhone.TabIndex = 6;
            // 
            // txtBoxIllness
            // 
            this.txtBoxIllness.Location = new System.Drawing.Point(62, 108);
            this.txtBoxIllness.Name = "txtBoxIllness";
            this.txtBoxIllness.Size = new System.Drawing.Size(108, 22);
            this.txtBoxIllness.TabIndex = 7;
            // 
            // comboBoxSpecialty
            // 
            this.comboBoxSpecialty.FormattingEnabled = true;
            this.comboBoxSpecialty.Items.AddRange(new object[] {
            "Cardiology",
            "Neurology",
            "Traumatology",
            "Urgencies",
            "Family",
            "Pediatric"});
            this.comboBoxSpecialty.Location = new System.Drawing.Point(81, 86);
            this.comboBoxSpecialty.Name = "comboBoxSpecialty";
            this.comboBoxSpecialty.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSpecialty.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Specialty:";
            // 
            // tabNewPerson
            // 
            this.tabNewPerson.Controls.Add(this.tabDoctors);
            this.tabNewPerson.Controls.Add(this.tabPatient);
            this.tabNewPerson.Controls.Add(this.tabAdmin);
            this.tabNewPerson.Location = new System.Drawing.Point(69, 12);
            this.tabNewPerson.Name = "tabNewPerson";
            this.tabNewPerson.SelectedIndex = 0;
            this.tabNewPerson.Size = new System.Drawing.Size(250, 185);
            this.tabNewPerson.TabIndex = 11;
            // 
            // tabDoctors
            // 
            this.tabDoctors.Controls.Add(this.numericAgeDoctor);
            this.tabDoctors.Controls.Add(this.txtBoxDoctor);
            this.tabDoctors.Controls.Add(this.label9);
            this.tabDoctors.Controls.Add(this.label5);
            this.tabDoctors.Controls.Add(this.comboBoxSpecialty);
            this.tabDoctors.Controls.Add(this.label6);
            this.tabDoctors.Location = new System.Drawing.Point(4, 25);
            this.tabDoctors.Name = "tabDoctors";
            this.tabDoctors.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoctors.Size = new System.Drawing.Size(242, 156);
            this.tabDoctors.TabIndex = 0;
            this.tabDoctors.Text = "Doctor";
            this.tabDoctors.UseVisualStyleBackColor = true;
            // 
            // tabPatient
            // 
            this.tabPatient.Controls.Add(this.numericAgePatient);
            this.tabPatient.Controls.Add(this.txtBoxIllness);
            this.tabPatient.Controls.Add(this.txtBoxNamePatient);
            this.tabPatient.Controls.Add(this.label4);
            this.tabPatient.Controls.Add(this.txtBoxPhone);
            this.tabPatient.Controls.Add(this.label8);
            this.tabPatient.Controls.Add(this.label7);
            this.tabPatient.Controls.Add(this.label3);
            this.tabPatient.Location = new System.Drawing.Point(4, 25);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatient.Size = new System.Drawing.Size(197, 156);
            this.tabPatient.TabIndex = 1;
            this.tabPatient.Text = "Patient";
            this.tabPatient.UseVisualStyleBackColor = true;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.numericAgeAdmin);
            this.tabAdmin.Controls.Add(this.txtBoxNameAdmin);
            this.tabAdmin.Controls.Add(this.label10);
            this.tabAdmin.Controls.Add(this.label1);
            this.tabAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Size = new System.Drawing.Size(197, 156);
            this.tabAdmin.TabIndex = 2;
            this.tabAdmin.Text = "Administrative";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // txtBoxDoctor
            // 
            this.txtBoxDoctor.Location = new System.Drawing.Point(81, 20);
            this.txtBoxDoctor.Name = "txtBoxDoctor";
            this.txtBoxDoctor.Size = new System.Drawing.Size(121, 22);
            this.txtBoxDoctor.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Name:";
            // 
            // txtBoxNamePatient
            // 
            this.txtBoxNamePatient.Location = new System.Drawing.Point(62, 20);
            this.txtBoxNamePatient.Name = "txtBoxNamePatient";
            this.txtBoxNamePatient.Size = new System.Drawing.Size(108, 22);
            this.txtBoxNamePatient.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name:";
            // 
            // numericAgePatient
            // 
            this.numericAgePatient.Location = new System.Drawing.Point(62, 48);
            this.numericAgePatient.Name = "numericAgePatient";
            this.numericAgePatient.Size = new System.Drawing.Size(108, 22);
            this.numericAgePatient.TabIndex = 13;
            this.numericAgePatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Age:";
            // 
            // numericAgeDoctor
            // 
            this.numericAgeDoctor.Location = new System.Drawing.Point(81, 48);
            this.numericAgeDoctor.Name = "numericAgeDoctor";
            this.numericAgeDoctor.Size = new System.Drawing.Size(121, 22);
            this.numericAgeDoctor.TabIndex = 13;
            this.numericAgeDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Age:";
            // 
            // numericAgeAdmin
            // 
            this.numericAgeAdmin.Location = new System.Drawing.Point(62, 48);
            this.numericAgeAdmin.Name = "numericAgeAdmin";
            this.numericAgeAdmin.Size = new System.Drawing.Size(108, 22);
            this.numericAgeAdmin.TabIndex = 13;
            this.numericAgeAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Age:";
            // 
            // butCancelNewPerson
            // 
            this.butCancelNewPerson.AutoSize = true;
            this.butCancelNewPerson.BackColor = System.Drawing.Color.IndianRed;
            this.butCancelNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancelNewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancelNewPerson.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butCancelNewPerson.Location = new System.Drawing.Point(69, 212);
            this.butCancelNewPerson.Name = "butCancelNewPerson";
            this.butCancelNewPerson.Size = new System.Drawing.Size(103, 33);
            this.butCancelNewPerson.TabIndex = 12;
            this.butCancelNewPerson.Text = "Cancel";
            this.butCancelNewPerson.UseVisualStyleBackColor = false;
            this.butCancelNewPerson.Click += new System.EventHandler(this.butCancelNewPerson_Click);
            // 
            // butSubmitNewPerson
            // 
            this.butSubmitNewPerson.AutoSize = true;
            this.butSubmitNewPerson.BackColor = System.Drawing.SystemColors.Highlight;
            this.butSubmitNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSubmitNewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSubmitNewPerson.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butSubmitNewPerson.Location = new System.Drawing.Point(220, 212);
            this.butSubmitNewPerson.Name = "butSubmitNewPerson";
            this.butSubmitNewPerson.Size = new System.Drawing.Size(99, 33);
            this.butSubmitNewPerson.TabIndex = 13;
            this.butSubmitNewPerson.Text = "Submit";
            this.butSubmitNewPerson.UseVisualStyleBackColor = false;
            this.butSubmitNewPerson.Click += new System.EventHandler(this.butSubmitNewPerson_Click);
            // 
            // AddNewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(396, 279);
            this.Controls.Add(this.butSubmitNewPerson);
            this.Controls.Add(this.butCancelNewPerson);
            this.Controls.Add(this.tabNewPerson);
            this.Name = "AddNewPerson";
            this.Text = "AddNewPerson";
            this.tabNewPerson.ResumeLayout(false);
            this.tabDoctors.ResumeLayout(false);
            this.tabDoctors.PerformLayout();
            this.tabPatient.ResumeLayout(false);
            this.tabPatient.PerformLayout();
            this.tabAdmin.ResumeLayout(false);
            this.tabAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgePatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNameAdmin;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.TextBox txtBoxIllness;
        private System.Windows.Forms.ComboBox comboBoxSpecialty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabNewPerson;
        private System.Windows.Forms.TabPage tabDoctors;
        private System.Windows.Forms.TabPage tabPatient;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.NumericUpDown numericAgeDoctor;
        private System.Windows.Forms.TextBox txtBoxDoctor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericAgePatient;
        private System.Windows.Forms.TextBox txtBoxNamePatient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericAgeAdmin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button butCancelNewPerson;
        private System.Windows.Forms.Button butSubmitNewPerson;
    }
}