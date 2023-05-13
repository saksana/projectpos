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
    public partial class frmdatacustomer : Form
    {
        public frmdatacustomer()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        ClassConnectDatabase ccd = new ClassConnectDatabase();
        int fl;
        string status;
        private void enable()
        {
            btnclear.Visible = false;
            //
            cmbprovince.Visible = true;
            txtprovince.Visible = false;
            //
            txtname.ReadOnly = false;
            txttel.ReadOnly = false;
            txtvillage.ReadOnly = false;
            txtdistric.ReadOnly = false;
            cmbprovince.Enabled = true;
            txtprovince.ReadOnly = false;
            txtdetail.ReadOnly = false;
            chkactive.AutoCheck = true;
            //
            DGV.Enabled = false;
           // DGV.ReadOnly = false;
            //
            btnsave.Visible = true;
            btncancle.Visible = true;
            btnedit.Visible = false;
            btnadd.Visible = false;
            btnsave.Visible = true;
            btndelete.Visible = false;
        }

        private void disable()
        {
            btnclear.Visible = false;
            //
            txtprovince.Visible = true;
            cmbprovince.Visible = false;
            // txtid.Enabled = false;
            txtname.ReadOnly = true;
            txttel.ReadOnly = true;
            txtvillage.ReadOnly = true;
            txtdistric.ReadOnly = true;
            cmbprovince.Text = null;
            txtprovince.ReadOnly = true;
            cmbprovince.Enabled = false;
            txtdetail.ReadOnly = true;
            chkactive.AutoCheck = false;
            //
            DGV.Enabled = true;
           // DGV.ReadOnly = true;
            //
            btnsave.Visible = false;
            btncancle.Visible = false;
            btnedit.Visible = true;
            btnedit.Enabled = false;
            btnadd.Visible = true;
            btnsave.Visible = false;
            btndelete.Visible = true;
            btndelete.Enabled = false;

            txtsearch.Focus();
        }
        public void showdata()
        {
            da = new SqlDataAdapter("select * from tbcustomer order by cusid desc", ccd.conn);
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
            txtid.Text = "";
            txtname.Text = "";
            txttel.Text = "";
            txtvillage.Text = "";
            txtdistric.Text = "";
            cmbprovince.Text = "";
            txtprovince.Text = "";
            txtdetail.Text = "";
            chkactive.Checked = false;
        }


        private void frmdatacustomer_Load(object sender, EventArgs e)
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
            DGV.Columns[6].HeaderText = "ລາຍລະອຽດ";
            DGV.Columns[7].HeaderText = "ສະຖານະ";
            DGV.Columns[0].Width = 170;
            DGV.Columns[1].Width = 150;
            DGV.Columns[2].Width = 130;
            DGV.Columns[3].Width = 150;
            DGV.Columns[4].Width = 150;
            DGV.Columns[5].Width = 150;
            DGV.Columns[6].Width = 150;
            DGV.Columns[7].Width = 120;
            DGV.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            DGV.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            DGV.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            DGV.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            DGV.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            DGV.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            DGV.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
            showP();
            disable();
            cmbsearch.SelectedIndex = 0;
            txtsearch.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            fl = 1;
            clear();
            enable();
            showP();
            txtname.Focus();
            cmbprovince.SelectedIndex = 2;
            chkactive.Checked = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (chkactive.Checked == true)
            {
                status = "Active";
            }
            else
            {
                status = "N";
            }

            if (fl == 1)
            {
                if (txtname.Text == "")
                {
                    MessageBox.Show("ກະລຸນາໃສ່ຊື່ລູກຄ້າ", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtname.Focus();
                } else if (txttel.Text=="") 
                {
                    MessageBox.Show("ກະລຸນາໃສ່ເບີໂທ", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txttel.Focus();
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
                        ccd.cmd = new SqlCommand("insert into tbcustomer(cusname,tel,village,distric,province,detail,status) values(@name,@tel,@village,@distric,@province,@detail,@status)", ccd.conn);
                        ccd.cmd.Parameters.AddWithValue("name", txtname.Text);
                        ccd.cmd.Parameters.AddWithValue("tel", txttel.Text);
                        ccd.cmd.Parameters.AddWithValue("village", txtvillage.Text);
                        ccd.cmd.Parameters.AddWithValue("distric", txtdistric.Text);
                        ccd.cmd.Parameters.AddWithValue("province", cmbprovince.Text);
                        ccd.cmd.Parameters.AddWithValue("detail",txtdetail.Text);
                        ccd.cmd.Parameters.AddWithValue("status", status);
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
                    ccd.cmd = new SqlCommand("UPDATE tbcustomer set cusname=@name,tel=@tel,village=@village,distric=@distric,province=@province,detail=@detail,status=@status WHERE cusid=@id", ccd.conn);
                    ccd.cmd.Parameters.AddWithValue("id", txtid.Text);
                    ccd.cmd.Parameters.AddWithValue("name", txtname.Text);
                    ccd.cmd.Parameters.AddWithValue("tel", txttel.Text);
                    ccd.cmd.Parameters.AddWithValue("village", txtvillage.Text);
                    ccd.cmd.Parameters.AddWithValue("distric", txtdistric.Text);
                    ccd.cmd.Parameters.AddWithValue("province", cmbprovince.Text);
                    ccd.cmd.Parameters.AddWithValue("detail", txtdetail.Text);
                    ccd.cmd.Parameters.AddWithValue("status", status);
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

        private void btncancle_Click_1(object sender, EventArgs e)
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
                if (MessageBox.Show("ທ່ານຕ້ອງການລົບລູກຄ້າຊື່ " + txtname.Text + " ຫຼືບໍ່?", "ແຈ້ງເຕືອນ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ccd.cmd = new SqlCommand("delete from tbcustomer WHERE cusid=@id", ccd.conn);
                    ccd.cmd.Parameters.AddWithValue("id", txtid.Text);
                    ccd.cmd.ExecuteNonQuery();
                    MessageBox.Show("ລົບຂໍ້ມູນສຳເຫຼັດ");
                    showdata();
                    clear();
                    btndelete.Enabled = false;
                    btnedit.Enabled = false;
                    txtsearch.Focus();
                    
                }
            }
        }

        private void DGV_Click(object sender, EventArgs e)
        {

        }

        private void DGV_DoubleClick(object sender, EventArgs e)
        {
            btndelete.Visible = true;
            btndelete.Enabled = true;
        }

        private void btnClearST_Click(object sender, EventArgs e)
        {
            clear();
            btnclear.Visible = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;
            txtsearch.Focus();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                btndelete.Enabled = false;
                btnedit.Enabled= true;
                txtid.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
                txtname.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString();
                txttel.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[2].Value.ToString();
                txtvillage.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[3].Value.ToString();
                txtdistric.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[4].Value.ToString();
                cmbprovince.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[5].Value.ToString();
                txtprovince.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[5].Value.ToString();
                txtdetail.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[6].Value.ToString();
                string check = DGV.Rows[DGV.CurrentRow.Index].Cells[7].Value.ToString();
                if (check == "Active")
                {
                    chkactive.Checked = true;
                }
                else
                {
                    chkactive.Checked = false;
                }
                btnclear.Visible = true;
            }
            catch
            {

            }
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string txt = txtsearch.Text;
            txt = String.Concat(txt.Where(c => !char.IsWhiteSpace(c)));
            if (txtsearch.Text == "")
            {

            }
            else if (cmbsearch.SelectedIndex == 0)
            {

                da = new SqlDataAdapter("SELECT * FROM tbcustomer where cusname LIKE N'%" + txt + "%' OR tel LIKE '%" + txt + "%'", ccd.conn);

            }
            else if (cmbsearch.SelectedIndex == 1)   
            {

                da = new SqlDataAdapter("SELECT * FROM tbcustomer where cusname LIKE N'%" + txt + "%' OR village LIKE N'%" + txt + "%' OR distric LIKE N'%" + txt + "%' OR province LIKE N'%" + txt + "%' OR tel LIKE '%" + txt + "%' OR status LIKE '" + txt + "' OR detail LIKE N'" + txt + "'", ccd.conn);

            }

            da.Fill(ds, "Map");
            ds.Tables[0].Clear();
            da.Fill(ds, "Map");
            DGV.DataSource = ds.Tables[0];
            DGV.Refresh();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                showdata();
            }
            else
            {
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsearch.Focus();
        }
    }
}
