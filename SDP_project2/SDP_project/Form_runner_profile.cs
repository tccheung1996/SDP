using System;
using System.Collections.Generic;
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
    public partial class Form_runner_profile : Form
    {
        public Form_runner_profile()
        {
            InitializeComponent();
        }

        private void Form_runner_profile_Load(object sender, EventArgs e)
        {
            this.txt_cpw.PasswordChar = '\u25cf';
            this.txt_npw.PasswordChar = '\u25cf';
            this.txt_npw2.PasswordChar = '\u25cf';
            
            using (var db = new marathonskills2017Entities1())
            {
                var resultSet = from list in db.user
                                where list.Email.Equals(Form_login.UserEmail.Email)
                                select list;
                foreach (var user in resultSet.ToList())
                {
                    txt_first_name.Text = user.FirstName;
                    txt_last_name.Text = user.LastName;
                }
                var resultSet1 = from list in db.runner
                                 where list.Email.Equals(Form_login.UserEmail.Email)
                                 select list;
                foreach (var rsRunner in resultSet1.ToList())
                {
                    txt_gender.Text = rsRunner.Gender;
                    if (rsRunner.DateOfBirth != null)
                        dtp_DOB.Value = Convert.ToDateTime(rsRunner.DateOfBirth);
                    txt_eventStatus.Text = rsRunner.registrationstatus;
                    txt_country.Text = rsRunner.CountryCode;
                }
                if (txt_eventStatus.Text == "Payment Confirmed")
                {
                    txt_country.Enabled = false;
                    txt_first_name.Enabled = false;
                    txt_last_name.Enabled = false;
                    txt_gender.Enabled = false;
                    dtp_DOB.Enabled = false;
                    dtp_DOB.Enabled = false;
                    dtp_DOB.Format = DateTimePickerFormat.Custom;
                    dtp_DOB.CustomFormat = " ";

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_eventStatus.Text == "Waiting for payment" && txt_eventStatus.Text =="Registered")
                {
                    Form_runner_home home = new Form_runner_home();
                    DialogResult dialogResult = MessageBox.Show("Do you want to edit your profile?", "Attention", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        using (var db = new marathonskills2017Entities1())
                        {
                            var resultSet = from list in db.user
                                            where list.Email.Equals(Form_login.UserEmail.Email)
                                            select list;
                            foreach (var user in resultSet.ToList())
                            {
                                user.FirstName = txt_first_name.Text;
                                user.LastName = txt_last_name.Text;
                            }
                            var resultSet1 = from list in db.runner
                                             where list.Email.Equals(Form_login.UserEmail.Email)
                                             select list;
                            foreach (var rsRunner in resultSet1.ToList())
                            {
                                rsRunner.Gender = txt_gender.Text;
                                rsRunner.DateOfBirth = Convert.ToDateTime(dtp_DOB.Value.ToString("yyyy-MM-dd"));

                                rsRunner.CountryCode = txt_country.Text;
                            }
                            if (txt_npw.Text != "" && txt_npw2.Text != "" && txt_cpw.Text == "")
                            {
                                MessageBox.Show("Please input your current password!");
                                return;
                            }
                            if ((txt_npw.Text == "" || txt_npw2.Text == "") && txt_cpw.Text != "")
                            {
                                MessageBox.Show("Please input your new password!");
                                return;
                            }

                            if (txt_npw.Text != txt_npw2.Text)
                            {
                                MessageBox.Show("Please confirm your new password!");
                                return;
                            }

                            if ((txt_npw.Text != "" || txt_npw2.Text != "") && txt_cpw.Text != "")
                            {
                                if (resultSet.Any(pw => pw.Password == txt_cpw.Text))
                                {
                                    foreach (var user in resultSet.ToList())
                                    {
                                        user.Password = txt_npw.Text;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please comfirm your current passwrod!");
                                }
                            }
                            db.SaveChanges();
                            MessageBox.Show("Edited");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        home.Show();
                        this.Close();
                    }
                }
                else
                {
                    using (var db = new marathonskills2017Entities1())
                    {
                        var resultSet0 = from list in db.user
                                         where list.Email.Contains(Form_login.UserEmail.Email)
                                         select list;
                        if (txt_npw.Text != "" && txt_npw2.Text != "" && txt_cpw.Text == "")
                        {
                            MessageBox.Show("Please input your current password!");
                            return;
                        }
                        if ((txt_npw.Text == "" || txt_npw2.Text == "") && txt_cpw.Text != "")
                        {
                            MessageBox.Show("Please input your new password!");
                            return;
                        }

                        if (txt_npw.Text != txt_npw2.Text)
                        {
                            MessageBox.Show("Please confirm your new password!");
                            return;
                        }

                        if ((txt_npw.Text != "" || txt_npw2.Text != "") && txt_cpw.Text != "")
                        {
                            if (resultSet0.Any(pw => pw.Password == txt_cpw.Text))
                            {
                                foreach (var user in resultSet0.ToList())
                                {
                                    user.Password = txt_npw.Text;
                                }
                                MessageBox.Show("Password changed");
                                db.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Please comfirm your current passwrod!");
                            }
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Something wrong");
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_runner_home home = new Form_runner_home();
            home.Show();
            this.Close();
        }

        private void btn_BMI_BMR_Click(object sender, EventArgs e)
        {
            Form_BMI_BMR bmi = new Form_BMI_BMR();
            bmi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            Form_viewCert cert = new Form_viewCert();
            cert.Show();
            this.Close();
        }
    }
}
