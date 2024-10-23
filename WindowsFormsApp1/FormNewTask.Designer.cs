namespace WindowsFormsApp1
{
    partial class FormNewTask
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
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.txtType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.txtCriticity = new System.Windows.Forms.Label();
            this.comboBoxCriticity = new System.Windows.Forms.ComboBox();
            this.txtEnviroment = new System.Windows.Forms.Label();
            this.checkBoxProd = new System.Windows.Forms.CheckBox();
            this.checkBoxPreprod = new System.Windows.Forms.CheckBox();
            this.checkBoxDemo = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textStartDate = new System.Windows.Forms.Label();
            this.dateTimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtDuration = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.Label();
            this.comboBoxPercentComplete = new System.Windows.Forms.ComboBox();
            this.checkBoxSendEmail = new System.Windows.Forms.CheckBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butSubmit = new System.Windows.Forms.Button();
            this.numUpDownDuration = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(14, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(42, 19);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "Title";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTitle.Location = new System.Drawing.Point(17, 33);
            this.txtBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(352, 27);
            this.txtBoxTitle.TabIndex = 2;
            // 
            // txtLocation
            // 
            this.txtLocation.AutoSize = true;
            this.txtLocation.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(418, 9);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(77, 19);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.Text = "Location";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Items.AddRange(new object[] {
            "Barcelona",
            "Madrid",
            "Cornellá de Llobregat",
            "Prat de Llobregat"});
            this.comboBoxLocation.Location = new System.Drawing.Point(421, 33);
            this.comboBoxLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(290, 28);
            this.comboBoxLocation.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.AutoSize = true;
            this.txtType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(13, 91);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(46, 19);
            this.txtType.TabIndex = 1;
            this.txtType.Text = "Type";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Incident",
            "Bug",
            "Meeting",
            "Error"});
            this.comboBoxType.Location = new System.Drawing.Point(17, 114);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(219, 27);
            this.comboBoxType.TabIndex = 3;
            this.comboBoxType.Text = "Incident";
            // 
            // txtCriticity
            // 
            this.txtCriticity.AutoSize = true;
            this.txtCriticity.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriticity.Location = new System.Drawing.Point(280, 91);
            this.txtCriticity.Name = "txtCriticity";
            this.txtCriticity.Size = new System.Drawing.Size(70, 19);
            this.txtCriticity.TabIndex = 1;
            this.txtCriticity.Text = "Criticity";
            // 
            // comboBoxCriticity
            // 
            this.comboBoxCriticity.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCriticity.FormattingEnabled = true;
            this.comboBoxCriticity.Items.AddRange(new object[] {
            "Minor",
            "Medium",
            "High",
            "Very High"});
            this.comboBoxCriticity.Location = new System.Drawing.Point(284, 114);
            this.comboBoxCriticity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCriticity.Name = "comboBoxCriticity";
            this.comboBoxCriticity.Size = new System.Drawing.Size(207, 27);
            this.comboBoxCriticity.TabIndex = 3;
            this.comboBoxCriticity.Text = "Minor";
            // 
            // txtEnviroment
            // 
            this.txtEnviroment.AutoSize = true;
            this.txtEnviroment.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnviroment.Location = new System.Drawing.Point(531, 91);
            this.txtEnviroment.Name = "txtEnviroment";
            this.txtEnviroment.Size = new System.Drawing.Size(99, 19);
            this.txtEnviroment.TabIndex = 1;
            this.txtEnviroment.Text = "Enviroment";
            // 
            // checkBoxProd
            // 
            this.checkBoxProd.AutoSize = true;
            this.checkBoxProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxProd.Location = new System.Drawing.Point(533, 121);
            this.checkBoxProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxProd.Name = "checkBoxProd";
            this.checkBoxProd.Size = new System.Drawing.Size(66, 24);
            this.checkBoxProd.TabIndex = 4;
            this.checkBoxProd.Text = "Prod";
            this.checkBoxProd.UseVisualStyleBackColor = true;
            // 
            // checkBoxPreprod
            // 
            this.checkBoxPreprod.AutoSize = true;
            this.checkBoxPreprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPreprod.Location = new System.Drawing.Point(533, 155);
            this.checkBoxPreprod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxPreprod.Name = "checkBoxPreprod";
            this.checkBoxPreprod.Size = new System.Drawing.Size(90, 24);
            this.checkBoxPreprod.TabIndex = 4;
            this.checkBoxPreprod.Text = "Preprod";
            this.checkBoxPreprod.UseVisualStyleBackColor = true;
            // 
            // checkBoxDemo
            // 
            this.checkBoxDemo.AutoSize = true;
            this.checkBoxDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDemo.Location = new System.Drawing.Point(533, 189);
            this.checkBoxDemo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxDemo.Name = "checkBoxDemo";
            this.checkBoxDemo.Size = new System.Drawing.Size(76, 24);
            this.checkBoxDemo.TabIndex = 4;
            this.checkBoxDemo.Text = "Demo";
            this.checkBoxDemo.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(14, 233);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(99, 19);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(18, 265);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(693, 100);
            this.textBoxDescription.TabIndex = 5;
            // 
            // textStartDate
            // 
            this.textStartDate.AutoSize = true;
            this.textStartDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStartDate.Location = new System.Drawing.Point(14, 382);
            this.textStartDate.Name = "textStartDate";
            this.textStartDate.Size = new System.Drawing.Size(87, 19);
            this.textStartDate.TabIndex = 1;
            this.textStartDate.Text = "Start date";
            // 
            // dateTimeStartDate
            // 
            this.dateTimeStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStartDate.CustomFormat = " ";
            this.dateTimeStartDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStartDate.Location = new System.Drawing.Point(18, 404);
            this.dateTimeStartDate.Name = "dateTimeStartDate";
            this.dateTimeStartDate.Size = new System.Drawing.Size(350, 27);
            this.dateTimeStartDate.TabIndex = 6;
            this.dateTimeStartDate.Value = new System.DateTime(2024, 10, 23, 12, 16, 51, 0);
            this.dateTimeStartDate.ValueChanged += new System.EventHandler(this.dateTimeStartDate_ValueChanged);
            this.dateTimeStartDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimeStartDate_KeyDown);
            // 
            // txtDuration
            // 
            this.txtDuration.AutoSize = true;
            this.txtDuration.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(417, 382);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(159, 19);
            this.txtDuration.TabIndex = 1;
            this.txtDuration.Text = "Duration (in hours)";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(15, 475);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(60, 19);
            this.txtStatus.TabIndex = 1;
            this.txtStatus.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Planned",
            "Done",
            "In Progress"});
            this.comboBoxStatus.Location = new System.Drawing.Point(18, 497);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(351, 27);
            this.comboBoxStatus.TabIndex = 3;
            this.comboBoxStatus.Tag = "";
            this.comboBoxStatus.Text = "Planned";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            // 
            // txtPercent
            // 
            this.txtPercent.AutoSize = true;
            this.txtPercent.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercent.Location = new System.Drawing.Point(418, 474);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(146, 19);
            this.txtPercent.TabIndex = 1;
            this.txtPercent.Text = "Percent complete";
            // 
            // comboBoxPercentComplete
            // 
            this.comboBoxPercentComplete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPercentComplete.FormattingEnabled = true;
            this.comboBoxPercentComplete.Items.AddRange(new object[] {
            "0%",
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.comboBoxPercentComplete.Location = new System.Drawing.Point(421, 497);
            this.comboBoxPercentComplete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxPercentComplete.Name = "comboBoxPercentComplete";
            this.comboBoxPercentComplete.Size = new System.Drawing.Size(290, 27);
            this.comboBoxPercentComplete.TabIndex = 3;
            this.comboBoxPercentComplete.Text = "0%";
            // 
            // checkBoxSendEmail
            // 
            this.checkBoxSendEmail.AutoSize = true;
            this.checkBoxSendEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSendEmail.Location = new System.Drawing.Point(17, 548);
            this.checkBoxSendEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSendEmail.Name = "checkBoxSendEmail";
            this.checkBoxSendEmail.Size = new System.Drawing.Size(310, 22);
            this.checkBoxSendEmail.TabIndex = 4;
            this.checkBoxSendEmail.Text = "Check here if you want to send an email";
            this.checkBoxSendEmail.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.Location = new System.Drawing.Point(555, 626);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 31);
            this.butCancel.TabIndex = 7;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butSubmit
            // 
            this.butSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butSubmit.FlatAppearance.BorderSize = 0;
            this.butSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSubmit.Location = new System.Drawing.Point(636, 626);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(75, 31);
            this.butSubmit.TabIndex = 7;
            this.butSubmit.Text = "Submit";
            this.butSubmit.UseVisualStyleBackColor = false;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // numUpDownDuration
            // 
            this.numUpDownDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownDuration.Location = new System.Drawing.Point(421, 408);
            this.numUpDownDuration.Name = "numUpDownDuration";
            this.numUpDownDuration.Size = new System.Drawing.Size(290, 27);
            this.numUpDownDuration.TabIndex = 8;
            this.numUpDownDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormReplica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(723, 669);
            this.Controls.Add(this.numUpDownDuration);
            this.Controls.Add(this.butSubmit);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.dateTimeStartDate);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.checkBoxDemo);
            this.Controls.Add(this.checkBoxPreprod);
            this.Controls.Add(this.checkBoxSendEmail);
            this.Controls.Add(this.checkBoxProd);
            this.Controls.Add(this.comboBoxCriticity);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.txtEnviroment);
            this.Controls.Add(this.txtCriticity);
            this.Controls.Add(this.comboBoxPercentComplete);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.textStartDate);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormReplica";
            this.Text = "Create new task";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label txtLocation;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Label txtType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label txtCriticity;
        private System.Windows.Forms.ComboBox comboBoxCriticity;
        private System.Windows.Forms.Label txtEnviroment;
        private System.Windows.Forms.CheckBox checkBoxProd;
        private System.Windows.Forms.CheckBox checkBoxPreprod;
        private System.Windows.Forms.CheckBox checkBoxDemo;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label textStartDate;
        private System.Windows.Forms.DateTimePicker dateTimeStartDate;
        private System.Windows.Forms.Label txtDuration;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtPercent;
        private System.Windows.Forms.ComboBox comboBoxPercentComplete;
        private System.Windows.Forms.CheckBox checkBoxSendEmail;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.NumericUpDown numUpDownDuration;
    }
}