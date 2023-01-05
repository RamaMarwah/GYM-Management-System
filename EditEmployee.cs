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
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataBaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.gymDataBaseDataSet.Employee);

        }

        private void EditEmployee_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataBaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.gymDataBaseDataSet.Employee);

        }
        GymDataBaseDataSetTableAdapters.EmployeeTableAdapter xe = new GymDataBaseDataSetTableAdapters.EmployeeTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            string selected = editcomboBox.SelectedItem.ToString();
            if (selected == "Edit Name")
            {
                xe.UpdateEmployeeNQuery(editedtextBox.Text, (int)empcomboBox.SelectedValue);

            }
            else if (selected == "Edit Salary")
            {
                xe.UpdateSalaryQuery(decimal.Parse(editedtextBox.Text), (int)empcomboBox.SelectedValue);
            }
            else if (selected == "Edit Password")
            {
                xe.UpdatePassQuery(int.Parse(editedtextBox.Text), (int)empcomboBox.SelectedValue);
            }
            editcomboBox.ResetText();
            editedtextBox.Text = "";
            empcomboBox.ResetText();
        }

        private void editedtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void editedtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string selected = editcomboBox.SelectedItem.ToString();
            if (selected == "Edit Name")
            {
                if (!((e.KeyChar >= 'a') && (e.KeyChar <= 'z') || (e.KeyChar >= 'A') && (e.KeyChar <= 'Z')))
                    e.KeyChar = '\0';
            }
            else if (selected == "Edit Salary")
            {
                if (!((e.KeyChar >= '0') && (e.KeyChar <= '9')))
                    e.KeyChar = '\0';
            }
            else if (selected == "Edit Password")
            {
                if (!((e.KeyChar >= '0') && (e.KeyChar <= '9')))
                    e.KeyChar = '\0';
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
             string selected = editcomboBox.SelectedItem.ToString();
            if (selected == "Edit Name")
            {
             if(!((e.KeyChar>='a')&&(e.KeyChar<='z')||(e.KeyChar>='A')&&(e.KeyChar<='Z')||(e.KeyChar==8)))
                 e.KeyChar='\0';
            }
            else if (selected == "Edit Salary")
            {
                if (!((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == 8)))
                    e.KeyChar = '\0';
            }
            else if (selected == "Edit Password")
            {
                if (!((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == 8)))
                    e.KeyChar = '\0';
            
            }

        }

        private void empcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }

}

