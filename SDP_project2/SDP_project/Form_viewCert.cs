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
    public partial class Form_viewCert : Form
    {
        public Form_viewCert()
        {
            InitializeComponent();
        }
        public class cert
        {
            public static string marathon_Name, fname, lname,eventName,gender;
            public static int runnerID,raceTime;
            
        }
        private void Form_checkResult_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            using(var db = new marathonskills2017Entities1())
            {
                var sponsor = from a in db.runner
                              join aa in db.user on a.Email equals aa.Email
                              join b in db.registrationevent on a.RunnerId equals b.runnerID
                              join c in db.@event on b.EventId equals c.EventId
                              join d in db.marathon on c.MarathonId equals d.MarathonId
                              where a.Email.Equals(Form_login.UserEmail.Email)
                              select d;
                foreach (var result in sponsor.ToList())
                {
                    comboBox1.Items.Add(result.MarathonName);
                }
                
            }
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

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Form_runner_profile pro = new Form_runner_profile();
            pro.Show();
            this.Close();
        }

        private void btn_BMI_BMR_Click(object sender, EventArgs e)
        {
            Form_BMI_BMR bmi = new Form_BMI_BMR();
            bmi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_runner_join join = new Form_runner_join();
            join.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new marathonskills2017Entities1())
            {
                string name1 = comboBox1.SelectedItem.ToString();
                
                    Form_viewCert.cert.marathon_Name = comboBox1.SelectedItem.ToString();
               
                var name = from a in db.user

                           where a.Email.Equals(Form_login.UserEmail.Email)
                           select a;
                foreach (var rs in name.ToList())
                {
                    Form_viewCert.cert.fname = rs.FirstName;
                    Form_viewCert.cert.lname = rs.LastName;
                    
                }
                var regis = from a in db.runner
                            join aa in db.user on a.Email equals aa.Email
                            join b in db.registrationevent on a.RunnerId equals b.runnerID
                            where a.Email.Equals(Form_login.UserEmail.Email)
                            select b;
                foreach (var rs1 in regis.ToList())
                {
                    Form_viewCert.cert.runnerID = rs1.runnerID;
                    Form_viewCert.cert.raceTime = Convert.ToInt16(rs1.RaceTime);
                }
                var Event = from a in db.runner
                            join aa in db.user on a.Email equals aa.Email
                            join b in db.registrationevent on a.RunnerId equals b.runnerID
                            join c in db.@event on b.EventId equals c.EventId
                            where a.Email.Equals(Form_login.UserEmail.Email)
                            select c;
                foreach (var rs in Event.ToList())
                {
                    Form_viewCert.cert.eventName = rs.EventName;
                }
                Form_cert cert = new Form_cert();
                cert.Show();
                var runner = from a in db.runner

                           where a.Email.Equals(Form_login.UserEmail.Email)
                           select a;
                foreach (var rs in runner.ToList())
                {
                    Form_viewCert.cert.gender = rs.Gender;

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_login.UserEmail.Email = "";
            Form_login.RunnerID.runnerID = 0;
            Form_home home = new Form_home();
            home.Show();
            this.Close();
        }

        private void btn_profile_Click_1(object sender, EventArgs e)
        {
            Form_runner_profile profile = new Form_runner_profile();
            profile.Show();
            this.Hide();
        }

        private void btn_BMI_BMR_Click_1(object sender, EventArgs e)
        {
            Form_BMI_BMR bmi = new Form_BMI_BMR();
            bmi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var db = new marathonskills2017Entities1())
            {
                var resultSet1 = from list in db.runner
                                 where list.Email.Equals(Form_login.UserEmail.Email)
                                 select list;
                if (resultSet1.Any(re => re.registrationstatus == "Payment Confirmed"))
                {
                    MessageBox.Show("you have already join the event");
                    return;
                }
            }
            Form_runner_join join = new Form_runner_join();
            join.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void btn_info_Click_1(object sender, EventArgs e)
        {
            Form_eventInfo info = new Form_eventInfo();
            info.Show();
        }

        private void btn_charity_Click_1(object sender, EventArgs e)
        {
            Form_charity cha = new Form_charity();
            cha.Show();
        }
    }
}
