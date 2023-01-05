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
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataBaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.gymDataBaseDataSet.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GymDataBaseDataSetTableAdapters.CustomerTableAdapter c = new GymDataBaseDataSetTableAdapters.CustomerTableAdapter();
            c.DeleteCustomerQuery((int)namecomboBox.SelectedValue);
            namecomboBox.ResetText();
            this.customerTableAdapter.Fill(this.gymDataBaseDataSet.Customer);
        }
    }
}
