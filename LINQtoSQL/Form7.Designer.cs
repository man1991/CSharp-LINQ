namespace LINQtoSQL
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOrderBySalaryAsc = new System.Windows.Forms.Button();
            this.buttonOrderByEnameDesc = new System.Windows.Forms.Button();
            this.buttonGetSelectedColumns = new System.Windows.Forms.Button();
            this.buttonEmpCountGroupByDeptNo = new System.Windows.Forms.Button();
            this.buttonEmpCountGroupByJob = new System.Windows.Forms.Button();
            this.buttonEmpCountGroupByDeptNoGreaterThanFive = new System.Windows.Forms.Button();
            this.buttonEmpCountGroupByJobLessThanFive = new System.Windows.Forms.Button();
            this.buttonMultipleClausesInAQuery = new System.Windows.Forms.Button();
            this.buttonMaxSalaryGroupByDept = new System.Windows.Forms.Button();
            this.buttonMinSalaryGroupByJob = new System.Windows.Forms.Button();
            this.buttonUniqueListOfJob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(444, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 453);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonOrderBySalaryAsc
            // 
            this.buttonOrderBySalaryAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderBySalaryAsc.Location = new System.Drawing.Point(786, 75);
            this.buttonOrderBySalaryAsc.Name = "buttonOrderBySalaryAsc";
            this.buttonOrderBySalaryAsc.Size = new System.Drawing.Size(219, 23);
            this.buttonOrderBySalaryAsc.TabIndex = 2;
            this.buttonOrderBySalaryAsc.Text = "Order By Salary Asc.";
            this.buttonOrderBySalaryAsc.UseVisualStyleBackColor = true;
            this.buttonOrderBySalaryAsc.Click += new System.EventHandler(this.buttonOrderBySalaryAsc_Click);
            // 
            // buttonOrderByEnameDesc
            // 
            this.buttonOrderByEnameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderByEnameDesc.Location = new System.Drawing.Point(786, 104);
            this.buttonOrderByEnameDesc.Name = "buttonOrderByEnameDesc";
            this.buttonOrderByEnameDesc.Size = new System.Drawing.Size(219, 23);
            this.buttonOrderByEnameDesc.TabIndex = 3;
            this.buttonOrderByEnameDesc.Text = "Order By Ename Desc.";
            this.buttonOrderByEnameDesc.UseVisualStyleBackColor = true;
            this.buttonOrderByEnameDesc.Click += new System.EventHandler(this.buttonOrderByEnameDesc_Click);
            // 
            // buttonGetSelectedColumns
            // 
            this.buttonGetSelectedColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetSelectedColumns.Location = new System.Drawing.Point(786, 133);
            this.buttonGetSelectedColumns.Name = "buttonGetSelectedColumns";
            this.buttonGetSelectedColumns.Size = new System.Drawing.Size(219, 24);
            this.buttonGetSelectedColumns.TabIndex = 4;
            this.buttonGetSelectedColumns.Text = "Get Selected Columns";
            this.buttonGetSelectedColumns.UseVisualStyleBackColor = true;
            this.buttonGetSelectedColumns.Click += new System.EventHandler(this.buttonGetSelectedColumns_Click);
            // 
            // buttonEmpCountGroupByDeptNo
            // 
            this.buttonEmpCountGroupByDeptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpCountGroupByDeptNo.Location = new System.Drawing.Point(786, 163);
            this.buttonEmpCountGroupByDeptNo.Name = "buttonEmpCountGroupByDeptNo";
            this.buttonEmpCountGroupByDeptNo.Size = new System.Drawing.Size(219, 30);
            this.buttonEmpCountGroupByDeptNo.TabIndex = 5;
            this.buttonEmpCountGroupByDeptNo.Text = "Emp Count Group By Dept No";
            this.buttonEmpCountGroupByDeptNo.UseVisualStyleBackColor = true;
            this.buttonEmpCountGroupByDeptNo.Click += new System.EventHandler(this.buttonEmpCountGroupByDeptNo_Click);
            // 
            // buttonEmpCountGroupByJob
            // 
            this.buttonEmpCountGroupByJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpCountGroupByJob.Location = new System.Drawing.Point(786, 199);
            this.buttonEmpCountGroupByJob.Name = "buttonEmpCountGroupByJob";
            this.buttonEmpCountGroupByJob.Size = new System.Drawing.Size(219, 30);
            this.buttonEmpCountGroupByJob.TabIndex = 6;
            this.buttonEmpCountGroupByJob.Text = "Emp Count Group By Job";
            this.buttonEmpCountGroupByJob.UseVisualStyleBackColor = true;
            this.buttonEmpCountGroupByJob.Click += new System.EventHandler(this.buttonEmpCountGroupByJob_Click);
            // 
            // buttonEmpCountGroupByDeptNoGreaterThanFive
            // 
            this.buttonEmpCountGroupByDeptNoGreaterThanFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpCountGroupByDeptNoGreaterThanFive.Location = new System.Drawing.Point(786, 235);
            this.buttonEmpCountGroupByDeptNoGreaterThanFive.Name = "buttonEmpCountGroupByDeptNoGreaterThanFive";
            this.buttonEmpCountGroupByDeptNoGreaterThanFive.Size = new System.Drawing.Size(219, 41);
            this.buttonEmpCountGroupByDeptNoGreaterThanFive.TabIndex = 7;
            this.buttonEmpCountGroupByDeptNoGreaterThanFive.Text = "Emp Count Group By Dept No > 5";
            this.buttonEmpCountGroupByDeptNoGreaterThanFive.UseVisualStyleBackColor = true;
            this.buttonEmpCountGroupByDeptNoGreaterThanFive.Click += new System.EventHandler(this.buttonEmpCountGroupByDeptNoGreaterThanFive_Click);
            // 
            // buttonEmpCountGroupByJobLessThanFive
            // 
            this.buttonEmpCountGroupByJobLessThanFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpCountGroupByJobLessThanFive.Location = new System.Drawing.Point(786, 282);
            this.buttonEmpCountGroupByJobLessThanFive.Name = "buttonEmpCountGroupByJobLessThanFive";
            this.buttonEmpCountGroupByJobLessThanFive.Size = new System.Drawing.Size(219, 30);
            this.buttonEmpCountGroupByJobLessThanFive.TabIndex = 8;
            this.buttonEmpCountGroupByJobLessThanFive.Text = "Emp Count Group By Job < 5";
            this.buttonEmpCountGroupByJobLessThanFive.UseVisualStyleBackColor = true;
            this.buttonEmpCountGroupByJobLessThanFive.Click += new System.EventHandler(this.buttonEmpCountGroupByJobLessThanFive_Click);
            // 
            // buttonMultipleClausesInAQuery
            // 
            this.buttonMultipleClausesInAQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultipleClausesInAQuery.Location = new System.Drawing.Point(786, 318);
            this.buttonMultipleClausesInAQuery.Name = "buttonMultipleClausesInAQuery";
            this.buttonMultipleClausesInAQuery.Size = new System.Drawing.Size(219, 30);
            this.buttonMultipleClausesInAQuery.TabIndex = 9;
            this.buttonMultipleClausesInAQuery.Text = "Multiple Clauses In A Query";
            this.buttonMultipleClausesInAQuery.UseVisualStyleBackColor = true;
            this.buttonMultipleClausesInAQuery.Click += new System.EventHandler(this.buttonMultipleClausesInAQuery_Click);
            // 
            // buttonMaxSalaryGroupByDept
            // 
            this.buttonMaxSalaryGroupByDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaxSalaryGroupByDept.Location = new System.Drawing.Point(786, 354);
            this.buttonMaxSalaryGroupByDept.Name = "buttonMaxSalaryGroupByDept";
            this.buttonMaxSalaryGroupByDept.Size = new System.Drawing.Size(219, 30);
            this.buttonMaxSalaryGroupByDept.TabIndex = 10;
            this.buttonMaxSalaryGroupByDept.Text = "Max Salary Group By Dept";
            this.buttonMaxSalaryGroupByDept.UseVisualStyleBackColor = true;
            this.buttonMaxSalaryGroupByDept.Click += new System.EventHandler(this.buttonMaxSalaryGroupByDept_Click);
            // 
            // buttonMinSalaryGroupByJob
            // 
            this.buttonMinSalaryGroupByJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinSalaryGroupByJob.Location = new System.Drawing.Point(786, 390);
            this.buttonMinSalaryGroupByJob.Name = "buttonMinSalaryGroupByJob";
            this.buttonMinSalaryGroupByJob.Size = new System.Drawing.Size(219, 30);
            this.buttonMinSalaryGroupByJob.TabIndex = 11;
            this.buttonMinSalaryGroupByJob.Text = "Min Salary Group By Job";
            this.buttonMinSalaryGroupByJob.UseVisualStyleBackColor = true;
            this.buttonMinSalaryGroupByJob.Click += new System.EventHandler(this.buttonMinSalaryGroupByJob_Click);
            // 
            // buttonUniqueListOfJob
            // 
            this.buttonUniqueListOfJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUniqueListOfJob.Location = new System.Drawing.Point(786, 426);
            this.buttonUniqueListOfJob.Name = "buttonUniqueListOfJob";
            this.buttonUniqueListOfJob.Size = new System.Drawing.Size(219, 30);
            this.buttonUniqueListOfJob.TabIndex = 12;
            this.buttonUniqueListOfJob.Text = "Unique List Of Job";
            this.buttonUniqueListOfJob.UseVisualStyleBackColor = true;
            this.buttonUniqueListOfJob.Click += new System.EventHandler(this.buttonUniqueListOfJob_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1008, 514);
            this.Controls.Add(this.buttonUniqueListOfJob);
            this.Controls.Add(this.buttonMinSalaryGroupByJob);
            this.Controls.Add(this.buttonMaxSalaryGroupByDept);
            this.Controls.Add(this.buttonMultipleClausesInAQuery);
            this.Controls.Add(this.buttonEmpCountGroupByJobLessThanFive);
            this.Controls.Add(this.buttonEmpCountGroupByDeptNoGreaterThanFive);
            this.Controls.Add(this.buttonEmpCountGroupByJob);
            this.Controls.Add(this.buttonEmpCountGroupByDeptNo);
            this.Controls.Add(this.buttonGetSelectedColumns);
            this.Controls.Add(this.buttonOrderByEnameDesc);
            this.Controls.Add(this.buttonOrderBySalaryAsc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOrderBySalaryAsc;
        private System.Windows.Forms.Button buttonOrderByEnameDesc;
        private System.Windows.Forms.Button buttonGetSelectedColumns;
        private System.Windows.Forms.Button buttonEmpCountGroupByDeptNo;
        private System.Windows.Forms.Button buttonEmpCountGroupByJob;
        private System.Windows.Forms.Button buttonEmpCountGroupByDeptNoGreaterThanFive;
        private System.Windows.Forms.Button buttonEmpCountGroupByJobLessThanFive;
        private System.Windows.Forms.Button buttonMultipleClausesInAQuery;
        private System.Windows.Forms.Button buttonMaxSalaryGroupByDept;
        private System.Windows.Forms.Button buttonMinSalaryGroupByJob;
        private System.Windows.Forms.Button buttonUniqueListOfJob;
    }
}