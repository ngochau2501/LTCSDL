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
    public partial class FDonHang : Form
    {
        BUS_DatHang busDatHang;
        public FDonHang()
        {
            InitializeComponent();
            busDatHang = new BUS_DatHang();
        }

        private void HienThiDSDonHang()
        {
            gVDH.DataSource = null;
            busDatHang.HienThiDSDonHang(gVDH);
            gVDH.Columns[0].Width = (int)(gVDH.Width * 0.2);
            gVDH.Columns[1].Width = (int)(gVDH.Width * 0.2);
            gVDH.Columns[2].Width = (int)(gVDH.Width * 0.25);
            gVDH.Columns[3].Width = (int)(gVDH.Width * 0.25);
        }
        private void FDatHang_Load(object sender, EventArgs e)
        {
            HienThiDSDonHang();
            busDatHang.LayDSKhachHang(cbKhachHang);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DatHang donHang = new DatHang();
            donHang.NgayDatHang = dtpNgayDatHang.Value;
            donHang.MaKhachHang = int.Parse( cbKhachHang.SelectedValue.ToString());
            DialogResult dialogResult = MessageBox.Show("Bạn chắc muốn thêm đơn hàng này ?", "Thông báo",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (busDatHang.TaoDonHang(donHang))
                {
                    MessageBox.Show("Tạo đơn đặt hàng thành công");
                    busDatHang.HienThiDSDonHang(gVDH);
                }
                else
                {
                    MessageBox.Show("Tạo đơn đặt hàng thất bại");
                }
            }
            else
            {
                return;
            }
            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DatHang d = new DatHang();
            d.MaDonHang = int.Parse(txtMaDH.Text);
            d.NgayDatHang = dtpNgayDatHang.Value;
            d.MaKhachHang = int.Parse(cbKhachHang.SelectedValue.ToString());
            DialogResult dialogResult = MessageBox.Show("Bạn chắc muốn sửa đơn hàng này ?", "Thông báo",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (busDatHang.SuaDH(d))
                {
                    MessageBox.Show("Sửa đơn hàng thành công");
                    busDatHang.HienThiDSDonHang(gVDH);
                }
                else
                {
                    MessageBox.Show("Sửa đơn hàng thất bại");
                }
            }
            else
            {
                return;
            }
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DatHang d = new DatHang();
            d.MaDonHang = int.Parse(txtMaDH.Text);
            DialogResult dialogResult = MessageBox.Show("Bạn chắc muốn xóa đơn hàng này ?", "Thông báo",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (busDatHang.XoaDH(d))
                {
                    MessageBox.Show("Xóa đơn hàng thành công");
                    busDatHang.HienThiDSDonHang(gVDH);
                }
                else
                {
                    MessageBox.Show("Xóa đơn hàng thất bại");
                }
            }
            else
            {
                return;
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

        private void gVDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVDH.Rows.Count)
            {
                txtMaDH.Enabled = false;
                txtMaDH.Text = gVDH.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtpNgayDatHang.Text = gVDH.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbKhachHang.Text = gVDH.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void gVDH_DoubleClick(object sender, EventArgs e)
        {
            int ma;
            ma = int.Parse(gVDH.CurrentRow.Cells[0].Value.ToString());
            FCTDH f = new FCTDH();
            f.maDH = ma;
            f.ShowDialog();
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            FReportDH f = new FReportDH();

            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
