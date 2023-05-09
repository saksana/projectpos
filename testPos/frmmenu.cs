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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
            hidesubmenu();
        }
        private void hidesubmenu()
        {
            panelmediasubmenu.Visible = false;
            panelplaylist.Visible = false;
            paneltools.Visible = false;

        }
        private void showsubmenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hidesubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            showsubmenu(panelmediasubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmaddprice());
            hidesubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmcontent());
            hidesubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnplaylistmanagement_Click(object sender, EventArgs e)
        {
            showsubmenu(panelplaylist);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnqualizer_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btntools_Click(object sender, EventArgs e)
        {
            showsubmenu(paneltools);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }
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

        private void frmmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
