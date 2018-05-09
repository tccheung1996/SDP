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
    public partial class Form_Edit_marathon : Form
    {
        public Form_Edit_marathon()
        {
            InitializeComponent();
        }

        private void Form_Edit_marathon_Load(object sender, EventArgs e)
        {
            try
            {
                sbyte id = Convert.ToSByte(Form_Admin_marathon.EditMarathon.id);
                using (var db = new marathonskills2017Entities1())
                {
                    var con = (from country in db.country
                               select country);
                    foreach (var con2 in con.ToList())
                    {
                        comboBox1.Items.Add(con2.CountryCode);
                    }
                    var resultSet = (from list in db.marathon
                                     where list.MarathonId.Equals(id)
                                     select list);
                    foreach (var mara in resultSet.ToList())
                    {
                        txt_name.Text = mara.MarathonName;
                        txt_city.Text = mara.CityName;
                        txt_year.Text = Convert.ToString(mara.YearHeld);
                        comboBox1.Text = mara.CountryCode;

                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Something wrong");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sbyte id = Convert.ToSByte(Form_Admin_marathon.EditMarathon.id);
                using (var db = new marathonskills2017Entities1())
                {
                    var resultSet = from list in db.marathon
                                    where list.MarathonId.Equals(id)
                                    select list;
                    foreach (var mara in resultSet.ToList())
                    {
                        mara.MarathonName = txt_name.Text;
                        mara.CityName = txt_city.Text;
                        mara.CountryCode = comboBox1.Text;
                        mara.YearHeld = Convert.ToInt16(txt_year.Text);
                    }
                    db.SaveChanges();
                    MessageBox.Show("Edited");
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Something wrong");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
