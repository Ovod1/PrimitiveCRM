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
            
                //var comps = db.Database.SqlQuery<CrmBL.Model.Task>("SELECT * FROM Companies");
                var rosterDevelopTodo = new Roster<CrmBL.Model.Task>(db.Tasks);
                rosterDevelopTodo.Show();
           

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
    }
}
