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
    public partial class NewRegistratoin : Form
    {
        public NewRegistratoin()
        {
            InitializeComponent();
        }

        int day = 50;
        int week = 300;
        int month = 1500;
        int year = 6000;
        private decimal payment()
        {
            string selected = typecomboBox.SelectedItem.ToString();
            if (selected == "DAILY")
            {
                paymenttextBox.Text = (decimal.Parse(durationtextBox.Text) * day).ToString();
                return decimal.Parse(paymenttextBox.Text);
            }
            else if (selected == "WEEKLY")
            {
                paymenttextBox.Text = (decimal.Parse(durationtextBox.Text) * week).ToString();
                return decimal.Parse(paymenttextBox.Text);
            }
            else if (selected == "MONTHLY")
            {
                paymenttextBox.Text = (decimal.Parse(durationtextBox.Text) * month).ToString();
                return decimal.Parse(paymenttextBox.Text);
            }
            else if (selected == "YEARLY")
            {
                paymenttextBox.Text = (decimal.Parse(durationtextBox.Text) * year).ToString();
                return decimal.Parse(paymenttextBox.Text);
            }
            else
                return decimal.Parse(paymenttextBox.Text);
        }
        private void NewRegistratoin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataBaseDataSet.Coach' table. You can move, or remove it, as needed.
            this.coachTableAdapter.Fill(this.gymDataBaseDataSet.Coach);
            // TODO: This line of code loads data into the 'gymDataBaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.gymDataBaseDataSet.Customer);
        }
        GymDataBaseDataSetTableAdapters.RegistratoinTableAdapter xr = new GymDataBaseDataSetTableAdapters.RegistratoinTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
         
            xr.Insert(int.Parse(durationtextBox.Text), typecomboBox.Text, namecomboBox.Text,
               (int)namecomboBox.SelectedValue, payment(),(int)coachcomboBox.SelectedValue);
            durationtextBox.Text = "";
            typecomboBox.Text = "";
            namecomboBox.Text  = "";
            namecomboBox.ResetText();
            coachcomboBox.ResetText();
            paymenttextBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paymenttextBox.Text = payment().ToString();
        }
    }
}
