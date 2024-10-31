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
            "24",
            "2"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Pepito",
            "33",
            "Cardio"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "4"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "5"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "6"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "7"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "8"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "9"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "10"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, null);
            this.butDoctors = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butPatients = new System.Windows.Forms.Button();
            this.butAdmins = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.liViewPeopleInfo = new System.Windows.Forms.ListView();
            this.IDPatients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamePatients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhonePatients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IllnessPatients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgePatients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DoctorPatients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butAppointments = new System.Windows.Forms.Button();
            this.butAsignDoctor = new System.Windows.Forms.Button();
            this.butCheckPatients = new System.Windows.Forms.Button();
            this.butRemove = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
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
            this.butDoctors.Click += new System.EventHandler(this.butDoctors_Click);
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.butAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.butAdd.FlatAppearance.BorderSize = 0;
            this.butAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butAdd.Location = new System.Drawing.Point(603, 95);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(145, 57);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "Add new";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
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
            this.butPatients.Click += new System.EventHandler(this.butPatients_Click);
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
            this.butAdmins.Click += new System.EventHandler(this.butAdmins_Click);
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
            // liViewPeopleInfo
            // 
            this.liViewPeopleInfo.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.liViewPeopleInfo.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.liViewPeopleInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.liViewPeopleInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.liViewPeopleInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDPatients,
            this.NamePatients,
            this.PhonePatients,
            this.IllnessPatients,
            this.AgePatients,
            this.DoctorPatients});
            this.liViewPeopleInfo.GridLines = true;
            this.liViewPeopleInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.liViewPeopleInfo.HideSelection = false;
            this.liViewPeopleInfo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.liViewPeopleInfo.LabelWrap = false;
            this.liViewPeopleInfo.Location = new System.Drawing.Point(54, 150);
            this.liViewPeopleInfo.Margin = new System.Windows.Forms.Padding(0);
            this.liViewPeopleInfo.MultiSelect = false;
            this.liViewPeopleInfo.Name = "liViewPeopleInfo";
            this.liViewPeopleInfo.Size = new System.Drawing.Size(551, 218);
            this.liViewPeopleInfo.TabIndex = 1;
            this.liViewPeopleInfo.UseCompatibleStateImageBehavior = false;
            this.liViewPeopleInfo.View = System.Windows.Forms.View.Details;
            this.liViewPeopleInfo.SelectedIndexChanged += new System.EventHandler(this.liViewPersonInfo_SelectedIndexChanged);
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
            // AgePatients
            // 
            this.AgePatients.Tag = "";
            this.AgePatients.Text = "Age";
            this.AgePatients.Width = 48;
            // 
            // DoctorPatients
            // 
            this.DoctorPatients.Text = "DoctorID";
            this.DoctorPatients.Width = 72;
            // 
            // butAppointments
            // 
            this.butAppointments.BackColor = System.Drawing.SystemColors.Highlight;
            this.butAppointments.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.butAppointments.FlatAppearance.BorderSize = 0;
            this.butAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAppointments.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butAppointments.Location = new System.Drawing.Point(603, 150);
            this.butAppointments.Name = "butAppointments";
            this.butAppointments.Size = new System.Drawing.Size(145, 57);
            this.butAppointments.TabIndex = 8;
            this.butAppointments.Text = "Appointments";
            this.butAppointments.UseVisualStyleBackColor = false;
            // 
            // butAsignDoctor
            // 
            this.butAsignDoctor.BackColor = System.Drawing.SystemColors.Highlight;
            this.butAsignDoctor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.butAsignDoctor.FlatAppearance.BorderSize = 0;
            this.butAsignDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAsignDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAsignDoctor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butAsignDoctor.Location = new System.Drawing.Point(603, 202);
            this.butAsignDoctor.Name = "butAsignDoctor";
            this.butAsignDoctor.Size = new System.Drawing.Size(145, 59);
            this.butAsignDoctor.TabIndex = 9;
            this.butAsignDoctor.Text = "Asign Doctor";
            this.butAsignDoctor.UseVisualStyleBackColor = false;
            this.butAsignDoctor.Click += new System.EventHandler(this.butAsignDoctor_Click);
            // 
            // butCheckPatients
            // 
            this.butCheckPatients.BackColor = System.Drawing.SystemColors.Highlight;
            this.butCheckPatients.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.butCheckPatients.FlatAppearance.BorderSize = 0;
            this.butCheckPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCheckPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCheckPatients.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butCheckPatients.Location = new System.Drawing.Point(603, 202);
            this.butCheckPatients.Name = "butCheckPatients";
            this.butCheckPatients.Size = new System.Drawing.Size(145, 57);
            this.butCheckPatients.TabIndex = 10;
            this.butCheckPatients.Text = "See Patients";
            this.butCheckPatients.UseVisualStyleBackColor = false;
            this.butCheckPatients.Click += new System.EventHandler(this.butCheckPatients_Click);
            // 
            // butRemove
            // 
            this.butRemove.BackColor = System.Drawing.Color.IndianRed;
            this.butRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.butRemove.FlatAppearance.BorderSize = 0;
            this.butRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRemove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butRemove.Location = new System.Drawing.Point(603, 320);
            this.butRemove.Name = "butRemove";
            this.butRemove.Size = new System.Drawing.Size(145, 48);
            this.butRemove.TabIndex = 14;
            this.butRemove.Text = "Remove";
            this.butRemove.UseVisualStyleBackColor = false;
            this.butRemove.Click += new System.EventHandler(this.butRemove_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.butUpdate.FlatAppearance.BorderSize = 0;
            this.butUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butUpdate.Location = new System.Drawing.Point(603, 257);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(145, 63);
            this.butUpdate.TabIndex = 15;
            this.butUpdate.Text = "Refresh";
            this.butUpdate.UseVisualStyleBackColor = false;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // HospitalManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butRemove);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butCheckPatients);
            this.Controls.Add(this.butAsignDoctor);
            this.Controls.Add(this.butAppointments);
            this.Controls.Add(this.liViewPeopleInfo);
            this.Controls.Add(this.butAdmins);
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
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView liViewPeopleInfo;
        private System.Windows.Forms.ColumnHeader IDPatients;
        private System.Windows.Forms.ColumnHeader NamePatients;
        private System.Windows.Forms.ColumnHeader AgePatients;
        private System.Windows.Forms.ColumnHeader PhonePatients;
        private System.Windows.Forms.ColumnHeader IllnessPatients;
        private System.Windows.Forms.ColumnHeader DoctorPatients;
        private System.Windows.Forms.Button butAppointments;
        private System.Windows.Forms.Button butAsignDoctor;
        private System.Windows.Forms.Button butCheckPatients;
        private System.Windows.Forms.Button butRemove;
        private System.Windows.Forms.Button butUpdate;
    }
}

