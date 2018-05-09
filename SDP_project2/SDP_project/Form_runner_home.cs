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
    public partial class Form_runner_home : Form
    {
        public Form_runner_home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new marathonskills2017Entities1())
            {
                var resultSet1 = from list in db.runner
                                 where list.Email.Equals(Form_login.UserEmail.Email)
                                 select list;
                if(resultSet1.Any(re => re.registrationstatus == "Payment Confirmed"))
                {
                    MessageBox.Show("you have already join the event");
                    return;
                }
            }
            Form_runner_join join = new Form_runner_join();
            join.Show();
            this.Hide();
        }

        private void Form_runner_home_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri(Application.StartupPath + "\\Marathon\\drive-download-20170624T072759Z-001\\index.html"));
            String firstName = "";
            String lastName = "";
            using (var db = new marathonskills2017Entities1())
            {
                var resultSet = from list in db.user
                                where list.Email.Equals(Form_login.UserEmail.Email)
                                select list;
                foreach (var user in resultSet.ToList())
                {
                    firstName = user.FirstName;
                    lastName = user.LastName;
                }

            }
            label1.Text = label1.Text + firstName + " " + lastName;
            

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Form_runner_profile profile = new Form_runner_profile();
            profile.Show();
            this.Hide();
        }

        private void btn_BMI_BMR_Click(object sender, EventArgs e)
        {
            Form_BMI_BMR bmi = new Form_BMI_BMR();
            bmi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_runner_checkResult check = new Form_runner_checkResult();
            using (var db = new marathonskills2017Entities1())
            {
                if (db.registrationevent.Any(id => id.runnerID == Form_login.RunnerID.runnerID))
                {
                    check.Show();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("you do not have any running result");
                    return;
                }
                    
            }
                
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Form_eventInfo info = new Form_eventInfo();
            info.Show();
        }

        private void btn_charity_Click(object sender, EventArgs e)
        {
            Form_charity cha = new Form_charity();
            cha.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_login.UserEmail.Email = "";
            Form_login.RunnerID.runnerID = 0;
            Form_home home = new Form_home();
            home.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_viewCert cert = new Form_viewCert();
            cert.Show();
            this.Close();
        }
    }
}
