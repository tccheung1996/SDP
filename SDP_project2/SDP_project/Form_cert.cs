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
    public partial class Form_cert : Form
    {
        public Form_cert()
        {
            InitializeComponent();
        }

        private void Form_cert_Load(object sender, EventArgs e)
        {
            label2.Text = Form_viewCert.cert.marathon_Name;
            int totalSeconds = Form_viewCert.cert.raceTime;
            int seconds = totalSeconds % 60;
            int minutes = totalSeconds / 60;
            string time = minutes + "minutes:" + seconds + "seconds";
            string gender="";
            if (Form_viewCert.cert.gender == "Male")
            {
                gender = "Mr.";
            }
            else if (Form_viewCert.cert.gender == "Female")
            {
                gender = "Miss";
            }
                label1.Text = "This is certify that "+gender+" "+(Form_viewCert.cert.fname +" " + Form_viewCert.cert.lname) + 
                "\n, bearer of Runner ID No. "+Form_viewCert.cert.runnerID+
                "\n, was finished the "+ Form_viewCert.cert.eventName + "\n and finish on "+time;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");

            this.Close();
        }
    }
}
