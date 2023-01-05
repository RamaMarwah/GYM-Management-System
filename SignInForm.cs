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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }
        
        GymDataBaseDataSetTableAdapters.CoachTableAdapter c = new GymDataBaseDataSetTableAdapters.CoachTableAdapter();
        GymDataBaseDataSetTableAdapters.EmployeeTableAdapter p = new GymDataBaseDataSetTableAdapters.EmployeeTableAdapter();
        GymDataBaseDataSetTableAdapters.ManagerTableAdapter m = new GymDataBaseDataSetTableAdapters.ManagerTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == c.CoachPassQuery(textBox1.Text).ToString())
            {
                Coach y = new Coach();
                y.ShowDialog();
            }
            else if (textBox2.Text == p.EmployeePassQuery(textBox1.Text).ToString())
            {
                int x = (int)p.GetEmpIDQuery(textBox1.Text);
                Employee y = new Employee(x);
                y.ShowDialog();

            }
            else if (textBox2.Text == m.ManagerPassQuery(textBox1.Text).ToString())
            {
                Manager y = new Manager();
                y.ShowDialog();
            }
            else
                MessageBox.Show("PLEASE CHECK YOUR USER NAME OR PASSWORD AND TRY AGAIN");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
