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
    public partial class Form_Admin_home : Form
    {
        public Form_Admin_home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Admin_runner runner = new Form_Admin_runner();
            runner.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Admin_marathon mar = new Form_Admin_marathon();
            mar.Show();
            this.Close();
        }

        private void Form_Admin_home_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri(Application.StartupPath + "\\Marathon\\drive-download-20170624T072759Z-001\\index.html"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_admin_sponsor spon = new Form_admin_sponsor();
            spon.Show();
            this.Close();
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
