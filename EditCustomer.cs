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
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataBaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.gymDataBaseDataSet.Customer);

        }
        GymDataBaseDataSetTableAdapters.CustomerTableAdapter c = new GymDataBaseDataSetTableAdapters.CustomerTableAdapter();
        GymDataBaseDataSetTableAdapters.RegistratoinTableAdapter r = new GymDataBaseDataSetTableAdapters.RegistratoinTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            
            c.EditCustomerNQuery(nametextBox.Text, (int)namecomboBox.SelectedValue);
            r.EditCustomerNQuery(nametextBox.Text, (int)namecomboBox.SelectedValue);
            this.customerTableAdapter.Fill(this.gymDataBaseDataSet.Customer);
            namecomboBox.ResetText();
            nametextBox.Text = "";
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a') && (e.KeyChar <= 'z') || (e.KeyChar >= 'A') && (e.KeyChar <= 'Z') || (e.KeyChar == 8)))
                    e.KeyChar = '\0';
        }
    }
}
