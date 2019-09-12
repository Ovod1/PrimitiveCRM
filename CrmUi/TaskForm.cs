using CrmBL.Model;
using System;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class TaskForm : Form
    {
        public Task Task { get; set; }
        public TaskForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task = new Task()
            {
                Name = textBox1.Text,
                Content = textBox2.Text,
                ControlTime = DateTime.ParseExact(textBox3.Text, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture),
                Status = textBox4.Text,
                ProjectId = int.Parse(textBox5.Text),
                DepartmentName = textBox6.Text
            };
            Close();
        }


    }
}
