using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.BUS;
namespace BTL
{
    public partial class FCTDH : Form
    {
        public int maDH;
        BUS_DatHang bDH;
        public FCTDH()
        {
            InitializeComponent();
            bDH = new BUS_DatHang();
        }
        private void LayDSCTDH(int ma)
        {
            gVCTDH.DataSource = null;
            bDH.HienThiDSCTDH(gVCTDH, ma);
            gVCTDH.Columns[0].Width = (int)(gVCTDH.Width * 0.2);
            gVCTDH.Columns[1].Width = (int)(gVCTDH.Width * 0.3);
            gVCTDH.Columns[2].Width = (int)(gVCTDH.Width * 0.2);
            gVCTDH.Columns[3].Width = (int)(gVCTDH.Width * 0.2);
        }
        private void FCTDH_Load(object sender, EventArgs e)
        {
            LayDSCTDH(maDH);
        }

        private void gVCTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVCTDH.Rows.Count) {
                txtMaDH.Enabled = false;
                txtMaDH.Text = gVCTDH.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaSP.Text = gVCTDH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonGia.Text = gVCTDH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoLuong.Text = gVCTDH.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc Thoát ?", "Thông báo",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            int ma;
            ma = int.Parse(gVCTDH.CurrentRow.Cells[0].Value.ToString());
            // goi form dat hang
            FCTDatHang f = new FCTDatHang();
            //truyen ma don hang qua
            f.maDH = ma;

            f.ShowDialog();
        }

        private void FCTDH_Activated(object sender, EventArgs e)
        {
            LayDSCTDH(maDH);
        }
    }
}
