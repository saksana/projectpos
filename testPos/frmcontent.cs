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
    public partial class frmcontent : Form
    {
        public frmcontent()
        {
            InitializeComponent();
        }
        public string user;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmcontent_Load(object sender, EventArgs e)
        {
           
        }

        private void txtclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
