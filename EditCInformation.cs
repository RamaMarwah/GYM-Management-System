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
    public partial class EditCInformation : Form
    {
        public EditCInformation()
        {
            InitializeComponent();
        }

        private void EditCInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataBaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.gymDataBaseDataSet.Customer);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GymDataBaseDataSetTableAdapters.CustomerTableAdapter c = new GymDataBaseDataSetTableAdapters.CustomerTableAdapter();

            string selected = editcomboBox.SelectedItem.ToString();
            if (selected == "Edit Weight")
            {
                c.UpdateWeightQuery(int.Parse(editedtextBox.Text), (int)namecomboBox.SelectedValue);
            }
            else if (selected == "Edit Preganent")
            {  if(editedtextBox.Text=="yes")
                c.UpdatePreganentQuery(true, (int)namecomboBox.SelectedValue);
            else if(editedtextBox.Text=="no")
                c.UpdatePreganentQuery(false, (int)namecomboBox.SelectedValue);

            }
            namecomboBox.ResetText();
            editcomboBox.ResetText();
            editedtextBox.Text="";

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void editcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = editcomboBox.SelectedItem.ToString();
            if (selected == "Edit Preganent")
                MessageBox.Show("Please type ->yes<- if preganent and ->no<- if not ");

        }
    }
}
