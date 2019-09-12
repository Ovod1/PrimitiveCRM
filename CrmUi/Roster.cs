using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class Roster<T> : Form where T : class
    {

        public Roster(DbSet<T> set)
        {
            InitializeComponent();
            dataGridView.DataSource = set.Local.ToBindingList();
        }
        //public Roster(DbRawSqlQuery set)
        //{
        //    InitializeComponent();
        //    dataGridView.DataSource = set.Local.ToBindingList();
        //}


    }
}
