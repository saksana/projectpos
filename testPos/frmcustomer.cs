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
    public partial class frmcustomer : Form
    {
        public frmcustomer()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        ClassConnectDatabase ccd = new ClassConnectDatabase();
        int fl;
        private void enable()
        {
            // txtid.Enabled = true;
            txtname.Enabled = true;
            txttel.Enabled = true;
            txtvillage.Enabled = true;
            txtdistric.Enabled = true;
            DGV.Enabled = false;
            //.....
            btnsave.Visible = true;
            btncancle.Visible = true;
            btnedit.Visible = false;
            btnadd.Visible = false;
            btnsave.Visible = true;
            btndelete.Visible = false;
            //

            DGV.ReadOnly = false;
            //
            cmbprovince.Enabled = true;
            //showF();
        }

        private void disable()
        {
            // txtid.Enabled = false;
            txtname.Enabled = false;
            txttel.Enabled = false;
            txtvillage.Enabled = false;
            txtdistric.Enabled = false;
            
            DGV.Enabled = true;
            //.....
            btnsave.Visible = false;
            btncancle.Visible = false;
            btnedit.Visible = true;
            btnadd.Visible = true;
            btnsave.Visible = false;
            btndelete.Visible = true;
            //
            DGV.ReadOnly = true;
            //
            cmbprovince.Text = null;
            cmbprovince.Enabled = false;
        }
        public void showdata()
        {
            da = new SqlDataAdapter("select * from tbcustomer", ccd.conn);
            da.Fill(ds, "Map");
            ds.Tables[0].Clear();
            da.Fill(ds, "Map");
            DGV.DataSource = ds.Tables[0];
            DGV.Refresh();

        }
        private void showP()
        {
            SqlDataAdapter daU = new SqlDataAdapter("select * from tbProvince", ccd.conn);
            DataSet dsU = new DataSet();
            daU.Fill(dsU, "F");
            cmbprovince.DataSource = dsU.Tables[0];
            cmbprovince.DisplayMember = "name";
            cmbprovince.ValueMember = "id";

        }
        void clear()
        {
            txtname.Text = "";
            txttel.Text = "";
            txtvillage.Text = "";
            txtdistric.Text = "";
            cmbprovince.Text = "";
        }

        private void frmcustomer_Load(object sender, EventArgs e)
        {
            ccd.connectDatabase();
            showdata();
            DGV.Columns[0].HeaderText = "ລະຫັດ";
            DGV.Columns[0].Visible = false;
            DGV.Columns[1].HeaderText = "ຊື່ລູກຄ້າ";
            DGV.Columns[2].HeaderText = "ເບີໂທ";
            DGV.Columns[3].HeaderText = "ບ້ານ";
            DGV.Columns[4].HeaderText = "ເມືອງ";
            DGV.Columns[5].HeaderText = "ແຂວງ";
            DGV.Columns[0].Width = 170;
            DGV.Columns[1].Width = 150;
            DGV.Columns[2].Width = 130;
            DGV.Columns[3].Width = 150;
            DGV.Columns[4].Width = 150;
            DGV.Columns[5].Width = 180;
            showP();
            disable();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            fl = 1;
            clear();
            enable();
            showP();
            cmbprovince.SelectedIndex = 2;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (fl == 1)
            {
               if (txtname.Text == "")
                {
                    MessageBox.Show("ກະລຸນາໃສ່ຊື່", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtname.Focus();
                }

                else
                {
                    da = new SqlDataAdapter("select tel from tbcustomer where tel='" + txttel.Text + "'", ccd.conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        MessageBox.Show("ເບີໂທນີ້ລົງທະບຽນແລ້ວ", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        ccd.cmd = new SqlCommand("insert into tbcustomer(cusname,tel,village,distric,province) values(@name,@tel,@village,@distric,@province)", ccd.conn);
                        ccd.cmd.Parameters.AddWithValue("name", txtname.Text);
                        ccd.cmd.Parameters.AddWithValue("tel", txttel.Text);
                        ccd.cmd.Parameters.AddWithValue("village", txtvillage.Text);
                        ccd.cmd.Parameters.AddWithValue("distric", txtdistric.Text);
                        ccd.cmd.Parameters.AddWithValue("province", cmbprovince.Text);
                        ccd.cmd.ExecuteNonQuery();
                        MessageBox.Show("ບັນທຶກສຳເຫຼັດ", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        showdata();
                        clear();
                        disable();
                    }
                }
            }
            else
            {
                if (txtname.Text == "")
                {
                    MessageBox.Show("ກະລຸນາເລືອກລູກຄ້າທີ່ຈະແກ້ໄຂ");
                }
                else
                {
                    ccd.cmd = new SqlCommand("UPDATE tbcustomer set cusname=@name,tel=@tel,village=@village,distric=@distric,province=@province WHERE cusid=@id", ccd.conn);
                    ccd.cmd.Parameters.AddWithValue("id", txtid.Text);
                    ccd.cmd.Parameters.AddWithValue("name", txtname.Text);
                    ccd.cmd.Parameters.AddWithValue("tel", txttel.Text);
                    ccd.cmd.Parameters.AddWithValue("village", txtvillage.Text);
                    ccd.cmd.Parameters.AddWithValue("distric", txtdistric.Text);
                    ccd.cmd.Parameters.AddWithValue("province", cmbprovince.Text);
                    ccd.cmd.ExecuteNonQuery();
                    MessageBox.Show("ແກ້ໄຂສຳເຫຼັດ", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    showdata();
                    disable();
                    clear();

                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("ກະລຸນາເລືອກຂໍ້ມູນທີ່ຈະແກ້ໄຂ");
            }
            else
            {
                fl = 0;
                enable();
                txtid.Enabled = false;
            }
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            clear();
            disable();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("ກະລຸນາເລືອກຂໍ້ມູນທີ່ຈະລົບ");
            }
            else
            {
                if (MessageBox.Show("ທ່ານຕ້ອງການລົບ ລະຫັດ" + txtid.Text + " ຫຼືບໍ່?", "ແຈ້ງເຕືອນ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ccd.cmd = new SqlCommand("delete from tbcustomer WHERE cusid=@id", ccd.conn);
                    ccd.cmd.Parameters.AddWithValue("id", txtid.Text);
                    ccd.cmd.ExecuteNonQuery();
                    MessageBox.Show("ລົບຂໍ້ມູນສຳເຫຼັດ");
                    showdata();
                    clear();
                }
            }
        }


        private void DGV_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtid.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
                txtname.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString();
                txttel.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[2].Value.ToString();
                txtvillage.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[3].Value.ToString();
                txtdistric.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[4].Value.ToString();
                cmbprovince.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[5].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
