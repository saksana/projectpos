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
    public partial class frmsaleproduct : Form
    {
        public frmsaleproduct()
        {
            InitializeComponent();
        }

        private void mybutton2_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("dd/MM/yy HH:mm:ss"));
        }

        private void frmsaleproduct_Load(object sender, EventArgs e)
        {
            string billno = DateTime.Now.ToString("ddMMyyHHmmss");
            lbbillno.Text = "ເລກບິນ : " + billno;
            
        }
    }
}
