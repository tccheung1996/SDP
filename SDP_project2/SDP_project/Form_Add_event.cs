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
    public partial class Form_Add_event : Form
    {
        public Form_Add_event()
        {
            InitializeComponent();
        }

        private void Form_Add_event_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Add("FM");
                comboBox1.Items.Add("HM");
                comboBox1.Items.Add("FR");

                using (var db = new marathonskills2017Entities1())
                {
                    var code = (from list in db.marathon
                                select list);
                    foreach (var con2 in code.ToList())
                    {
                        comboBox2.Items.Add(con2.MarathonId);
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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text == "" && txt_name.Text.Substring(0, 1) == " ")
                {
                    MessageBox.Show("Please input vaild event name!");
                    return;
                }
                if (txt_max.Text == "" && txt_max.Text.Substring(0, 1) == " ")
                {
                    MessageBox.Show("Please input vaild max participent!");
                    return;
                }
                if (txt_cost.Text == "" && txt_cost.Text.Substring(0, 1) == " ")
                {
                    MessageBox.Show("Please input vaild cost!");
                    return;
                }
                if (comboBox1.SelectedItem == "")
                {
                    MessageBox.Show("Please select the Event type");
                    return;
                }
                if (comboBox2.SelectedItem == "")
                {
                    MessageBox.Show("Please select the Marathon ID");
                    return;
                }
                using (var db = new marathonskills2017Entities1())
                {
                    db.@event.Add(new @event()
                    {
                        EventName = txt_name.Text,
                        EventTypeId = comboBox1.SelectedItem.ToString(),
                        Cost = Convert.ToDecimal(txt_cost.Text),
                        StartDateTime = Convert.ToDateTime(dateTimePicker1.Value.ToString()),
                        MaxParticipants = Convert.ToInt16(txt_max.Text),
                        MarathonId = Convert.ToSByte(comboBox2.SelectedItem.ToString()),
                        EventId = dateTimePicker1.Value.Year.ToString().Substring(2, 2) + "_" + comboBox2.SelectedItem.ToString() + comboBox1.SelectedItem.ToString()
                    });
                    db.SaveChanges();
                    MessageBox.Show("Event added");
                }
            }
            catch(Exception ec)
            {
                MessageBox.Show("Something wrong");
                return;
            }
        }
    }
}
