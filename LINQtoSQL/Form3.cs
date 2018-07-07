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
    public partial class Form3 : Form
    {
        TestDBDataContext dc;
        public Form3()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dc = new TestDBDataContext();
            dgView.DataSource = dc.Employees;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dgView.SelectedRows.Count > 0)
            {
                Form4 f4 = new Form4();
                f4.textBoxNo.ReadOnly = true;
                f4.buttonClear.Enabled = false;
                f4.buttonSave.Text = "Update";
                f4.textBoxNo.Text = dgView.SelectedRows[0].Cells[0].Value.ToString();
                f4.textBoxName.Text = dgView.SelectedRows[0].Cells[1].Value.ToString();
                f4.textBoxCity.Text = dgView.SelectedRows[0].Cells[2].Value.ToString();
                f4.textBoxAddress.Text = dgView.SelectedRows[0].Cells[3].Value.ToString();
                f4.ShowDialog();
                LoadData();
            }
            else
                MessageBox.Show("Please select record for updation.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dgView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure of deleting the selected row?", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int ENo = Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value);
                    Employee obj = dc.Employees.SingleOrDefault(E => E.ID == ENo);
                    dc.Employees.DeleteOnSubmit(obj);
                    dc.SubmitChanges();
                    LoadData();
                }
            }
            else
                MessageBox.Show("Please select record for deletion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
