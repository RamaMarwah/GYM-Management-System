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
    public partial class EditCoach : Form
    {
        public EditCoach()
        {
            InitializeComponent();
        }

        private void EditCoach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataBaseDataSet.Coach' table. You can move, or remove it, as needed.
            this.coachTableAdapter.Fill(this.gymDataBaseDataSet.Coach);

        }
 GymDataBaseDataSetTableAdapters.CoachTableAdapter co = new GymDataBaseDataSetTableAdapters.CoachTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            string selected = editcomboBox.SelectedItem.ToString();

            if (selected == "Edit Name")
            {
            co.UpdateNameCoQuery((editedtextBox.Text), (int)comboBox1.SelectedValue);
            this.coachTableAdapter.Fill(this.gymDataBaseDataSet.Coach);
            }
            else if (selected == "Edit Salary")
            {         
                co.UpdateSalaryQuery(decimal.Parse(editedtextBox.Text), (int)comboBox1.SelectedValue);
            }
            else if (selected == "Edit Password")
            {
            co.UpdatePassCoQuery(int.Parse(editedtextBox.Text), (int)comboBox1.SelectedValue);
            }
            comboBox1.ResetText();
            editcomboBox.ResetText();
            editedtextBox .Text = "";
        }

        private void editedtextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void editedtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
