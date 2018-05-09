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
    public partial class Form_countryCode : Form
    {
        public Form_countryCode()
        {
            InitializeComponent();
        }

        private void Form_countryCode_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new marathonskills2017Entities1())
                {
                    var emp = (from country in db.country
                               select country);
                    foreach (var emp2 in emp.ToList())
                    {
                        Bitmap img;
                        var path = Image.FromFile(Application.StartupPath + "\\flags\\" + emp2.CountryFlag);
                        img = new Bitmap(path);
                        dataGridView1.Rows.Add(emp2.CountryCode, emp2.CountryName, img);
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
