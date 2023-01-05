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
    public partial class Employee : Form
    {
        int i;
        public Employee(int id)
        {
            
            InitializeComponent();
            i = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer a = new AddCustomer(i);
            a.MdiParent = this;
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers a = new Customers();
            a.MdiParent = this;
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registrations a = new Registrations();
            a.MdiParent = this;
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteCustomer a = new DeleteCustomer();
            a.MdiParent = this;
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditCustomer a = new EditCustomer();
            a.MdiParent = this;
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewRegistratoin a = new NewRegistratoin();
            a.MdiParent = this;
            a.Show();
        }
       
        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataBaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.gymDataBaseDataSet.Employee);

        }
    }
}
