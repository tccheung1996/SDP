namespace SDP_project
{
    partial class Form_charity
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Char_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.char_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.char_logo = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Char_name,
            this.char_description,
            this.char_logo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(854, 474);
            this.dataGridView1.TabIndex = 0;
            // 
            // Char_name
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Char_name.DefaultCellStyle = dataGridViewCellStyle1;
            this.Char_name.Frozen = true;
            this.Char_name.HeaderText = "Charity Name";
            this.Char_name.Name = "Char_name";
            // 
            // char_description
            // 
            this.char_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.char_description.DefaultCellStyle = dataGridViewCellStyle2;
            this.char_description.Frozen = true;
            this.char_description.HeaderText = "Description";
            this.char_description.Name = "char_description";
            this.char_description.Width = 356;
            // 
            // char_logo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.char_logo.DefaultCellStyle = dataGridViewCellStyle3;
            this.char_logo.Frozen = true;
            this.char_logo.HeaderText = "Logo";
            this.char_logo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.char_logo.Name = "char_logo";
            this.char_logo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.char_logo.Width = 355;
            // 
            // Form_charity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 498);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_charity";
            this.Text = "Charity";
            this.Load += new System.EventHandler(this.Form_charity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Char_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn char_description;
        private System.Windows.Forms.DataGridViewImageColumn char_logo;
    }
}