using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class FQuanLi : Form
    {
        public FQuanLi()
        {
            InitializeComponent();
        }

        private void quảnLíSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSanPham f = new FSanPham();
            //f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void quảnLíKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FKhachHang f = new FKhachHang();
            //f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void quảnLíĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDonHang f = new FDonHang();
            //f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
