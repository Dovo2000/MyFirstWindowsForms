namespace HospitalForm
{
    partial class AssignDoctor
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Antonio",
            "Cardio",
            "60"}, -1);
            this.liViewDoctors = new System.Windows.Forms.ListView();
            this.IDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpecialtyColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelIllness = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            this.butAssign = new System.Windows.Forms.Button();
            this.labelHasDoc = new System.Windows.Forms.Label();
            this.labelDocId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // liViewDoctors
            // 
            this.liViewDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.liViewDoctors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.NameColumn,
            this.SpecialtyColumn,
            this.AgeColumn});
            this.liViewDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liViewDoctors.HideSelection = false;
            this.liViewDoctors.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.liViewDoctors.Location = new System.Drawing.Point(260, 32);
            this.liViewDoctors.MultiSelect = false;
            this.liViewDoctors.Name = "liViewDoctors";
            this.liViewDoctors.Size = new System.Drawing.Size(279, 230);
            this.liViewDoctors.TabIndex = 0;
            this.liViewDoctors.UseCompatibleStateImageBehavior = false;
            this.liViewDoctors.View = System.Windows.Forms.View.Details;
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "ID";
            this.IDColumn.Width = 31;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 82;
            // 
            // SpecialtyColumn
            // 
            this.SpecialtyColumn.Text = "Specialty";
            this.SpecialtyColumn.Width = 77;
            // 
            // AgeColumn
            // 
            this.AgeColumn.Text = "Age";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Info:";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(37, 96);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name: ";
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(37, 67);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(36, 20);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID: ";
            // 
            // labelAge
            // 
            this.labelAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(37, 154);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(48, 20);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Age: ";
            // 
            // labelIllness
            // 
            this.labelIllness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIllness.AutoSize = true;
            this.labelIllness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIllness.Location = new System.Drawing.Point(37, 125);
            this.labelIllness.Name = "labelIllness";
            this.labelIllness.Size = new System.Drawing.Size(67, 20);
            this.labelIllness.TabIndex = 5;
            this.labelIllness.Text = "Illness: ";
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(37, 183);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(66, 20);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Phone: ";
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.IndianRed;
            this.butCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butCancel.Location = new System.Drawing.Point(0, 359);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(600, 37);
            this.butCancel.TabIndex = 7;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butAssign
            // 
            this.butAssign.BackColor = System.Drawing.SystemColors.Highlight;
            this.butAssign.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.butAssign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAssign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butAssign.Location = new System.Drawing.Point(0, 322);
            this.butAssign.Name = "butAssign";
            this.butAssign.Size = new System.Drawing.Size(600, 37);
            this.butAssign.TabIndex = 8;
            this.butAssign.Text = "Assign";
            this.butAssign.UseVisualStyleBackColor = false;
            this.butAssign.Click += new System.EventHandler(this.butAssign_Click);
            // 
            // labelHasDoc
            // 
            this.labelHasDoc.AutoSize = true;
            this.labelHasDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasDoc.Location = new System.Drawing.Point(37, 214);
            this.labelHasDoc.Name = "labelHasDoc";
            this.labelHasDoc.Size = new System.Drawing.Size(102, 20);
            this.labelHasDoc.TabIndex = 9;
            this.labelHasDoc.Text = "Has doctor: ";
            // 
            // labelDocId
            // 
            this.labelDocId.AutoSize = true;
            this.labelDocId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocId.Location = new System.Drawing.Point(37, 246);
            this.labelDocId.Name = "labelDocId";
            this.labelDocId.Size = new System.Drawing.Size(92, 20);
            this.labelDocId.TabIndex = 10;
            this.labelDocId.Text = "Doctor ID: ";
            // 
            // AssignDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 396);
            this.Controls.Add(this.labelDocId);
            this.Controls.Add(this.labelHasDoc);
            this.Controls.Add(this.butAssign);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelIllness);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liViewDoctors);
            this.Name = "AssignDoctor";
            this.Text = "AssignDoctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView liViewDoctors;
        private System.Windows.Forms.ColumnHeader IDColumn;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader SpecialtyColumn;
        private System.Windows.Forms.ColumnHeader AgeColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelIllness;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butAssign;
        private System.Windows.Forms.Label labelHasDoc;
        private System.Windows.Forms.Label labelDocId;
    }
}