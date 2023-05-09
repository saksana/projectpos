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

        private void txtmyshop_Click(object sender, EventArgs e)
        {
            txtmyshop.BackColor = Color.FromArgb(33, 33, 33);
            txtusers.BackColor = Color.FromArgb(220, 220, 220);
            txtmyshop.ForeColor = Color.White;
            txtusers.ForeColor= Color.Black;
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {

        }

        private void txtusers_Click(object sender, EventArgs e)
        {
            txtmyshop.BackColor = Color.FromArgb(220, 220, 220);
            txtusers.BackColor = Color.FromArgb(33, 33, 33);
            txtmyshop.ForeColor = Color.Black;
            txtusers.ForeColor = Color.White;
        }

        private void txtclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
