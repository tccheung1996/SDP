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
    public partial class Form_coo_home : Form
    {
        public Form_coo_home()
        {
            InitializeComponent();
        }


        private void Form_coo_home_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Hide();
                comboBox1.Items.Add("Registered");
                comboBox1.Items.Add("Payment Confirmed");
                comboBox1.Items.Add("Waiting for payment");
                label5.Hide();
                label6.Hide();
                label3.Hide();
                label4.Hide();
                label7.Hide();
                label8.Hide();
                txt_country.Hide();
                txt_first_name.Hide();
                txt_gender.Hide();
                txt_last_name.Hide();
                comboBox1.Hide();
                dtp_DOB.Hide();
                button6.Hide();
                using (var db = new marathonskills2017Entities1())
                {

                    var innerJoin = from contact in db.runner
                                    join dealer in db.user on contact.Email equals dealer.Email
                                    select contact;

                    foreach (var rs in innerJoin.ToList())
                    {
                        dataGridView1.Rows.Add(rs.RunnerId, rs.Email, rs.user.FirstName, rs.user.LastName);
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
                using (var db = new marathonskills2017Entities1())
                {
                    dataGridView1.Rows.Clear();
                    var innerJoin = from contact in db.runner
                                    join dealer in db.user on contact.Email equals dealer.Email
                                    where contact.Email.Contains(txt_search.Text)
                                    select contact;

                    foreach (var rs in innerJoin.ToList())
                    {
                        dataGridView1.Rows.Add(rs.RunnerId, rs.Email, rs.user.FirstName, rs.user.LastName);
                    }

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
            try
            {
                dataGridView2.Rows.Clear();

                using (var db = new marathonskills2017Entities1())
                {

                    var runner = from contact in db.runner
                                 join dealer in db.user on contact.Email equals dealer.Email
                                 where contact.Email.Contains(textBox1.Text)
                                 select contact;

                    foreach (var rs in runner.ToList())
                    {
                        dataGridView2.Rows.Add(rs.RunnerId, rs.Email, rs.user.FirstName, rs.user.LastName);
                    }
                    dataGridView2.Show();

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Something wrong");
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (var db = new marathonskills2017Entities1())
                {

                    Form_Admin_runner.UserEmail.Email = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
                    var resultSet = from list in db.user
                                    where list.Email.Equals(Form_Admin_runner.UserEmail.Email)
                                    select list;
                    foreach (var user in resultSet.ToList())
                    {
                        txt_first_name.Text = user.FirstName;
                        txt_last_name.Text = user.LastName;
                    }
                    var resultSet1 = from list in db.runner
                                     where list.Email.Equals(Form_Admin_runner.UserEmail.Email)
                                     select list;
                    foreach (var rsRunner in resultSet1.ToList())
                    {
                        txt_gender.Text = rsRunner.Gender;
                        if (rsRunner.DateOfBirth != null)
                            dtp_DOB.Value = Convert.ToDateTime(rsRunner.DateOfBirth);
                        comboBox1.Text = rsRunner.registrationstatus;
                        txt_country.Text = rsRunner.CountryCode;
                    }
                    label5.Show();
                    label6.Show();
                    label3.Show();
                    label4.Show();
                    label7.Show();
                    label8.Show();
                    txt_country.Show();
                    txt_first_name.Show();
                    txt_gender.Show();
                    txt_last_name.Show();
                    comboBox1.Show();
                    dtp_DOB.Show();
                    button6.Show();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Something wrong");
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to edit runner profile?", "Attention", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (var db = new marathonskills2017Entities1())
                    {
                        var resultSet = from list in db.user
                                        where list.Email.Equals(Form_Admin_runner.UserEmail.Email)
                                        select list;
                        foreach (var user in resultSet.ToList())
                        {
                            user.FirstName = txt_first_name.Text;
                            user.LastName = txt_last_name.Text;
                        }
                        var resultSet1 = from list in db.runner
                                         where list.Email.Equals(Form_Admin_runner.UserEmail.Email)
                                         select list;
                        foreach (var rsRunner in resultSet1.ToList())
                        {
                            rsRunner.Gender = txt_gender.Text;
                            rsRunner.DateOfBirth = Convert.ToDateTime(dtp_DOB.Value.ToString("yyyy-MM-dd"));

                            rsRunner.CountryCode = txt_country.Text;
                            rsRunner.registrationstatus = comboBox1.SelectedItem.ToString();
                        }

                        db.SaveChanges();
                        MessageBox.Show("Edited");
                    }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form_login.UserEmail.Email = "";
            Form_login.RunnerID.runnerID = 0;
            Form_home home = new Form_home();
            home.Show();
            this.Close();
        }
    }
}
