using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_project
{
    public partial class Form_BMI_BMR : Form
    {
        public Form_BMI_BMR()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                double weight = 0, height = 0;
                double bmi;
                weight = Convert.ToDouble(txt_bmi_wg.Text);
                height = Convert.ToDouble(txt_bmi_hg.Text);
                if (weight <=0.0 || height <= 0.0)
                {
                    MessageBox.Show("Invaild index");
                    return;
                }
                if (txt_bmi_hg.Text == "" && txt_bmi_wg.Text == "")
                {
                    MessageBox.Show("Please input your weight and height");
                    return;
                }
                

                if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("please select the type of weight and height");
                }

                else if (comboBox1.SelectedItem == "KG" && comboBox2.SelectedItem == "CM") //KG CM
                {

                    height /= 100;
                    bmi = weight / (height * height);
                    txt_bmi.Text = Convert.ToString(Math.Round(bmi, 1));

                }
                else if (comboBox1.SelectedItem == "KG" && comboBox2.SelectedItem == "M") //KG M
                {
                    bmi = weight / (height * height);
                    txt_bmi.Text = Convert.ToString(Math.Round(bmi, 1));
                }
                else if (comboBox1.SelectedItem == "LB" && comboBox2.SelectedItem == "CM")// LB CM
                {
                    weight /= 2.2;
                    height /= 100;
                    bmi = weight / (height * height);
                    txt_bmi.Text = Convert.ToString(Math.Round(bmi, 1));
                }
                else if (comboBox1.SelectedItem == "LB" && comboBox2.SelectedItem == "M")// LB M
                {
                    weight /= 2.2;
                    bmi = weight / (height * height);
                    txt_bmi.Text = Convert.ToString(Math.Round(bmi, 1));
                }

            }
            catch (Exception ec)
            {
                MessageBox.Show("Something Wrong!!");
                return;
            }

        }

        private void Form_BMI_BMR_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("KG");
            comboBox1.Items.Add("LB");
            comboBox2.Items.Add("CM");
            comboBox2.Items.Add("M");

            cb_wg.Items.Add("KG");
            cb_wg.Items.Add("LB");
            cb_hg.Items.Add("CM");
            cb_hg.Items.Add("M");


        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                    double weight = Convert.ToDouble(txt_bmr_wg.Text);
                double height = Convert.ToDouble(txt_bmr_hg.Text);
                int age = Convert.ToInt32(txt_age.Text);
                if (weight <= 0 || height <= 0)
                {
                    MessageBox.Show("Invaild index");
                    return;
                }
                if (Convert.ToInt32(txt_age.Text) <=0)
                {
                    MessageBox.Show("Invaild age");
                    return;
                }
                if (rbMale.Checked == false && rbFemale.Checked == false)
                {
                    MessageBox.Show("Please select your gender");
                    return;
                }
                if (txt_bmr_hg.Text == "" && txt_bmr_wg.Text == "")
                {
                    MessageBox.Show("Please input your weight and height");
                    return;
                }

            
            
                if (rbMale.Checked && cb_hg.SelectedItem == "CM" && cb_wg.SelectedItem == "KG")
                {
                    txt_bmr.Text = Convert.ToString((weight * 13.7) + (5.0 * height) - (6.8 * age) + 66);
                }
                else if (rbMale.Checked && cb_hg.SelectedItem == "M" && cb_wg.SelectedItem == "KG")
                {
                    height *= 100;
                    txt_bmr.Text = Convert.ToString((weight * 13.7) + (5.0 * height) - (6.8 * age) + 66);
                }
                else if (rbMale.Checked && cb_hg.SelectedItem == "M" && cb_wg.SelectedItem == "LB")
                {
                    height *= 100;
                    weight /= 2.2;
                    txt_bmr.Text = Convert.ToString((weight * 13.7) + (5.0 * height) - (6.8 * age) + 66);
                }
                else if (rbMale.Checked && cb_hg.SelectedItem == "CM" && cb_wg.SelectedItem == "LB")
                {
                    weight /= 2.2;

                    txt_bmr.Text = Convert.ToString((weight * 13.7) + (5.0 * height) - (6.8 * age) + 66);
                }

                if (rbFemale.Checked && cb_hg.SelectedItem == "CM" && cb_wg.SelectedItem == "KG")
                {
                    txt_bmr.Text = Convert.ToString((weight * 9.6) + (1.8 * height) - (4.7 * age) + 655);
                }
                else if (rbFemale.Checked && cb_hg.SelectedItem == "M" && cb_wg.SelectedItem == "KG")
                {
                    height *= 100;
                    txt_bmr.Text = Convert.ToString((weight * 9.6) + (1.8 * height) - (4.7 * age) + 655);
                }
                else if (rbFemale.Checked && cb_hg.SelectedItem == "M" && cb_wg.SelectedItem == "LB")
                {
                    height *= 100;
                    weight /= 2.2;
                    txt_bmr.Text = Convert.ToString((weight * 9.6) + (1.8 * height) - (4.7 * age) + 655);
                }
                else if (rbFemale.Checked && cb_hg.SelectedItem == "CM" && cb_wg.SelectedItem == "LB")
                {
                    weight /= 2.2;
                    txt_bmr.Text = Convert.ToString((weight * 9.6) + (1.8 * height) - (4.7 * age) + 655);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Something Wrong!!");
            }
        }
    }
}
