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
    public partial class Form_charity : Form
    {
        public Form_charity()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;

        }

        private void Form_charity_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.RowTemplate.Height = 100;


                using (var db = new marathonskills2017Entities1())
                {
                    var resultset = (from charity in db.charity
                                     select charity);

                    foreach (var charity2 in resultset.ToList())
                    {

                        Bitmap img;
                        var path = Image.FromFile(Application.StartupPath + "\\charity\\" + charity2.CharityLogo);
                        img = new Bitmap(path);

                        dataGridView1.Rows.Add(charity2.CharityName, charity2.CharityDescription, img);


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
