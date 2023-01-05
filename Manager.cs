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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Employees s = new Employees();
            s.MdiParent = this;
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee s = new AddEmployee();
            s.MdiParent = this;
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditEmployee s = new EditEmployee();
            s.MdiParent = this;
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteEmployee s = new DeleteEmployee();
            s.MdiParent = this;
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddCoaches s = new AddCoaches();
            s.MdiParent = this;
            s.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EditCoach s = new EditCoach();
            s.MdiParent = this;
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Coaches s = new Coaches();
            s.MdiParent = this;
            s.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DeleteCoach s = new DeleteCoach();
            s.MdiParent = this;
            s.Show();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
