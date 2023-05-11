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
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }
        public void clearcolor()
        {
            txtmyshop.BackColor = Color.FromArgb(240, 240, 240);
            txtmyshop.ForeColor = Color.Black;
            txtusers.BackColor = Color.FromArgb(240, 240, 240);
            txtusers.ForeColor = Color.Black;
            txtemployee.BackColor = Color.FromArgb(240, 240, 240);
            txtemployee.ForeColor = Color.Black;
            txtcate.BackColor = Color.FromArgb(240, 240, 240);
            txtcate.ForeColor = Color.Black;
            txtwarehouse.BackColor = Color.FromArgb(240, 240, 240);
            txtwarehouse.ForeColor = Color.Black;
        }
        public void active(Button btn)
        {
            btn.BackColor = Color.FromArgb(33, 33, 33);
            btn.ForeColor = Color.White;
        }
        private void txtmyshop_Click(object sender, EventArgs e)
        {
            clearcolor();
            active(txtmyshop);
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {

        }

        private void txtusers_Click(object sender, EventArgs e)
        {
            clearcolor();
            active(txtusers);
        }

        private void txtclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            clearcolor();
            active(txtemployee);
        }

        private void txtcate_Click(object sender, EventArgs e)
        {
            clearcolor();
            active(txtcate);
        }

        private void txtwerehouse_Click(object sender, EventArgs e)
        {
            clearcolor();
            active(txtwarehouse);
        }
    }
}
