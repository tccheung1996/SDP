namespace SDP_project
{
    partial class Form_runner_profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_runner_profile));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_BMI_BMR = new System.Windows.Forms.Button();
            this.btn_charity = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_first_name = new System.Windows.Forms.TextBox();
            this.txt_last_name = new System.Windows.Forms.TextBox();
            this.txt_gender = new System.Windows.Forms.ComboBox();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.txt_eventStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cpw = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_npw = new System.Windows.Forms.TextBox();
            this.txt_npw2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(48, 206);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(131, 23);
            this.btn_info.TabIndex = 2;
            this.btn_info.Text = "Event Information";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_BMI_BMR
            // 
            this.btn_BMI_BMR.Location = new System.Drawing.Point(48, 40);
            this.btn_BMI_BMR.Name = "btn_BMI_BMR";
            this.btn_BMI_BMR.Size = new System.Drawing.Size(131, 23);
            this.btn_BMI_BMR.TabIndex = 3;
            this.btn_BMI_BMR.Text = "Calculate BMI && BMR";
            this.btn_BMI_BMR.UseVisualStyleBackColor = true;
            this.btn_BMI_BMR.Click += new System.EventHandler(this.btn_BMI_BMR_Click);
            // 
            // btn_charity
            // 
            this.btn_charity.Location = new System.Drawing.Point(48, 260);
            this.btn_charity.Name = "btn_charity";
            this.btn_charity.Size = new System.Drawing.Size(131, 23);
            this.btn_charity.TabIndex = 4;
            this.btn_charity.Text = "charity";
            this.btn_charity.UseVisualStyleBackColor = true;
            this.btn_charity.Click += new System.EventHandler(this.btn_charity_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Join Event";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Check Result";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(49, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_charity);
            this.groupBox1.Controls.Add(this.btn_BMI_BMR);
            this.groupBox1.Controls.Add(this.btn_info);
            this.groupBox1.Location = new System.Drawing.Point(1, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 396);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(531, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Profile";
            // 
            // txt_first_name
            // 
            this.txt_first_name.Location = new System.Drawing.Point(379, 195);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(164, 22);
            this.txt_first_name.TabIndex = 10;
            // 
            // txt_last_name
            // 
            this.txt_last_name.Location = new System.Drawing.Point(671, 195);
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(164, 22);
            this.txt_last_name.TabIndex = 11;
            // 
            // txt_gender
            // 
            this.txt_gender.FormattingEnabled = true;
            this.txt_gender.Location = new System.Drawing.Point(671, 236);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(55, 20);
            this.txt_gender.TabIndex = 13;
            // 
            // txt_country
            // 
            this.txt_country.Location = new System.Drawing.Point(381, 282);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(162, 22);
            this.txt_country.TabIndex = 14;
            // 
            // txt_eventStatus
            // 
            this.txt_eventStatus.Location = new System.Drawing.Point(671, 282);
            this.txt_eventStatus.Name = "txt_eventStatus";
            this.txt_eventStatus.ReadOnly = true;
            this.txt_eventStatus.Size = new System.Drawing.Size(164, 22);
            this.txt_eventStatus.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date Of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "Country:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "Event Status:";
            // 
            // txt_cpw
            // 
            this.txt_cpw.Location = new System.Drawing.Point(388, 384);
            this.txt_cpw.Name = "txt_cpw";
            this.txt_cpw.Size = new System.Drawing.Size(155, 22);
            this.txt_cpw.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(528, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Change Password";
            // 
            // txt_npw
            // 
            this.txt_npw.Location = new System.Drawing.Point(388, 437);
            this.txt_npw.Name = "txt_npw";
            this.txt_npw.Size = new System.Drawing.Size(155, 22);
            this.txt_npw.TabIndex = 24;
            // 
            // txt_npw2
            // 
            this.txt_npw2.Location = new System.Drawing.Point(388, 491);
            this.txt_npw2.Name = "txt_npw2";
            this.txt_npw2.Size = new System.Drawing.Size(153, 22);
            this.txt_npw2.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "Current password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 442);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "New password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 496);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "Confirm password:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(452, 561);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(651, 561);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Location = new System.Drawing.Point(381, 238);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(164, 22);
            this.dtp_DOB.TabIndex = 31;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(48, 300);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "View Certificate";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form_runner_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_npw2);
            this.Controls.Add(this.txt_npw);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_cpw);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_eventStatus);
            this.Controls.Add(this.txt_country);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_last_name);
            this.Controls.Add(this.txt_first_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_runner_profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Form_runner_profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_BMI_BMR;
        private System.Windows.Forms.Button btn_charity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_first_name;
        private System.Windows.Forms.TextBox txt_last_name;
        private System.Windows.Forms.ComboBox txt_gender;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.TextBox txt_eventStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cpw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_npw;
        private System.Windows.Forms.TextBox txt_npw2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Button button6;
    }
}