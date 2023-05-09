using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace testPos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        ClassConnectDatabase ccd = new ClassConnectDatabase();
        private Form activeForm = null;
        private void txtlogin_Click(object sender, EventArgs e)
        {
           
            frmtabbar frm = new frmtabbar();
            frm.Show();

        }

            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ccd.connectDatabase();
            txtusername.Focus();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            lbnulluser.Visible = false;
            lberror.Visible = false;
        }

        private void txtusername_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            string username = txtusername.Text;
            username = String.Concat(username.Where(c => !char.IsWhiteSpace(c)));
            string psw = txtpassword.Text;
            psw = String.Concat(psw.Where(c => !char.IsWhiteSpace(c)));

            SqlDataAdapter daP = new SqlDataAdapter("select * from tbemployee WHERE username= N'" + username + "' AND password='" + psw + "'", ccd.conn);
            DataSet dsP = new DataSet();
            daP.Fill(dsP, "P");
            dsP.Tables[0].Clear();
            daP.Fill(dsP, "P");
            if (txtusername.Text == "" && txtpassword.Text == "")
            {
                lbnulluser.Visible = true;
                lbnullpsw.Visible = true;
                txtusername.Focus();
            }
            else if(txtusername.Text == "")
            {
                lbnulluser.Visible = true;
                txtusername.Focus();
            }
            else if (txtpassword.Text == "")
            {
                lbnullpsw.Visible = true;
                txtpassword.Focus();
            }
            else if (dsP.Tables[0].Rows.Count == 0)
            {
                lberror.Visible = true;
            }
            else
            {
                this.Hide(); 
                frmtabbar frmt = new frmtabbar();
                frmt.sid = dsP.Tables[0].Rows[0].ItemArray[0].ToString();
                frmt.sname = dsP.Tables[0].Rows[0].ItemArray[1].ToString();
                frmt.sdate = DateTime.Now.ToString();
                frmt.Show();
            }


        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            lbnullpsw.Visible = false;
            lberror.Visible = false;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtabbar frm = new frmtabbar();
            frm.Show();
        }
    }
}
