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
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new marathonskills2017Entities1())
            {
                if (db.user.Any(r => r.Email == txt_email.Text && r.Password == txt_pswd.Text && r.RoleId == "A"))
                {
                    Form_home home = new Form_home();
                    Form_Admin_home admin = new Form_Admin_home();
                    UserEmail.Email = txt_email.Text;
                    
                    admin.Show();
                    home.Close();
                    this.Close();
                }

                else if (db.user.Any(r => r.Email == txt_email.Text && r.Password == txt_pswd.Text && r.RoleId == "R"))
                {
                    Form_home home = new Form_home();
                    Form_runner_home runner = new Form_runner_home();
                    UserEmail.Email = txt_email.Text;
                    var resultSet = from list in db.runner
                                    where list.Email.Equals(txt_email.Text)
                                    select list;
                    foreach (var id in resultSet.ToList())
                    {
                        RunnerID.runnerID = id.RunnerId;
                    }
                    runner.Show();
                    home.Close();
                    this.Close();
                }
                else if(db.user.Any(r => r.Email == txt_email.Text && r.Password == txt_pswd.Text && r.RoleId == "S"))
                {
                    Form_home home = new Form_home();
                    Form_sponsor_home sponsor = new Form_sponsor_home();
                    UserEmail.Email = txt_email.Text;
                    loading load = new loading();

                    load.Show();
                    
                    Application.DoEvents();
                    sponsor.Show();
                    load.Close();
                    home.Close();
                    this.Close();
                }
                else if (db.user.Any(r => r.Email == txt_email.Text && r.Password == txt_pswd.Text && r.RoleId == "C"))
                {
                    Form_home home = new Form_home();
                    Form_coo_home chome = new Form_coo_home();
                    UserEmail.Email = txt_email.Text;
                    loading load = new loading();

                    load.Show();

                    Application.DoEvents();
                    chome.Show();
                    load.Close();
                    home.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invaild email or password!");
                    return;
                }

            }

        }
        public class UserEmail
        {
            public static string Email;
        }
        public class RunnerID
        {
            public static int runnerID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_home home = new Form_home();
            home.Show();
            this.Close();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            this.txt_pswd.PasswordChar = '\u25cf';
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form_register register = new Form_register();
            register.Show();
            this.Close();
        }

        private void btn_BMI_BMR_Click(object sender, EventArgs e)
        {
            Form_BMI_BMR bmi = new Form_BMI_BMR();
            bmi.Show();
        }
    }
}
