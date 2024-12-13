﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5a
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.personDataSet.Person);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            personBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validate();
            personBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(personDataSet);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            personBindingSource.RemoveCurrent();
            tableAdapterManager.UpdateAll(personDataSet);
        }
    }
}