using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testPos
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void ລກຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcustomer frm = new frmcustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ພະນກງານToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmemployee frm = new frmemployee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproduct frm = new frmproduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmsale frm = new frmsale();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
