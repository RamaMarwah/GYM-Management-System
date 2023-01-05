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
    
    public partial class AddCustomer : Form
    {int id;
        public AddCustomer(int x )
        {
            id = x;
            InitializeComponent();
        }
       
     
        GymDataBaseDataSetTableAdapters.EmployeeTableAdapter p = new GymDataBaseDataSetTableAdapters.EmployeeTableAdapter();
        GymDataBaseDataSetTableAdapters.CustomerTableAdapter xc = new GymDataBaseDataSetTableAdapters.CustomerTableAdapter();
        private void durationtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        
        private void AddCustomer_Load(object sender, EventArgs e)
        {
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            xc.Insert(nametextBox.Text, int.Parse(agetextBox.Text), int.Parse(weighttextBox.Text),
                heartcheckBox.Checked, breathingcheckBox.Checked, preganentcheckBox.Checked, id);
        nametextBox.Text = "";
        agetextBox.Text = "";
        weighttextBox.Text = "";
        heartcheckBox.Checked = false;
        breathingcheckBox.Checked = false;
        preganentcheckBox.Checked = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        }
    }

