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
    public partial class Form_Edit_Event : Form
    {
        public Form_Edit_Event()
        {
            InitializeComponent();
        }

        private void Form_Edit_Event_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy/MM/dd hh:mm:ss";
                cbMaraID.Items.Add("FM");
                cbMaraID.Items.Add("HM");
                cbMaraID.Items.Add("FR");
                using (var db = new marathonskills2017Entities1())
                {
                    var code = (from list in db.marathon
                                select list);
                    foreach (var con2 in code.ToList())
                    {
                        cbMaraID.Items.Add(con2.MarathonId);
                    }
                    var resultSet = (from list in db.@event
                                     where list.EventId.Equals(Form_Admin_marathon.EditEvent.id)
                                     select list);
                    foreach (var mara in resultSet.ToList())
                    {
                        txt_name.Text = mara.EventName;
                        txt_cost.Text = Convert.ToString(mara.Cost);
                        txt_max.Text = Convert.ToString(mara.MaxParticipants);
                        cbType.Text = mara.EventTypeId;
                        cbMaraID.Text = Convert.ToString(mara.MarathonId);
                        dateTimePicker1.Value = Convert.ToDateTime(mara.StartDateTime.ToString());
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
                    var resultSet = from list in db.@event
                                    where list.EventId.Equals(Form_Admin_marathon.EditEvent.id)
                                    select list;
                    foreach (var mara in resultSet.ToList())
                    {
                        mara.EventName = txt_name.Text;
                        mara.EventTypeId = cbType.Text;
                        mara.MarathonId = Convert.ToSByte(cbMaraID.Text);
                        mara.Cost = Convert.ToDecimal(txt_cost.Text);
                        mara.MaxParticipants = Convert.ToInt16(txt_max.Text);
                        mara.StartDateTime = dateTimePicker1.Value;
                    }
                    db.SaveChanges();
                    MessageBox.Show("Edited");
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
    }
}
