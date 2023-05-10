
namespace testPos
{
    partial class frmtabbar
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbarcode = new System.Windows.Forms.ToolStripButton();
            this.tscustomer = new System.Windows.Forms.ToolStripButton();
            this.tsstock = new System.Windows.Forms.ToolStripButton();
            this.tssale = new System.Windows.Forms.ToolStripButton();
            this.tstotal = new System.Windows.Forms.ToolStripButton();
            this.tsreport = new System.Windows.Forms.ToolStripButton();
            this.tssetting = new System.Windows.Forms.ToolStripButton();
            this.tslogout = new System.Windows.Forms.ToolStripButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttid = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttname = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttuid = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip2.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbarcode,
            this.tscustomer,
            this.tsstock,
            this.tssale,
            this.tstotal,
            this.tsreport,
            this.tssetting,
            this.tslogout});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(1122, 63);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbarcode
            // 
            this.tsbarcode.AutoSize = false;
            this.tsbarcode.Font = new System.Drawing.Font("Noto Sans Lao", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbarcode.ForeColor = System.Drawing.Color.Black;
            this.tsbarcode.Image = global::testPos.Properties.Resources.barcode;
            this.tsbarcode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbarcode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbarcode.Name = "tsbarcode";
            this.tsbarcode.Size = new System.Drawing.Size(95, 60);
            this.tsbarcode.Text = "ພິມບາໂຄດ";
            this.tsbarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbarcode.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // tscustomer
            // 
            this.tscustomer.AutoSize = false;
            this.tscustomer.Font = new System.Drawing.Font("Noto Sans Lao", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tscustomer.ForeColor = System.Drawing.Color.Black;
            this.tscustomer.Image = global::testPos.Properties.Resources.customer;
            this.tscustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tscustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscustomer.Name = "tscustomer";
            this.tscustomer.Size = new System.Drawing.Size(95, 60);
            this.tscustomer.Text = "ຂໍ້ມູນລູກຄ້າ";
            this.tscustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tscustomer.Click += new System.EventHandler(this.tscustomer_Click);
            // 
            // tsstock
            // 
            this.tsstock.AutoSize = false;
            this.tsstock.Font = new System.Drawing.Font("Noto Sans Lao", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsstock.ForeColor = System.Drawing.Color.Black;
            this.tsstock.Image = global::testPos.Properties.Resources.a;
            this.tsstock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsstock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsstock.Name = "tsstock";
            this.tsstock.Size = new System.Drawing.Size(95, 60);
            this.tsstock.Text = "ຄັງສິນຄ້າ";
            this.tsstock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsstock.Click += new System.EventHandler(this.tsstock_Click);
            // 
            // tssale
            // 
            this.tssale.AutoSize = false;
            this.tssale.Font = new System.Drawing.Font("Noto Sans Lao", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssale.ForeColor = System.Drawing.Color.Black;
            this.tssale.Image = global::testPos.Properties.Resources.cart;
            this.tssale.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssale.Name = "tssale";
            this.tssale.Size = new System.Drawing.Size(95, 60);
            this.tssale.Text = "ຂາຍສິນຄ້າ";
            this.tssale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tssale.Click += new System.EventHandler(this.tssale_Click);
            // 
            // tstotal
            // 
            this.tstotal.AutoSize = false;
            this.tstotal.Font = new System.Drawing.Font("Noto Sans Lao", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstotal.ForeColor = System.Drawing.Color.Black;
            this.tstotal.Image = global::testPos.Properties.Resources.reportsale;
            this.tstotal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tstotal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstotal.Name = "tstotal";
            this.tstotal.Size = new System.Drawing.Size(120, 60);
            this.tstotal.Text = "ສະຫຼຸບຍອດຂາຍ";
            this.tstotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tstotal.Click += new System.EventHandler(this.tstotal_Click);
            // 
            // tsreport
            // 
            this.tsreport.AutoSize = false;
            this.tsreport.Font = new System.Drawing.Font("Noto Sans Lao", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsreport.ForeColor = System.Drawing.Color.Black;
            this.tsreport.Image = global::testPos.Properties.Resources.report;
            this.tsreport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsreport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsreport.Name = "tsreport";
            this.tsreport.Size = new System.Drawing.Size(95, 60);
            this.tsreport.Text = "ລາຍງານ";
            this.tsreport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsreport.Click += new System.EventHandler(this.tsreport_Click);
            // 
            // tssetting
            // 
            this.tssetting.AutoSize = false;
            this.tssetting.Font = new System.Drawing.Font("Noto Sans Lao", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssetting.ForeColor = System.Drawing.Color.Black;
            this.tssetting.Image = global::testPos.Properties.Resources.setting;
            this.tssetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssetting.Name = "tssetting";
            this.tssetting.Size = new System.Drawing.Size(95, 60);
            this.tssetting.Text = "ຕັ້ງຄ່າລະບົບ";
            this.tssetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tssetting.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tslogout
            // 
            this.tslogout.AutoSize = false;
            this.tslogout.Font = new System.Drawing.Font("Noto Sans Lao", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslogout.ForeColor = System.Drawing.Color.Black;
            this.tslogout.Image = global::testPos.Properties.Resources.logout;
            this.tslogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslogout.Name = "tslogout";
            this.tslogout.Size = new System.Drawing.Size(110, 60);
            this.tslogout.Text = "ອອກຈາກລະບົບ";
            this.tslogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tslogout.Click += new System.EventHandler(this.toolStriplogout_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelChildForm.Controls.Add(this.statusStrip1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 63);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1122, 615);
            this.panelChildForm.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.Font = new System.Drawing.Font("Phetsarath OT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttid,
            this.sttname,
            this.sttuid,
            this.sttdate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1122, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttid
            // 
            this.sttid.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sttid.Name = "sttid";
            this.sttid.Size = new System.Drawing.Size(54, 26);
            this.sttid.Text = "empid";
            // 
            // sttname
            // 
            this.sttname.Name = "sttname";
            this.sttname.Size = new System.Drawing.Size(83, 26);
            this.sttname.Text = "empname";
            // 
            // sttuid
            // 
            this.sttuid.Font = new System.Drawing.Font("Phetsarath OT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sttuid.Name = "sttuid";
            this.sttuid.Size = new System.Drawing.Size(0, 26);
            this.sttuid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sttdate
            // 
            this.sttdate.Name = "sttdate";
            this.sttdate.Size = new System.Drawing.Size(78, 26);
            this.sttdate.Text = "Datetime";
            // 
            // frmtabbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 678);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.toolStrip2);
            this.Name = "frmtabbar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmtabbar_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmtabbar_FormClosed);
            this.Load += new System.EventHandler(this.frmtabbar_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tssale;
        private System.Windows.Forms.ToolStripButton tsstock;
        private System.Windows.Forms.ToolStripButton tsbarcode;
        private System.Windows.Forms.ToolStripButton tstotal;
        private System.Windows.Forms.ToolStripButton tsreport;
        private System.Windows.Forms.ToolStripButton tssetting;
        private System.Windows.Forms.ToolStripButton tslogout;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sttid;
        private System.Windows.Forms.ToolStripStatusLabel sttuid;
        private System.Windows.Forms.ToolStripStatusLabel sttname;
        private System.Windows.Forms.ToolStripStatusLabel sttdate;
        private System.Windows.Forms.ToolStripButton tscustomer;
    }
}