namespace SDP_project
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_charity = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_BMI_BMR = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pswd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_charity);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.btn_BMI_BMR);
            this.groupBox1.Controls.Add(this.btn_info);
            this.groupBox1.Location = new System.Drawing.Point(1, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 396);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btn_charity
            // 
            this.btn_charity.Location = new System.Drawing.Point(51, 267);
            this.btn_charity.Name = "btn_charity";
            this.btn_charity.Size = new System.Drawing.Size(131, 23);
            this.btn_charity.TabIndex = 4;
            this.btn_charity.Text = "charity";
            this.btn_charity.UseVisualStyleBackColor = true;
            this.btn_charity.Click += new System.EventHandler(this.btn_charity_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(51, 99);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(131, 23);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Register";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_BMI_BMR
            // 
            this.btn_BMI_BMR.Location = new System.Drawing.Point(51, 216);
            this.btn_BMI_BMR.Name = "btn_BMI_BMR";
            this.btn_BMI_BMR.Size = new System.Drawing.Size(131, 23);
            this.btn_BMI_BMR.TabIndex = 3;
            this.btn_BMI_BMR.Text = "Calculate BMI && BMR";
            this.btn_BMI_BMR.UseVisualStyleBackColor = true;
            this.btn_BMI_BMR.Click += new System.EventHandler(this.btn_BMI_BMR_Click);
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(51, 157);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(131, 23);
            this.btn_info.TabIndex = 2;
            this.btn_info.Text = "Event Information";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Login.Location = new System.Drawing.Point(568, 175);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(96, 37);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(459, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(429, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(515, 284);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(162, 22);
            this.txt_email.TabIndex = 10;
            // 
            // txt_pswd
            // 
            this.txt_pswd.Location = new System.Drawing.Point(515, 349);
            this.txt_pswd.Name = "txt_pswd";
            this.txt_pswd.Size = new System.Drawing.Size(162, 22);
            this.txt_pswd.TabIndex = 11;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.txt_pswd);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_charity;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_BMI_BMR;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_pswd;
    }
}