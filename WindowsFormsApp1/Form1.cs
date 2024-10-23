using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            buttonMostrar.Text = listDiasSemana.Text;
        }

        private void listDiasSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonMostrar.Text = listDiasSemana.SelectedItem.ToString();
        }
    }
}
