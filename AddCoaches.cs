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
    public partial class AddCoaches : Form
    {
        public AddCoaches()
        {
            InitializeComponent();
        }
        GymDataBaseDataSetTableAdapters.CoachTableAdapter xc = new GymDataBaseDataSetTableAdapters.CoachTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            xc.Insert(nametextBox.Text, comboBox1.Text, decimal.Parse(salarytextBox.Text),int.Parse(passtextBox.Text),1);
            nametextBox.Text = "";
            comboBox1.ResetText();
            salarytextBox.Text = "";
            passtextBox.Text = "";
        }

        private void AddCoaches_Load(object sender, EventArgs e)
        {

        }
    }
}
