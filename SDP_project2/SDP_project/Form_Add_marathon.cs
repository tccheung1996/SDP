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
    public partial class Form_Add_marathon : Form
    {
        public Form_Add_marathon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text == "" && txt_name.Text.Substring(0, 1) == " ")
                {
                    MessageBox.Show("Please input vaild name!");
                    return;
                }
                if (txt_city.Text == "" && txt_city.Text.Substring(0, 1) == " ")
                {
                    MessageBox.Show("Please input vaild city!");
                    return;
                }
                if (txt_year.Text == "" && txt_year.Text.Substring(0, 1) == " ")
                {
                    MessageBox.Show("Please input vaild year!");
                    return;
                }
                if (comboBox1.SelectedItem == "")
                {
                    MessageBox.Show("Please select the country code");
                    return;
                }
                using (var db = new marathonskills2017Entities1())
                {
                    db.marathon.Add(new marathon()
                    {
                        MarathonName = txt_name.Text,
                        CityName = txt_city.Text,
                        CountryCode = comboBox1.SelectedItem.ToString(),
                        YearHeld = Convert.ToInt16(txt_year.Text)
                    });
                    db.SaveChanges();
                    MessageBox.Show("Marathon added");
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Something wrong");
                return;
            }
        }

        private void Form_Add_marathon_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new marathonskills2017Entities1())
                {
                    var con = (from country in db.country
                               select country);
                    foreach (var con2 in con.ToList())
                    {
                        comboBox1.Items.Add(con2.CountryCode);
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Something wrong");
                return;
            }
        }
    }
}
