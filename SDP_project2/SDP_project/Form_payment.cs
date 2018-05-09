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
    public partial class Form_payment : Form
    {
        public Form_payment()
        {
            InitializeComponent();
        }
        public class payment
        {
            public static string registrationStatus = "Payment Confirmed";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>4 || textBox2.Text.Length > 4 || textBox3.Text.Length > 4 || textBox4.Text.Length > 4)
            {
                MessageBox.Show("Wrong number");
            }
            if (dateTimePicker1.Value > System.DateTime.Now)
            {
                MessageBox.Show("invaild date");
            }
            {

            }
            using (var db = new marathonskills2017Entities1())
            {
                
                var resultSet1 = from list in db.runner
                                 where list.Email.Contains(Form_login.UserEmail.Email)
                                 select list;
                foreach (var rsRunner in resultSet1.ToList())
                {
                    rsRunner.registrationstatus = payment.registrationStatus;
                }
                db.SaveChanges();
            }
            Form_runner_home home = new Form_runner_home();
            home.Show();
            this.Close();
        }

        private void btn_charity_Click(object sender, EventArgs e)
        {
            Form_charity cha = new Form_charity();
            cha.Show();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Form_eventInfo info = new Form_eventInfo();
            info.Show();
        }
    }
}
