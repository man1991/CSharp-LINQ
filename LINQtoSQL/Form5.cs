using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQtoSQL
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            TestDBDataContext dc = new TestDBDataContext();
            ISingleResult<GetEmployeesResult> tab = dc.GetEmployees("Godzilla");
            dataGridView1.DataSource = tab;
        }
    }
}
