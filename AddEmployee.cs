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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        GymDataBaseDataSetTableAdapters.EmployeeTableAdapter xe = new GymDataBaseDataSetTableAdapters.EmployeeTableAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            xe.Insert(nametextBox.Text, decimal.Parse(salarytextBox.Text), int.Parse(passtextBox.Text), 1);
            nametextBox.Text = "";
            salarytextBox.Text = "";
            passtextBox.Text = "";
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
