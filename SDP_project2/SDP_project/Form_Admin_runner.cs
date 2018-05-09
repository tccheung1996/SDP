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
    public partial class Form_Admin_runner : Form
    {
        public Form_Admin_runner()
        {
            InitializeComponent();
        }
        public class UserEmail
        {
            public static string Email;
        }
        private void Form_Admin_runner_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            
            using (var db = new marathonskills2017Entities1())
            {
                
                var innerJoin = from contact in db.runner
                                     join dealer in db.user on contact.Email equals dealer.Email
                                     where contact.Email.Contains(txt_search.Text)
                                     select contact;
                
                foreach (var rs in innerJoin.ToList())
                {
                    dataGridView1.Rows.Add(rs.RunnerId,rs.Email,rs.user.FirstName,rs.user.LastName);
                }
                dataGridView1.Show();
                
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
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
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_login.UserEmail.Email = "";
            Form_login.RunnerID.runnerID = 0;
            Form_home home = new Form_home();
            home.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Admin_marathon mar = new Form_Admin_marathon();
            mar.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_admin_sponsor spon = new Form_admin_sponsor();
            spon.Show();
            this.Close();
        }
    }
}
