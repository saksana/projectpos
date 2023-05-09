
namespace testPos
{
    partial class frmSetting
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtusers = new System.Windows.Forms.Button();
            this.txtmyshop = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtclose = new testPos.Mycontrols.Mybutton();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.txtusers);
            this.panel4.Controls.Add(this.txtmyshop);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 529);
            this.panel4.TabIndex = 1;
            // 
            // txtusers
            // 
            this.txtusers.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtusers.FlatAppearance.BorderSize = 0;
            this.txtusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtusers.Font = new System.Drawing.Font("Noto Sans Lao", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusers.ForeColor = System.Drawing.Color.Black;
            this.txtusers.Location = new System.Drawing.Point(0, 180);
            this.txtusers.Name = "txtusers";
            this.txtusers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.txtusers.Size = new System.Drawing.Size(270, 60);
            this.txtusers.TabIndex = 7;
            this.txtusers.Text = "ຜູ້ໃຊ້ລະບົບ";
            this.txtusers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtusers.UseVisualStyleBackColor = true;
            this.txtusers.Click += new System.EventHandler(this.txtusers_Click);
            // 
            // txtmyshop
            // 
            this.txtmyshop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtmyshop.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtmyshop.FlatAppearance.BorderSize = 0;
            this.txtmyshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtmyshop.Font = new System.Drawing.Font("Noto Sans Lao", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmyshop.ForeColor = System.Drawing.Color.White;
            this.txtmyshop.Location = new System.Drawing.Point(0, 120);
            this.txtmyshop.Name = "txtmyshop";
            this.txtmyshop.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.txtmyshop.Size = new System.Drawing.Size(270, 60);
            this.txtmyshop.TabIndex = 6;
            this.txtmyshop.Text = "ຂໍ້ມູນຮ້ານ";
            this.txtmyshop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtmyshop.UseVisualStyleBackColor = false;
            this.txtmyshop.Click += new System.EventHandler(this.txtmyshop_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 120);
            this.panel6.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::testPos.Properties.Resources.wrench;
            this.pictureBox1.Location = new System.Drawing.Point(93, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(71, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ຕັ້ງຄ່າລະບົບ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.txtclose);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(938, 529);
            this.panel3.TabIndex = 2;
            // 
            // txtclose
            // 
            this.txtclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtclose.BackColor = System.Drawing.Color.Red;
            this.txtclose.BackgroundColor = System.Drawing.Color.Red;
            this.txtclose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.txtclose.BorderRadius = 10;
            this.txtclose.BorderSize = 0;
            this.txtclose.FlatAppearance.BorderSize = 0;
            this.txtclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtclose.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclose.ForeColor = System.Drawing.Color.White;
            this.txtclose.Location = new System.Drawing.Point(839, 9);
            this.txtclose.Name = "txtclose";
            this.txtclose.Size = new System.Drawing.Size(90, 40);
            this.txtclose.TabIndex = 5;
            this.txtclose.Text = "Close";
            this.txtclose.TextColor = System.Drawing.Color.White;
            this.txtclose.UseVisualStyleBackColor = false;
            this.txtclose.Click += new System.EventHandler(this.txtclose_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 529);
            this.Controls.Add(this.panel3);
            this.Name = "frmSetting";
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button txtusers;
        private System.Windows.Forms.Button txtmyshop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Mycontrols.Mybutton txtclose;
    }
}