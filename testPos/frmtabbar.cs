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
        int fl;
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
        public void clearlink()
        {
            tsbarcode.ForeColor = Color.Black;
            tscustomer.ForeColor = Color.Black;
            tslogout.ForeColor = Color.Black;
            tsreport.ForeColor = Color.Black;
            tssale.ForeColor = Color.Black;
            tssetting.ForeColor = Color.Black;
            tsstock.ForeColor = Color.Black;
            tstotal.ForeColor = Color.Black;
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = false;
            clearlink();
            tsbarcode.ForeColor = Color.OrangeRed;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStriplogout_Click(object sender, EventArgs e)
        {
            
            DialogResult dialog = MessageBox.Show("ຕ້ອງການອອກຈາກລະບົບຫຼືບໍ່ ?", "Message", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                fl = 1;
                this.Close();
               
            }
            else if (dialog == DialogResult.No)
            {
                fl = 0;
            }
        }

        private void frmtabbar_FormClosing(object sender, FormClosingEventArgs e)
        {

            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmSetting());
            statusStrip1.Visible = false;
            clearlink();
            tssetting.ForeColor = Color.OrangeRed;
            
        }

        private void tscustomer_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = false;
            clearlink();
            tscustomer.ForeColor = Color.OrangeRed;
            openChildFormInPanel(new frmdatacustomer());
        }

        private void tsstock_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = false;
            clearlink();
            tsstock.ForeColor = Color.OrangeRed;
            openChildFormInPanel(new frmwhproduct());
        }

        private void tssale_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = false;
            clearlink();
            tssale.ForeColor = Color.OrangeRed;
            openChildFormInPanel(new frmsaleproduct());
        }

        private void tstotal_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = false;
            clearlink();
            tstotal.ForeColor = Color.OrangeRed;
        }

        private void tsreport_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = false;
            clearlink();
            tsreport.ForeColor = Color.OrangeRed;
        }

        private void frmtabbar_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }
    }
}
