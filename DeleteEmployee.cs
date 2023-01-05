using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_project_safa_rama
{
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataBaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.gymDataBaseDataSet.Employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GymDataBaseDataSetTableAdapters.EmployeeTableAdapter c = new GymDataBaseDataSetTableAdapters.EmployeeTableAdapter();
            c.DeleteEmployeeQuery((int)namecomboBox.SelectedValue);
            namecomboBox.ResetText();
            this.employeeTableAdapter.Fill(this.gymDataBaseDataSet.Employee);
        }
    }
}
