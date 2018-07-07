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
    public partial class Form7 : Form
    {
        TestDBDataContext dc;
        bool flag = false;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dc = new TestDBDataContext();
            //var tab = from E in dc.Emps select E;
            //dataGridView1.DataSource = tab;
            //OR
            dataGridView1.DataSource = from E in dc.Emps select E;//To retrieve all data
            var tab = from E in dc.Emps select new { E.Job };//To retrieve Job information 
            comboBox1.DataSource = tab.Distinct();//Binding only unique data to combobox using Distinct();
            comboBox1.DisplayMember = "Job";//To display exact data from "Job" column into combobox
            comboBox1.SelectedIndex = -1;//So that combobox doesn't selects item by default
            flag = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == true)
            {
                //Using LINQ: Query Operator
                //var q1 = dc.Emps.Where(c => c.Job == comboBox1.Text)
                //                .OrderBy(c => c.Ename);
                //dataGridView1.DataSource = q1;

                //Using LINQ: Query Keyword
                dataGridView1.DataSource = from E in dc.Emps
                                           where E.Job == comboBox1.Text
                                           select E;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Using Query Operator
            var q1 = dc.Emps.Where(c => c.Job.Contains(comboBox1.Text)).OrderBy(c => c.Ename);
            dataGridView1.DataSource = q1;

            //Using Query Keyword
            //dataGridView1.DataSource = from E in dc.Emps where E.Job.Contains(comboBox1.Text) select E;
        }

        private void buttonOrderBySalaryAsc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in dc.Emps orderby E.Sal select E;
        }

        private void buttonOrderByEnameDesc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in dc.Emps orderby E.Ename descending select E;
        }

        private void buttonGetSelectedColumns_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in dc.Emps select new { E.Empno, E.Ename, E.Job, Salary = E.Sal, E.Deptno };//To display selected columns and Salary is alias for Sal column
        }

        private void buttonEmpCountGroupByDeptNo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in dc.Emps group E by E.Deptno into G select new { DeptNo = G.Key, EmpCount = G.Count() };
        }

        private void buttonEmpCountGroupByJob_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in dc.Emps group E by E.Job into G select new { Job = G.Key, EmpCount = G.Count() };
        }

        private void buttonEmpCountGroupByDeptNoGreaterThanFive_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in dc.Emps group E by E.Deptno into G where G.Count() > 5 select new { DeptNo = G.Key, EmpCount = G.Count() };
        }

        private void buttonEmpCountGroupByJobLessThanFive_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in dc.Emps group E by E.Job into G where G.Count() < 5 select new { Job = G.Key, EmpCount = G.Count() };
        }

        private void buttonMultipleClausesInAQuery_Click(object sender, EventArgs e)
        {
            //Query to find out number of clerks working in each department
            dataGridView1.DataSource = from E in dc.Emps where E.Job == "Clerk" group E by E.Deptno into G where G.Count() > 1 orderby G.Key descending select new { Deptno = G.Key, ClerkCount = G.Count() };
        }

        private void buttonMaxSalaryGroupByDept_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in dc.Emps group E by E.Deptno into G select new { DeptNo = G.Key, MaxSalary = G.Max( E => E.Sal ) };
        }

        private void buttonMinSalaryGroupByJob_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in dc.Emps group E by E.Job into G select new { Job = G.Key, MaxSalary = G.Min( E => E.Sal ) };
        }

        private void buttonUniqueListOfJob_Click(object sender, EventArgs e)
        {
            var TransactionByCustomer = from c in dc.Customers
                                        join t in dc.Transactions
                                        on c.Custid equals t.Custid into tGroup
                                        select new
                                        {                                      
                                            Customer = c,
                                            Transaction = tGroup,                                            
                                        };
            dataGridView1.DataSource = TransactionByCustomer;
            //dataGridView1.DataSource = from E in dc.Emps orderby E.Job.Distinct() select E.Job;
            ////var q1 = dc.Emps.Select(c => c.Job).Distinct().OrderByDescending(s => s);
            ////dataGridView1.DataSource = q1;

            //var q1 = (from c in dc.Emps
            //          orderby c.Job
            //          select c.Job).Distinct();
            //dataGridView1.DataSource = q1;
        }
    }
}
