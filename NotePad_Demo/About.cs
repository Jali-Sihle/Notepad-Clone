using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad_Demo
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            lblProductName.Text = string.Format("Product Name: {0}", Application.ProductName);
            lblProductVersion.Text = string.Format("Product Version: {0}", Application.ProductVersion);
            lblCopyright.Text = "Copyright: Copyright ©  2020 by Gheko";
        }
    }
}
