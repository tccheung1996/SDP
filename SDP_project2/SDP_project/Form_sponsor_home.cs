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
    public partial class Form_sponsor_home : Form
    {
        public Form_sponsor_home()
        {
            InitializeComponent();
        }
        string fName;
        string lName;
        private void btn_charity_Click(object sender, EventArgs e)
        {
            Form_charity charity = new Form_charity();
            charity.Show();
        }

        private void Form_sponsor_home_Load(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
            comboBox1.Hide();
            txt_amount.Hide();
            button1.Hide();
            label5.Hide();
            label6.Hide();
            textBox1.Hide();
            textBox2.Hide();
            using (var db = new marathonskills2017Entities1())
            {

                var innerJoin = from contact in db.runner
                                join dealer in db.user on contact.Email equals dealer.Email
                               
                                select contact;

                foreach (var rs in innerJoin.ToList())
                {
                    dataGridView1.Rows.Add(rs.RunnerId, rs.user.FirstName +" "+ rs.user.LastName,rs.user.Email);
                }
                var charity = from list in db.charity
                              select list;
                foreach(var rs1 in charity.ToList())
                {
                    comboBox1.Items.Add(rs1.CharityName);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            using (var db = new marathonskills2017Entities1())
            {
                String fullName = txt_search.Text;
                if (txt_search.Text.Contains(" "))
                {
                    fName = fullName.Substring(0, fullName.IndexOf(" "));
                    lName = fullName.Substring(fullName.IndexOf(" ") + 1);
                }
                else
                {
                    fName = fullName;
                    lName = fullName;
                }

                var innerJoin = from contact in db.runner
                                join dealer in db.user on contact.Email equals dealer.Email
                                where dealer.FirstName.Contains(fName) //|| dealer.LastName.Contains(lName)
                                select contact;
                txt_amount.Text = fName;
                foreach (var rs in innerJoin.ToList())
                {
                    dataGridView1.Rows.Add(rs.RunnerId, rs.user.FirstName + " " + rs.user.LastName, rs.user.Email);
                }
             

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            label3.Show();
            label4.Show();
            comboBox1.Show();
            txt_amount.Show();
            button1.Show();
            label5.Show();
            label6.Show();
            textBox1.Show();
            textBox2.Show();
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["runnerID"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["runnerName"].Value.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txt_amount.Text) < 0)
            {
                MessageBox.Show("Invaild amount");
                return;
            }
            using (var db = new marathonskills2017Entities1())
            {
                var sponsor = from a in db.sponsorship
                              join b in db.user on a.SponsorName equals (b.FirstName + " " + b.LastName)
                              where b.Email.Equals(Form_login.UserEmail.Email)
                              select a;
                foreach (var rs in sponsor.ToList())
                {
                    rs.Amount = Convert.ToDecimal(txt_amount.Text);
                }
                
                db.SaveChanges();
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
