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
    public partial class HomePage : Form
    {
 
        public HomePage()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            SignInForm S = new SignInForm();
            S.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("ARE YOU SURE !! YOU WANT TO EXIT ", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
                Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Gym_Pictures g = new Gym_Pictures();
            g.Show();
        }
    }
}
