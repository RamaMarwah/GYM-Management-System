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
    public partial class Coach : Form
    {
        public Coach()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoachCustomers w = new CoachCustomers();
            w.MdiParent = this;
            w.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditCInformation w = new EditCInformation();
            w.MdiParent = this;
            w.Show();
        }

        private void Coach_Load(object sender, EventArgs e)
        {

        }
    }
}
