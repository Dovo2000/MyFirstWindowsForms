﻿using System;
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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void butNewTask_Click(object sender, EventArgs e)
        {
            FormNewTask frmNewTask = new FormNewTask(); // Creating a form
            frmNewTask.Show(); // displaying the form
        }
    }
}
