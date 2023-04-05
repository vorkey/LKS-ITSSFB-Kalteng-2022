using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaStore
{
    public partial class FormMenuUtama : Form
    {
        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void BtnManageProduct_Click(object sender, EventArgs e)
        {
            new FormManageProduct();
            this.Close();
        }

        private void BtnManageUser_Click(object sender, EventArgs e)
        {
            new FormManageUser();
            this.Close();
        }

        private void BtnAddTransaction_Click(object sender, EventArgs e)
        {
            new FormAddTransaction();
            this.Close();
        }

        private void BtnViewTransaction_Click(object sender, EventArgs e)
        {
            new FormViewTransaction();
            this.Close();
        }
    }
}
