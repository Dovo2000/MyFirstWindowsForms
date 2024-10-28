namespace HospitalForm
{
    partial class HospitalManager
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "David",
            "665473214",
            "Esguince",
            "2",
            "24"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Pepito",
            "33",
            "Cardio"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("4");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("5");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("6");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("7");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("8");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("9");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("10");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("");
            this.butDoctors = new System.Windows.Forms.Button();
            this.butAddDoctor = new System.Windows.Forms.Button();
            this.butPatients = new System.Windows.Forms.Button();
            this.butAdmins = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IDPatients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamePatients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgePatients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhonePatients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IllnessPatients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DoctorPatients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // butDoctors
            // 
            this.butDoctors.BackColor = System.Drawing.SystemColors.Highlight;
            this.butDoctors.FlatAppearance.BorderSize = 0;
            this.butDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDoctors.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butDoctors.Location = new System.Drawing.Point(54, 95);
            this.butDoctors.Name = "butDoctors";
            this.butDoctors.Size = new System.Drawing.Size(186, 57);
            this.butDoctors.TabIndex = 1;
            this.butDoctors.Text = "Doctors";
            this.butDoctors.UseVisualStyleBackColor = false;
            // 
            // butAddDoctor
            // 
            this.butAddDoctor.BackColor = System.Drawing.SystemColors.Highlight;
            this.butAddDoctor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.butAddDoctor.FlatAppearance.BorderSize = 0;
            this.butAddDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddDoctor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butAddDoctor.Location = new System.Drawing.Point(608, 95);
            this.butAddDoctor.Name = "butAddDoctor";
            this.butAddDoctor.Size = new System.Drawing.Size(87, 57);
            this.butAddDoctor.TabIndex = 2;
            this.butAddDoctor.Text = "Add new";
            this.butAddDoctor.UseVisualStyleBackColor = false;
            // 
            // butPatients
            // 
            this.butPatients.BackColor = System.Drawing.SystemColors.Highlight;
            this.butPatients.FlatAppearance.BorderSize = 0;
            this.butPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPatients.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butPatients.Location = new System.Drawing.Point(237, 95);
            this.butPatients.Name = "butPatients";
            this.butPatients.Size = new System.Drawing.Size(186, 57);
            this.butPatients.TabIndex = 1;
            this.butPatients.Text = "Patients";
            this.butPatients.UseVisualStyleBackColor = false;
            // 
            // butAdmins
            // 
            this.butAdmins.BackColor = System.Drawing.SystemColors.Highlight;
            this.butAdmins.FlatAppearance.BorderSize = 0;
            this.butAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdmins.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butAdmins.Location = new System.Drawing.Point(419, 95);
            this.butAdmins.Name = "butAdmins";
            this.butAdmins.Size = new System.Drawing.Size(186, 57);
            this.butAdmins.TabIndex = 1;
            this.butAdmins.Text = "Administratives";
            this.butAdmins.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hospital";
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDPatients,
            this.NamePatients,
            this.PhonePatients,
            this.IllnessPatients,
            this.DoctorPatients,
            this.AgePatients});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11});
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(54, 155);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(551, 223);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // IDPatients
            // 
            this.IDPatients.Text = "ID";
            this.IDPatients.Width = 32;
            // 
            // NamePatients
            // 
            this.NamePatients.Text = "Name";
            this.NamePatients.Width = 64;
            // 
            // AgePatients
            // 
            this.AgePatients.Tag = "";
            this.AgePatients.Text = "Age";
            this.AgePatients.Width = 48;
            // 
            // PhonePatients
            // 
            this.PhonePatients.Text = "Phone";
            this.PhonePatients.Width = 86;
            // 
            // IllnessPatients
            // 
            this.IllnessPatients.Text = "Illness";
            this.IllnessPatients.Width = 86;
            // 
            // DoctorPatients
            // 
            this.DoctorPatients.Text = "DoctorID";
            this.DoctorPatients.Width = 64;
            // 
            // HospitalManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.butAdmins);
            this.Controls.Add(this.butAddDoctor);
            this.Controls.Add(this.butPatients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDoctors);
            this.Name = "HospitalManager";
            this.Text = "Hospital Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butDoctors;
        private System.Windows.Forms.Button butPatients;
        private System.Windows.Forms.Button butAdmins;
        private System.Windows.Forms.Button butAddDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IDPatients;
        private System.Windows.Forms.ColumnHeader NamePatients;
        private System.Windows.Forms.ColumnHeader AgePatients;
        private System.Windows.Forms.ColumnHeader PhonePatients;
        private System.Windows.Forms.ColumnHeader IllnessPatients;
        private System.Windows.Forms.ColumnHeader DoctorPatients;
    }
}

