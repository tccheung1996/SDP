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
    public partial class Form_runner_join : Form
    {
        public Form_runner_join()
        {
            InitializeComponent();
        }
        public class runner
        {
            public static int ID;
        }


        private void Form_runner_join_Load(object sender, EventArgs e)
        {
            using (var db = new marathonskills2017Entities1())
            {
                var resultSet1 = from list in db.runner
                                 where list.Email.Equals(Form_login.UserEmail.Email)
                                 select list;
                var emp = (from country in db.country
                           select country);
                foreach (var emp2 in emp.ToList())
                {
                    comboBox1.Items.Add(emp2.CountryCode);

                }
                if (resultSet1.Any(o => o.registrationstatus == "Waiting for payment"))
                {
                    DialogResult dialogResult = MessageBox.Show("you have already joined the event! \nDo you want to finish the payment now?", "Attention", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Now will send you to payment page");
                        Form_payment payment = new Form_payment();
                        payment.Show();
                        this.Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Form_runner_home home = new Form_runner_home();
                        home.Show();
                        this.Close();
                    }

                }
                
            }

        }

        private void btn_check_code_Click(object sender, EventArgs e)
        {
            Form_countryCode country = new Form_countryCode();
            country.Show();
        }
        public class Registration
        {
            public static string eventType;
            public static string gender;
            public static string date;
            public static string country;
            public static string registrationStatus = "Waiting for payment";
            public static string eventID;
            public static int regisID;

        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb_21k.Checked)
                {
                    Registration.eventType = "HM";
                    Registration.eventID = "17_6HM";
                }
                else if (rb_42k.Checked)
                {
                    Registration.eventType = "FM";
                    Registration.eventID = "17_6FM";
                }
                else if (rb_5k.Checked)
                {
                    Registration.eventType = "FR";
                    Registration.eventID = "17_6FR";
                }
                else
                {
                    MessageBox.Show("Please select the event");
                }
                if (rb_male.Checked)
                {
                    Registration.gender = "Male";
                }
                else if (rb_female.Checked)
                {
                    Registration.gender = "Female";
                }
                else
                {
                    MessageBox.Show("Please select the gender");
                    return;
                }
                if (dateTimePicker1.Value > System.DateTime.Now)
                {
                    MessageBox.Show("Invaild Date Of Birth");
                    return;
                }
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please select the country code");
                    return;
                }

                using (var db = new marathonskills2017Entities1())
                {
                    
                    var resultSet1 = from list in db.runner
                                     where list.Email.Equals(Form_login.UserEmail.Email)
                                     select list;
                    foreach (var rsRunner in resultSet1.ToList())
                    {
                        rsRunner.Gender = Registration.gender;
                        rsRunner.DateOfBirth = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        rsRunner.eventtype = Registration.eventType;
                        rsRunner.CountryCode = comboBox1.SelectedItem.ToString();
                        rsRunner.registrationstatus = Registration.registrationStatus;
                        runner.ID = rsRunner.RunnerId;
                    }
                    db.registration.Add(new registration()
                    {
                        RunnerId = runner.ID,
                        RegistrationDateTime = System.DateTime.Now

                    });
                    var resultSet2 = from list in db.registration
                                     where list.RunnerId.Equals(runner.ID)
                                     select list;
                    foreach (var rsRunner in resultSet2.ToList())
                    {
                        Registration.regisID = rsRunner.RegistrationId;
                    }
                    db.registrationevent.Add(new registrationevent()
                    {
                        runnerID = runner.ID,
                        EventId = Registration.eventID,
                        RegistrationId = Registration.regisID
                    });
                    db.SaveChanges();
                }
                MessageBox.Show("Join event successfully");
                DialogResult dialogResult = MessageBox.Show("Do you want to finish the payment now? \n !!if you complete the payment, you can not edit you profile anymore!!!", "Attention", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Now will send you to payment page");
                    Form_payment payment = new Form_payment();
                    payment.Show();
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
            catch (Exception ec)
            {
                MessageBox.Show("Something wrong");
                return;
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form_runner_profile profile = new Form_runner_profile();
            profile.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_viewCert cert = new Form_viewCert();
            cert.Show();
            this.Close();
        }
    }
}
