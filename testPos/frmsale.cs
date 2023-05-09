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
    public partial class frmsale : Form
    {
        public frmsale()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        ClassConnectDatabase ccd = new ClassConnectDatabase();
        private void frmsale_Load(object sender, EventArgs e)
        {
            ccd.connectDatabase();
            LV.Columns.Add("ບາໂຄດ",200);
            LV.Columns.Add("ຊື່ສິນຄ້າ",200);
            LV.Columns.Add("ລາຄາ",200);
            LV.Columns.Add("ຈຳນວນ",100);
            LV.Columns.Add("ລວມລາຄາ",200);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string txt = txtbarcode.Text;
            txt = String.Concat(txt.Where(c => !char.IsWhiteSpace(c)));
            SqlDataAdapter daP = new SqlDataAdapter("select * from tbproduct WHERE proid= '" + txt + "'", ccd.conn);
            DataSet dsP = new DataSet();
            daP.Fill(dsP, "P");
            dsP.Tables[0].Clear();
            daP.Fill(dsP, "P");
            if (txtbarcode.Text == "")
            {

            }
            else if (dsP.Tables[0].Rows.Count == 0)
            {
                //MessageBox.Show("ບໍ່ມີຂໍ້ມູນລູກຄ້າ !", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                txtid.Text = dsP.Tables[0].Rows[0].ItemArray[0].ToString();
                txtname.Text = dsP.Tables[0].Rows[0].ItemArray[1].ToString();
                txtprice.Text = dsP.Tables[0].Rows[0].ItemArray[4].ToString();

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(txtqty.Text);
            int price = int.Parse(txtprice.Text);
            ListViewItem item = new ListViewItem(txtid.Text);
            item.SubItems.Add(txtname.Text);
            item.SubItems.Add(txtprice.Text);
            item.SubItems.Add(txtqty.Value.ToString());
            item.SubItems.Add((qty*price).ToString());
            LV.Items.Add(item);

            int sum = 0;
            foreach (ListViewItem lstItem in LV.Items) // listView has ListViewItem objects
            {
                sum += int.Parse(lstItem.SubItems[4].Text); // Columns 4
            }
            txttotal.Text = sum.ToString();
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            txtamount.Text = (int.Parse(txttotal.Text) - int.Parse(txtdiscount.Text)).ToString();
        }
    }
}
