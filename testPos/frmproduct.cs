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
using System.IO;
namespace testPos
{
    public partial class frmproduct : Form
    {
        public frmproduct()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        ClassConnectDatabase ccd = new ClassConnectDatabase();
        int fl;
        private void enable()
        {
            pictureBox1.BackColor = Color.White;
            linkLabel1.Visible = true;
            txtid.Enabled = true;
            txtname.Enabled = true;
            txtcate.Enabled = true;
            txtprice1.Enabled = true;
            txtprice2.Enabled = true;
            txtqty.Enabled = true;
            txtdetail.Enabled = true;
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
            //showF();
        }

        private void disable()
        {
            pictureBox1.BackColor = Color.Gainsboro;
            linkLabel1.Visible = false;
            txtid.Enabled = false;
            txtname.Enabled = false;
            txtcate.Enabled = false;
            txtprice1.Enabled = false;
            txtprice2.Enabled = false;
            txtqty.Enabled = false;
            txtdetail.Enabled = false;
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
        }
        public void showdata()
        {
            da = new SqlDataAdapter("select * from tbproduct", ccd.conn);
            da.Fill(ds, "Map");
            ds.Tables[0].Clear();
            da.Fill(ds, "Map");
            DGV.DataSource = ds.Tables[0];
            DGV.Refresh();

        }
        void clear()
        {
            pictureBox1.Image = null;
            txtid.Text = "";
            txtname.Text = "";
            txtcate.Text = "";
            txtprice1.Text = "";
            txtprice2.Text = "";
            txtqty.Text = "";
            txtdetail.Text = "";
        }

        byte[] ConvertImgToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }

        }
        private void frmproduct_Load(object sender, EventArgs e)
        {
            ccd.connectDatabase();
            showdata();
            DGV.Columns[0].HeaderText = "ລະຫັດ";
            DGV.Columns[1].HeaderText = "ຊື່ສິນຄ້າ";
            DGV.Columns[2].HeaderText = "ປະເພດ";
            DGV.Columns[3].HeaderText = "ລາຄາທຶນ";
            DGV.Columns[4].HeaderText = "ລາຄາຂາຍ";
            DGV.Columns[5].HeaderText = "ຈຳນວນ";
            DGV.Columns[6].HeaderText = "ລາຍລະອຽດ";
            DGV.Columns[0].Width = 150;
            DGV.Columns[1].Width = 150;
            DGV.Columns[2].Width = 130;
            DGV.Columns[3].Width = 150;
            DGV.Columns[4].Width = 150;
            DGV.Columns[5].Width = 180;
            DGV.Columns[6].Width = 180;
            disable();
            //pictureBox1.Image = Properties.Resources.
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            fl = 1;
            clear();
            enable();
            pictureBox1.Image = Properties.Resources.add_image;
            txtqty.Value = 1;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
                if (fl == 1)
                {
                    if (txtid.Text == "")
                    {
                        MessageBox.Show("ກະລຸນາໃສ່ລະຫັດ", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtname.Focus();
                    }
                    else if (txtname.Text == "")
                    {
                        MessageBox.Show("ກະລຸນາໃສ່ຊື່", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtname.Focus();
                    }

                    else
                    {
                        da = new SqlDataAdapter("select proid from tbproduct where proid='" + txtid.Text + "'", ccd.conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count >= 1)
                        {
                            MessageBox.Show("ລະຫັດນີ້ມີຢູ່ແລ້ວ", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {
                            ccd.cmd = new SqlCommand("insert into tbproduct(proid,proname,category,price1,price2,qty,detail,date,img) values(@id,@name,@cate,@price1,@price2,@qty,@detail,@date,@img)", ccd.conn);
                            ccd.cmd.Parameters.AddWithValue("id", txtid.Text);
                            ccd.cmd.Parameters.AddWithValue("name", txtname.Text);
                            ccd.cmd.Parameters.AddWithValue("cate", txtcate.Text);
                            ccd.cmd.Parameters.AddWithValue("price1", txtprice1.Text);
                            ccd.cmd.Parameters.AddWithValue("price2", txtprice2.Text);
                            ccd.cmd.Parameters.AddWithValue("qty", txtqty.Value.ToString());
                            ccd.cmd.Parameters.AddWithValue("detail", txtdetail.Text);
                            ccd.cmd.Parameters.AddWithValue("date", DateTime.Now.ToString());
                            ccd.cmd.Parameters.AddWithValue("img", ConvertImgToByte(pictureBox1.Image));
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
                        ccd.cmd = new SqlCommand("UPDATE tbproduct set proname=@name,category=@cate,price1=@price1,price2=@price2,qty=@qty,detail=@detail,img=@img WHERE proid=@id", ccd.conn);
                        ccd.cmd.Parameters.AddWithValue("id", txtid.Text);
                        ccd.cmd.Parameters.AddWithValue("name", txtname.Text);
                        ccd.cmd.Parameters.AddWithValue("cate", txtcate.Text);
                        ccd.cmd.Parameters.AddWithValue("price1", txtprice1.Text);
                        ccd.cmd.Parameters.AddWithValue("price2", txtprice2.Text);
                        ccd.cmd.Parameters.AddWithValue("qty", txtqty.Value.ToString());
                        ccd.cmd.Parameters.AddWithValue("detail", txtdetail.Text);
                        ccd.cmd.Parameters.AddWithValue("date", DateTime.Now.ToString());
                        ccd.cmd.Parameters.AddWithValue("img", ConvertImgToByte(pictureBox1.Image));
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
            fl = 2;
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
                    ccd.cmd = new SqlCommand("delete from tbproduct WHERE proid=@id", ccd.conn);
                    ccd.cmd.Parameters.AddWithValue("id", txtid.Text);
                    ccd.cmd.ExecuteNonQuery();
                    MessageBox.Show("ລົບຂໍ້ມູນສຳເຫຼັດ");
                    showdata();
                    clear();
                }
            }
        }

        private void DGV_Click(object sender, EventArgs e)
        {
            try
            {
                txtid.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();

                txtname.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString();
                txtcate.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[2].Value.ToString();
                txtprice1.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[3].Value.ToString();
                txtprice2.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[4].Value.ToString();
                txtqty.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[5].Value.ToString();
                txtdetail.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pictureBox1.Image = null;
                DataTable dt = DGV.DataSource as DataTable;
                if (dt != null)
                {
                    DataRow row = dt.Rows[e.RowIndex];
                    pictureBox1.Image = ConvertByteArrayToImage((byte[])row["img"]);
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Jpg, Jpeg Image|*.jpg;*.jpg;*.png|PNG Image|*.png|BPM Image|*.bpm|" + "All file (*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "choose a picture...";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            openFileDialog1.ValidateNames = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                linkLabel2.Visible = true;
                //  txtfile.Text = openFileDialog1.FileName;
                //  string filename = "IMG-" + DateTime.Now.ToString("yyyyMMddhhmmss");
                //  txtname.Text = filename;
            }
            else
            {
                linkLabel2.Visible = false;
                return;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.add_image;
            linkLabel2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
