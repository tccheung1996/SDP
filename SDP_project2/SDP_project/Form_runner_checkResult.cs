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
    public partial class Form_runner_checkResult : Form
    {
        public Form_runner_checkResult()
        {
            InitializeComponent();
        }


        public static string event_id;


        private void Form_runner_checkResult_Load(object sender, EventArgs e)
        {
            try
            {

                using (var db = new marathonskills2017Entities1())
                {
                    var resultSet1 = from list in db.registrationevent
                                     where list.runnerID.Equals(Form_login.RunnerID.runnerID)
                                     select list;

                    foreach (var id1 in resultSet1.ToList())
                    {

                        event_id = id1.EventId;

                        var resultSet = from list in db.@event
                                        where list.EventId.Contains(event_id)
                                        select list;
                        foreach (var id in resultSet.ToList())
                        {
                            dataGridView1.Rows.Add(id1.EventId, id.EventName, id1.runnerID, id.StartDateTime);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    using (var db = new marathonskills2017Entities1())
                    {

                        string ID = dataGridView1.Rows[e.RowIndex].Cells["eventID"].Value.ToString();
                        var resultSet = from list in db.registrationevent
                                        where list.EventId.Equals(ID)
                                        select list;
                        foreach (var time in resultSet.ToList())
                        {
                            int totalSeconds = Convert.ToInt32(time.RaceTime);
                            int seconds = totalSeconds % 60;
                            int minutes = totalSeconds / 60;
                            string time1 = minutes + "minutes:" + seconds+"seconds";
                            label2.Text = "You had finish the event named \n" + dataGridView1.Rows[e.RowIndex].Cells["eventName"].Value.ToString() + "\n and you spend "
                            + time1 + " to finish";
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form_login.UserEmail.Email = "";
            Form_login.RunnerID.runnerID = 0;
            Form_home home = new Form_home();
            home.Show();
            this.Close();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            Form_viewCert cert = new Form_viewCert();
            cert.Show();
            this.Close();
        }

        private void btn_BMI_BMR_Click(object sender, EventArgs e)
        {
            Form_BMI_BMR bmi = new Form_BMI_BMR();
            bmi.Show();
            this.Hide();
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
            this.Hide();
        }
    }
}
