namespace SDP_project
{
    partial class Form_home
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_charity = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_BMI_BMR = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
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
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_charity);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.btn_BMI_BMR);
            this.groupBox1.Controls.Add(this.btn_register);
            this.groupBox1.Controls.Add(this.btn_info);
            this.groupBox1.Location = new System.Drawing.Point(1, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 396);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.btn_login.Location = new System.Drawing.Point(51, 105);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(131, 23);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
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
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(51, 43);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(131, 23);
            this.btn_register.TabIndex = 0;
            this.btn_register.Text = "Register Account";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
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
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(259, 147);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(700, 480);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form_home";
            this.Text = "Marathon Skills 2017";
            this.Load += new System.EventHandler(this.Form_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_charity;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_BMI_BMR;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

