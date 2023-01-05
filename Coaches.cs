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
    public partial class Coaches : Form
    {
        public Coaches()
        {
            InitializeComponent();
        }

        private void Coaches_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataBaseDataSet.Coach' table. You can move, or remove it, as needed.
            this.coachTableAdapter.Fill(this.gymDataBaseDataSet.Coach);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.coachTableAdapter.Fill(this.gymDataBaseDataSet.Coach);

        }
    }
}
