using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tellerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCurr.Text != "")
            {

                try
                {

                    if (comBoxCurr.SelectedIndex == 0)
                    {
                        double curr = Convert.ToDouble(txtCurr.Text) / 81;
                        txtBox_ch.Text = curr.ToString();
                        //Math.Round(Convert.ToDouble(txtBox_ch.Text));
                        lab_ch.Visible = true;
                        lab_ch.Text = "USD";

                    }
                    else if (comBoxCurr.SelectedIndex == 1)
                    {
                        double curr = Convert.ToDouble(txtCurr.Text) / 84;
                        txtBox_ch.Text = curr.ToString();
                        Math.Round(Convert.ToDouble(txtBox_ch.Text));
                        lab_ch.Visible = true;
                        lab_ch.Text = "EURO";
                    }
                    else if (comBoxCurr.SelectedIndex == 2)
                    {
                        double curr = Convert.ToDouble(txtCurr.Text) / 0.50;
                        txtBox_ch.Text = curr.ToString();
                        Math.Round(Convert.ToDouble(txtBox_ch.Text));
                        lab_ch.Visible = true;
                        lab_ch.Text = "Pak";
                    }

                }

                catch
                {

                    MessageBox.Show("Please type currency only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBox_ch.ReadOnly = true;
            comBoxCurr.Text = "Select Currency";
            //comBoxCurr.Items.Add("Select Currency");
            comBoxCurr.Items.Add("USD");
            comBoxCurr.Items.Add("Eur");
            comBoxCurr.Items.Add("Pak");
            lab_ch.Visible = false;
          
        }

    

       
    }
}
