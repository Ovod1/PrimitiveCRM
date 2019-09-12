using CrmBL.Model;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class EmployeeForm : Form
    {
        public Employee Employee { get; set; }
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee = new Employee()
            {
                Name = textBox1.Text,
                DepartmentId = int.Parse(textBox2.Text),
                Email = textBox3.Text
            };
            Close();

        }
    }
}
