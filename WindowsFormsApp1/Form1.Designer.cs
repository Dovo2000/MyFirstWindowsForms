namespace WindowsFormsApp1
{
    partial class FormPrincipal
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
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.listDiasSemana = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(135, 34);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(96, 39);
            this.buttonMostrar.TabIndex = 2;
            this.buttonMostrar.Text = "Pulsar Aquí";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // listDiasSemana
            // 
            this.listDiasSemana.FormattingEnabled = true;
            this.listDiasSemana.ItemHeight = 16;
            this.listDiasSemana.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.listDiasSemana.Location = new System.Drawing.Point(125, 79);
            this.listDiasSemana.Name = "listDiasSemana";
            this.listDiasSemana.Size = new System.Drawing.Size(120, 116);
            this.listDiasSemana.TabIndex = 3;
            this.listDiasSemana.SelectedIndexChanged += new System.EventHandler(this.listDiasSemana_SelectedIndexChanged);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 207);
            this.Controls.Add(this.listDiasSemana);
            this.Controls.Add(this.buttonMostrar);
            this.Name = "FormPrincipal";
            this.Text = "Mi Primera Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.ListBox listDiasSemana;
    }
}

