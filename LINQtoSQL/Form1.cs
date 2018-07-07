using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQtoSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestDBDataContext dc = new TestDBDataContext();
            //dataGridView1.DataSource = dc.Employees;
            Table<Employee> tab = dc.Employees;
            dataGridView1.DataSource = tab;
        }
    }
}
