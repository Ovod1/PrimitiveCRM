﻿using CrmBL.Model;
using System;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class ProjectForm : Form
    {
        public Project Project { get; set; }
        public ProjectForm()
        {
            InitializeComponent();
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Project = new Project()
            {
                Name = textBox1.Text,
                CustomerId = int.Parse(textBox2.Text)
            };
            Close();
        }
    }
}
