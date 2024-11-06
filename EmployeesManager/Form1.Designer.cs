namespace EmployeesManager
{
    partial class Form1
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
            this.butAdd = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.txtBoxJobTitle = new System.Windows.Forms.TextBox();
            this.numericMinSalary = new System.Windows.Forms.NumericUpDown();
            this.numericMaxSalary = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.butRefresh = new System.Windows.Forms.Button();
            this.liBoxJobs = new System.Windows.Forms.ListBox();
            this.butUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // butAdd
            // 
            this.butAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.Location = new System.Drawing.Point(51, 214);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(155, 35);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butCancel
            // 
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.Location = new System.Drawing.Point(212, 214);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(155, 35);
            this.butCancel.TabIndex = 3;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // txtBoxJobTitle
            // 
            this.txtBoxJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxJobTitle.Location = new System.Drawing.Point(189, 75);
            this.txtBoxJobTitle.Name = "txtBoxJobTitle";
            this.txtBoxJobTitle.Size = new System.Drawing.Size(178, 27);
            this.txtBoxJobTitle.TabIndex = 4;
            // 
            // numericMinSalary
            // 
            this.numericMinSalary.DecimalPlaces = 2;
            this.numericMinSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMinSalary.Location = new System.Drawing.Point(189, 115);
            this.numericMinSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericMinSalary.Name = "numericMinSalary";
            this.numericMinSalary.Size = new System.Drawing.Size(178, 27);
            this.numericMinSalary.TabIndex = 5;
            // 
            // numericMaxSalary
            // 
            this.numericMaxSalary.DecimalPlaces = 2;
            this.numericMaxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMaxSalary.Location = new System.Drawing.Point(189, 156);
            this.numericMaxSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericMaxSalary.Name = "numericMaxSalary";
            this.numericMaxSalary.Size = new System.Drawing.Size(178, 27);
            this.numericMaxSalary.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Job Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Max Salary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Min Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "New Job:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Update Job:";
            // 
            // butRefresh
            // 
            this.butRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRefresh.Location = new System.Drawing.Point(406, 214);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(155, 35);
            this.butRefresh.TabIndex = 13;
            this.butRefresh.Text = "Refresh";
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // liBoxJobs
            // 
            this.liBoxJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.liBoxJobs.FormattingEnabled = true;
            this.liBoxJobs.ItemHeight = 16;
            this.liBoxJobs.Location = new System.Drawing.Point(406, 75);
            this.liBoxJobs.Name = "liBoxJobs";
            this.liBoxJobs.Size = new System.Drawing.Size(316, 116);
            this.liBoxJobs.TabIndex = 14;
            this.liBoxJobs.SelectedIndexChanged += new System.EventHandler(this.liBoxJobs_SelectedIndexChanged);
            // 
            // butUpdate
            // 
            this.butUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdate.Location = new System.Drawing.Point(567, 214);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(155, 35);
            this.butUpdate.TabIndex = 15;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 292);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.liBoxJobs);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericMaxSalary);
            this.Controls.Add(this.numericMinSalary);
            this.Controls.Add(this.txtBoxJobTitle);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericMinSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.TextBox txtBoxJobTitle;
        private System.Windows.Forms.NumericUpDown numericMinSalary;
        private System.Windows.Forms.NumericUpDown numericMaxSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.ListBox liBoxJobs;
        private System.Windows.Forms.Button butUpdate;
    }
}

