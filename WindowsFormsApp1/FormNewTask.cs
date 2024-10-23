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
    public partial class FormNewTask : Form
    {
        public FormNewTask()
        {
            InitializeComponent();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            // Go to the previous form
            this.Close();
        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            if(txtBoxTitle.Text != "" && textBoxDescription.Text != "")
            {
                if (checkBoxDemo.Checked || checkBoxPreprod.Checked || checkBoxProd.Checked)
                {
                    MessageBox.Show("Task created:\n" +
"Title: " + txtBoxTitle.Text + "\n" +
"Description: " + textBoxDescription.Text + "\n" +
"Location: " + (comboBoxLocation.SelectedItem != null ? comboBoxLocation.SelectedItem.ToString() : "") + "\n" +
"Criticity: " + comboBoxCriticity.SelectedItem.ToString() + "\n" +
"Enviroment: " + (checkBoxPreprod.Checked ? "Preprod " : "") + 
(checkBoxProd.Checked ? "Prod " : "") +
(checkBoxDemo.Checked ? "Demo " : "") + "\n" +
"Start date: " + dateTimeStartDate.Text + "\n" +
"Duration: " + numUpDownDuration.Value.ToString() + " Hours" + "\n" +
"Status: " + comboBoxStatus.SelectedItem.ToString() + "\n" +
"Percent complete: " + comboBoxPercentComplete.SelectedItem.ToString() + "\n" +
"Send Email? " + (checkBoxSendEmail.Checked ? "Yes" : "No"));
                    return;
                }
            }
            MessageBox.Show("Some camps need to be completed");
        }

        private void dateTimeStartDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimeStartDate.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimeStartDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                dateTimeStartDate.CustomFormat = " ";
        }
    }
}
