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
    public partial class Form_Admin_marathon : Form
    {
        public Form_Admin_marathon()
        {
            InitializeComponent();
        }
        public class EditMarathon
        {
            public static string marathon;
            public static string city;
            public static string year;
            public static string country;
            public static string id;
        }
        public class EditEvent
        {
            public static string eventName;
            public static string eventType;
            public static string startTime;
            public static string cost;
            public static string max;
            public static string id;
        }
        private void Form_Admin_marathon_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new marathonskills2017Entities1())
                {
                    var marathon = (from list in db.marathon
                                    select list);
                    foreach (var marathon2 in marathon.ToList())
                    {
                        dataGridView1.Rows.Add(marathon2.MarathonId, marathon2.MarathonName, marathon2.CityName, marathon2.CountryCode, marathon2.YearHeld);
                    }
                    var @event = (from list in db.@event
                                  select list);
                    foreach (var @event2 in @event.ToList())
                    {
                        dataGridView2.Rows.Add(@event2.EventId, @event2.EventName, @event2.EventTypeId, @event2.StartDateTime, @event2.Cost, @event2.MaxParticipants);
                    }
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
            Form_Add_marathon mar = new Form_Add_marathon();
            mar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                using (var db = new marathonskills2017Entities1())
                {
                    var marathon = (from list in db.marathon
                                    select list);
                    foreach (var marathon2 in marathon.ToList())
                    {
                        dataGridView1.Rows.Add(marathon2.MarathonId, marathon2.MarathonName, marathon2.CityName, marathon2.CountryCode, marathon2.YearHeld);
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

                        Form_Admin_marathon.EditMarathon.id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                        Form_Edit_marathon edit = new Form_Edit_marathon();
                        edit.Show();

                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Something wrong");
                return;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    using (var db = new marathonskills2017Entities1())
                    {

                        Form_Admin_marathon.EditEvent.id = dataGridView2.Rows[e.RowIndex].Cells["ID1"].Value.ToString();

                        Form_Edit_Event edit = new Form_Edit_Event();
                        edit.Show();

                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Something wrong");
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form_Add_event addEvent = new Form_Add_event();
            addEvent.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();
                using (var db = new marathonskills2017Entities1())
                {
                    var @event = (from list in db.@event
                                  select list);
                    foreach (var @event2 in @event.ToList())
                    {
                        dataGridView2.Rows.Add(@event2.EventId, @event2.EventName, @event2.EventTypeId, @event2.StartDateTime, @event2.Cost, @event2.MaxParticipants);
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form_admin_sponsor spon = new Form_admin_sponsor();
            spon.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Admin_runner runner = new Form_Admin_runner();
            runner.Show();
            this.Hide();
        }
    }
}
