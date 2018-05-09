namespace SDP_project
{
    partial class Form_BMI_BMR
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bmi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bmi_hg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bmi_wg = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.cb_hg = new System.Windows.Forms.ComboBox();
            this.cb_wg = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_bmr = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_bmr_hg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bmr_wg = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(103, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calculate BMI && BMR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_bmi);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_bmi_hg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_bmi_wg);
            this.groupBox1.Location = new System.Drawing.Point(40, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 341);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMI";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(191, 115);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(41, 20);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(41, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(21, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "BMI:";
            // 
            // txt_bmi
            // 
            this.txt_bmi.Location = new System.Drawing.Point(61, 249);
            this.txt_bmi.Name = "txt_bmi";
            this.txt_bmi.ReadOnly = true;
            this.txt_bmi.Size = new System.Drawing.Size(124, 22);
            this.txt_bmi.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(9, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Height:";
            // 
            // txt_bmi_hg
            // 
            this.txt_bmi_hg.Location = new System.Drawing.Point(61, 115);
            this.txt_bmi_hg.Name = "txt_bmi_hg";
            this.txt_bmi_hg.Size = new System.Drawing.Size(124, 22);
            this.txt_bmi_hg.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight:";
            // 
            // txt_bmi_wg
            // 
            this.txt_bmi_wg.Location = new System.Drawing.Point(61, 50);
            this.txt_bmi_wg.Name = "txt_bmi_wg";
            this.txt_bmi_wg.Size = new System.Drawing.Size(124, 22);
            this.txt_bmi_wg.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 481);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.rbFemale);
            this.groupBox2.Controls.Add(this.rbMale);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_age);
            this.groupBox2.Controls.Add(this.cb_hg);
            this.groupBox2.Controls.Add(this.cb_wg);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_bmr);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_bmr_hg);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_bmr_wg);
            this.groupBox2.Location = new System.Drawing.Point(350, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 341);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BMR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(9, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "Gender:";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(131, 46);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(56, 16);
            this.rbFemale.TabIndex = 12;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(79, 46);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(46, 16);
            this.rbMale.TabIndex = 11;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(21, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "Age:";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(61, 159);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(72, 22);
            this.txt_age.TabIndex = 9;
            // 
            // cb_hg
            // 
            this.cb_hg.FormattingEnabled = true;
            this.cb_hg.Location = new System.Drawing.Point(191, 115);
            this.cb_hg.Name = "cb_hg";
            this.cb_hg.Size = new System.Drawing.Size(41, 20);
            this.cb_hg.TabIndex = 8;
            // 
            // cb_wg
            // 
            this.cb_wg.FormattingEnabled = true;
            this.cb_wg.Location = new System.Drawing.Point(191, 68);
            this.cb_wg.Name = "cb_wg";
            this.cb_wg.Size = new System.Drawing.Size(41, 20);
            this.cb_wg.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(21, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "BMR:";
            // 
            // txt_bmr
            // 
            this.txt_bmr.Location = new System.Drawing.Point(61, 249);
            this.txt_bmr.Name = "txt_bmr";
            this.txt_bmr.ReadOnly = true;
            this.txt_bmr.Size = new System.Drawing.Size(124, 22);
            this.txt_bmr.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(9, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Height:";
            // 
            // txt_bmr_hg
            // 
            this.txt_bmr_hg.Location = new System.Drawing.Point(61, 115);
            this.txt_bmr_hg.Name = "txt_bmr_hg";
            this.txt_bmr_hg.Size = new System.Drawing.Size(124, 22);
            this.txt_bmr_hg.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Weight:";
            // 
            // txt_bmr_wg
            // 
            this.txt_bmr_wg.Location = new System.Drawing.Point(61, 68);
            this.txt_bmr_wg.Name = "txt_bmr_wg";
            this.txt_bmr_wg.Size = new System.Drawing.Size(124, 22);
            this.txt_bmr_wg.TabIndex = 0;
            // 
            // Form_BMI_BMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_BMI_BMR";
            this.Text = "BMI & BMR calculator";
            this.Load += new System.EventHandler(this.Form_BMI_BMR_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bmi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bmi_hg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bmi_wg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_hg;
        private System.Windows.Forms.ComboBox cb_wg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_bmr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_bmr_hg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bmr_wg;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label9;
    }
}