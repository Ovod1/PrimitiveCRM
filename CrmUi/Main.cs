using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL.Model;

namespace CrmUi
{
    public partial class Main : Form
    {
        CrmContext db;
        public Main()
        {
            InitializeComponent();
            db = new CrmContext();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void toDoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myTascsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toDoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            var rosterDevelopTodo = new Roster<CrmBL.Model.Task>(db.Database.SqlQuery<CrmBL.Model.Task>("SELECT * FROM Task WHERE DepartmentName ='Development' AND Status ='To do'"));
            //rosterDevelopTodo.Show(); 
            //var rosterDevelopTodo = new Roster<CrmBL.Model.Task>(db.Tasks);
            //rosterDevelopTodo.Show();
        }

        private void newTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TaskForm();
            if(form.ShowDialog()==DialogResult.OK)
            {
                db.Tasks.Add(form.Task);
                db.SaveChanges();
            }
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EmployeeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Employees.Add(form.Employee);
                db.SaveChanges();
            }
        }

        private void newProgectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProjectForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Projects.Add(form.Project);
                db.SaveChanges();
            }
        }

        private void progressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var rosterDevelopTodo = new Roster<CrmBL.Model.Task>(db.Database.SqlQuery<CrmBL.Model.Task>("SELECT * FROM Task WHERE DepartmentName ='Development' AND Status ='Progress'"));
        }

        private void doneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var rosterDevelopTodo = new Roster<CrmBL.Model.Task>(db.Database.SqlQuery<CrmBL.Model.Task>("SELECT * FROM Task WHERE DepartmentName ='Development' AND Status ='Done'"));
        }

        private void allTascsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rosterDevelopTodo = new Roster<CrmBL.Model.Task>(db.Database.SqlQuery<CrmBL.Model.Task>("SELECT * FROM Task WHERE DepartmentName ='Development'"));
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rosterDevelopTodo = new Roster<CrmBL.Model.Employee>(db.Database.SqlQuery<CrmBL.Model.Employee>("SELECT * FROM Employee WHERE DepartmentName ='Development'"));
        }

        private void soonDeadlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Develop soon deadline
        }

        private void toDoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var rosterDevelopTodo = new Roster<CrmBL.Model.Task>(db.Database.SqlQuery<CrmBL.Model.Task>("SELECT * FROM Task WHERE DepartmentName ='Test' AND Status ='To do'"));
        }

        private void progressToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var rosterDevelopTodo = new Roster<CrmBL.Model.Task>(db.Database.SqlQuery<CrmBL.Model.Task>("SELECT * FROM Task WHERE DepartmentName ='Test' AND Status ='Progress'"));
        }

        private void doneToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var rosterDevelopTodo = new Roster<CrmBL.Model.Task>(db.Database.SqlQuery<CrmBL.Model.Task>("SELECT * FROM Task WHERE DepartmentName ='Test' AND Status ='Done'"));
        }

        private void allTascsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var rosterDevelopTodo = new Roster<CrmBL.Model.Task>(db.Database.SqlQuery<CrmBL.Model.Task>("SELECT * FROM Task WHERE DepartmentName ='Test'"));
        }

        private void listOfEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rosterDevelopTodo = new Roster<CrmBL.Model.Employee>(db.Database.SqlQuery<CrmBL.Model.Employee>("SELECT * FROM Employee WHERE DepartmentName ='Development'"));
        }

        private void soonDeadlineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Test soon deadline
        }

        private void toDoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var rosterDevelopTodo = new Roster<CrmBL.Model.Task>(db.Database.SqlQuery<CrmBL.Model.Task>("SELECT * FROM Task WHERE DepartmentName ='Design' AND Status ='To do'"));
        }

        private void progressToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var rosterDevelopTodo = new Roster<CrmBL.Model.Task>(db.Database.SqlQuery<CrmBL.Model.Task>("SELECT * FROM Task WHERE DepartmentName ='Design' AND Status ='Progress'"));
        }

        private void doneToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var rosterDevelopTodo = new Roster<CrmBL.Model.Task>(db.Database.SqlQuery<CrmBL.Model.Task>("SELECT * FROM Task WHERE DepartmentName ='Design' AND Status ='Done'"));
        }

        private void allTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rosterDevelopTodo = new Roster<CrmBL.Model.Task>(db.Database.SqlQuery<CrmBL.Model.Task>("SELECT * FROM Task WHERE DepartmentName ='Design'"));
        }

        private void listOfEmployeesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var rosterDevelopTodo = new Roster<CrmBL.Model.Employee>(db.Database.SqlQuery<CrmBL.Model.Employee>("SELECT * FROM Employee WHERE DepartmentName ='Design'"));
        }

        private void soonDeadlineToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Design soon deadline
        }
    }
}
