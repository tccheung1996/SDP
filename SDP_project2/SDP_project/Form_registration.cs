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
    public partial class Form_register : Form
    {
        public Form_register()
        {
            InitializeComponent();
            
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Runner");
            comboBox1.Items.Add("Sponsor");
           
            this.txt_Pswd.PasswordChar = '\u25cf';
            this.txt_Pawd2.PasswordChar = '\u25cf';
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form_home fm_home = new Form_home();
            fm_home.Show();
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {

                if (!System.Text.RegularExpressions.Regex.IsMatch(txt_email.Text, "^(?=.*[@])"))
                {
                    MessageBox.Show("Invaild Email");
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Pswd.Text, "^(?=.*[A-Z])(?=.*[$@$!%*?&])[A-Za-z\\d$@$!%*?&]{6,10}"))
                {
                    MessageBox.Show("Invaild password!! \n your password should have\nAt least 6 characters \nAt least 1 uppercase letter\nAt least 1 number / digit\nAt least 1 of the following symbols: !@#$%^");

                    return;
                }

                String roleID = "";
                if (txt_firstName.Text == "")
                {
                    MessageBox.Show("Please type your First Name");
                    return;
                }
                if (txt_email.Text.Contains(" "))
                {
                    MessageBox.Show("Invaild Email");
                    return;
                }
                if (txt_firstName.Text.Substring(0,1)== " ")
                {
                    MessageBox.Show("Invaild First name");
                    return;
                }
                if(txt_lastName.Text.Substring(0,1) == " ")
                {
                    MessageBox.Show("Invaild Last name");
                    return;
                }
                
                if (txt_lastName.Text == "")
                {
                    MessageBox.Show("Please type your Last Name");
                    return;
                }
                if (txt_Pswd.Text != txt_Pawd2.Text)
                {
                    MessageBox.Show("Please comfirm you password");
                    return;
                }
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select type");
                    return;
                }
                if (comboBox1.SelectedItem == "Runner")
                    roleID = "R";
                if (comboBox1.SelectedItem == "Sponsor")
                    roleID = "S";

                using (var db = new marathonskills2017Entities1())
                {
                    var userList = db.user.ToList<user>();
                    if (db.user.Any(o => o.Email == txt_email.Text))
                    {
                        MessageBox.Show("This email is already exist");
                        return;
                    }
                    db.user.Add(new user()
                    {
                        Email = txt_email.Text,
                        Password = txt_Pswd.Text,
                        FirstName = txt_firstName.Text,
                        LastName = txt_lastName.Text,
                        RoleId = roleID
                    });
                    if (roleID == "S")
                    {
                        db.sponsorship.Add(new sponsorship()
                        {
                            SponsorName = txt_firstName.Text + " " + txt_lastName.Text
                        });
                    }
                    if (roleID == "R")
                    {
                        var runnerList = db.runner.ToList<runner>();
                        db.runner.Add(new runner()
                        {
                            Email = txt_email.Text,
                            registrationstatus = "Registered"

                        });
                    }

                    db.SaveChanges();
                    MessageBox.Show("Register successfully");
                }



            }
            catch (Exception ec)
            {
                MessageBox.Show("Something wrong");
                return;
            }



        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_email.Text = null;
            txt_firstName.Text = null;
            txt_lastName.Text = null;
            txt_Pswd.Text = null;
            txt_Pawd2.Text = null;
            comboBox1.ResetText();
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

        private void btn_BMI_BMR_Click(object sender, EventArgs e)
        {
            Form_BMI_BMR index = new Form_BMI_BMR();
            index.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form_login login = new Form_login();
            login.Show();
            this.Close();
        }
    }
}
