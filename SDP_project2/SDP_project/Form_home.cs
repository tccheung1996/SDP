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
    public partial class Form_home : Form
    {
        public Form_home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Form_register fm_register = new Form_register();
            fm_register.Show();
            this.Hide();
        }

        private void btn_BMI_BMR_Click(object sender, EventArgs e)
        {
            Form_BMI_BMR fm_BMI_BMR = new Form_BMI_BMR();
            fm_BMI_BMR.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form_login login = new Form_login();
            login.Show();
            this.Hide();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Form_eventInfo info = new Form_eventInfo();
            info.Show();
        }

        private void btn_charity_Click(object sender, EventArgs e)
        {
            Form_charity charity = new Form_charity();
            charity.Show();
        }

        private void Form_home_Load(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate(new Uri(Application.StartupPath + "\\Marathon\\drive-download-20170624T072759Z-001\\index.html"));
        }
    }
}
