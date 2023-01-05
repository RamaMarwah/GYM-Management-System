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
    public partial class Registrations : Form
    {
        public Registrations()
        {
            InitializeComponent();
        }

        private void Registrations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataBaseDataSet.Registratoin' table. You can move, or remove it, as needed.
            this.registratoinTableAdapter.Fill(this.gymDataBaseDataSet.Registratoin);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.registratoinTableAdapter.Fill(this.gymDataBaseDataSet.Registratoin);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
