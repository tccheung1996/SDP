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
    public partial class Form_admin_sponsor : Form
    {
        public Form_admin_sponsor()
        {
            InitializeComponent();
        }

        private void Form_admin_sponsor_Load(object sender, EventArgs e)
        {
            using (var db = new marathonskills2017Entities1())
            {

                var sponsor = from list in db.sponsorship
                                
                                select list;

                foreach (var rs in sponsor.ToList())
                {
                    dataGridView1.Rows.Add(rs.SponsorshipId,rs.SponsorName,rs.Amount);
                }
                

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                

                txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                txt_amount.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
               
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txt_amount.Text)<0)
            {
                MessageBox.Show("Invaild amount");
                return;
            }
            using (var db = new marathonskills2017Entities1())
            {
                int amount = Convert.ToInt32(txt_id.Text);
                var resultSet = from list in db.sponsorship
                                where list.SponsorshipId.Equals(amount)
                                select list;
                foreach (var user in resultSet.ToList())
                {
                    user.SponsorName = txt_name.Text;
                    user.Amount = Convert.ToDecimal(txt_amount.Text);
                }
                db.SaveChanges();
                MessageBox.Show("edited");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new marathonskills2017Entities1())
            {
                dataGridView1.Rows.Clear();
                var spon = from contact in db.sponsorship
                                
                                where contact.SponsorName.Contains(textBox1.Text)
                                select contact;

                foreach (var rs in spon.ToList())
                {
                    
                    dataGridView1.Rows.Add(rs.SponsorshipId,rs.SponsorName,rs.Amount);
                }
          

            }
        }
    }
}
