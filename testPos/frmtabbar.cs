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
    public partial class frmtabbar : Form
    {
        public frmtabbar()
        {
            InitializeComponent();
        }
        public string sid;
        public string sname;
        public string sdate;
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void frmtabbar_Load(object sender, EventArgs e)
        {
            
            openChildFormInPanel(new frmcontent());
            sttid.Text = "ID : "+sid;
            sttname.Text = "Name : "+sname;
            sttdate.Text = "Datetime login : "+sdate;
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStriplogout_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Close();
        }
    }
}
