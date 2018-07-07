using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQtoSQL
{
    public partial class Form2 : Form
    {
        TestDBDataContext dc;
        List<Employee> Emps;
        int rNo = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dc = new TestDBDataContext();
            Emps = dc.Employees.ToList();
            ShowData();
        }
        private void ShowData()
        {
            textBoxNo.Text = Emps[rNo].ID.ToString();
            textBoxName.Text = Emps[rNo].Name;
            textBoxCity.Text = Emps[rNo].City;
            textBoxAddress.Text = Emps[rNo].Address;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (rNo > 0)
            {
                rNo -= 1;
                ShowData();
            }
            else
                MessageBox.Show("First Record Of The Table");
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (rNo < Emps.Count - 1)
            {
                rNo += 1;
                ShowData();
            }
            else
                MessageBox.Show("Last record of the table");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   