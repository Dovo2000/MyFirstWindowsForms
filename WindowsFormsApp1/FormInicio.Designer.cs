namespace WindowsFormsApp1
{
    partial class FormInicio
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
            this.butNewTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butNewTask
            // 
            this.butNewTask.AutoSize = true;
            this.butNewTask.Location = new System.Drawing.Point(93, 40);
            this.butNewTask.Name = "butNewTask";
            this.butNewTask.Size = new System.Drawing.Size(97, 39);
            this.butNewTask.TabIndex = 2;
            this.butNewTask.Text = "Add new task";
            this.butNewTask.UseVisualStyleBackColor = true;
            this.butNewTask.Click += new System.EventHandler(this.butNewTask_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 114);
            this.Controls.Add(this.butNewTask);
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butNewTask;
    }
}

