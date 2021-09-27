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
using BTL.BaoCao;
namespace BTL
{
    public partial class FKhachHang : Form
    {
        BUS_KhachHang busKhachHang;
        public FKhachHang()
        {
            InitializeComponent();
            busKhachHang = new BUS_KhachHang();
        }

        private void HienThiDSKhachHang()
        {
            gVKhachHang.DataSource = null;
            txtMaKH.Enabled = false;
            busKhachHang.HienThiDSKhachHang(gVKhachHang);
            gVKhachHang.Columns[0].Width = (int)(gVKhachHang.Width * 0.2);
            gVKhachHang.Columns[1].Width = (int)(gVKhachHang.Width * 0.2);
            gVKhachHang.Columns[2].Width = (int)(gVKhachHang.Width * 0.25);
            gVKhachHang.Columns[3].Width = (int)(gVKhachHang.Width * 0.3);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            KhachHang d = new KhachHang();
            d.Ten = txtHoTen.Text;
            d.DiaChi = txtDiaChi.Text;
            d.SoDienThoai = txtSdt.Text;
            DialogResult dialogResult = MessageBox.Show("Bạn chắc muốn thêm khách hàng này ?", "Thông báo",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (busKhachHang.ThemKhachHang(d))
                {
                    MessageBox.Show("Thêm khách hàng thành công");
                    busKhachHang.HienThiDSKhachHang(gVKhachHang);
                    txtHoTen.Clear();
                    txtDiaChi.Clear();
                    txtSdt.Clear();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại");
                }
            }
            else
            {
                return;
            }

                
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            KhachHang d = new KhachHang();
            d.MaKhachHang = Int32.Parse(gVKhachHang.CurrentRow.Cells[0].Value.ToString());
            d.Ten = txtHoTen.Text;
            d.DiaChi = txtDiaChi.Text;
            d.SoDienThoai = txtSdt.Text;

            DialogResult dialogResult = MessageBox.Show("Bạn chắc muốn sửa thông tin khách hàng này ?", "Thông báo",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (busKhachHang.suaKhachHang(d))
                {
                    MessageBox.Show("Sửa khách hàng thành công");
                    busKhachHang.HienThiDSKhachHang(gVKhachHang);
                    txtHoTen.Clear();
                    txtDiaChi.Clear();
                    txtSdt.Clear();
                }
                else
                {
                    MessageBox.Show("Sửa khách hàng thất bại");
                }
            }
            else
            {
                return;
            }
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            KhachHang d = new KhachHang();
            d.MaKhachHang = Int32.Parse(txtMaKH.Text);
            DialogResult dialogResult = MessageBox.Show("Bạn chắc muốn xóa khách hàng này ?", "Thông báo",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (busKhachHang.XoaDH(d))
                {
                    MessageBox.Show("Xóa khách hàng thành công");
                    busKhachHang.HienThiDSKhachHang(gVKhachHang);
                    txtHoTen.Clear();
                    txtDiaChi.Clear();
                    txtSdt.Clear();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại");
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

        private void FKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDSKhachHang();
        }

        private void gVKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVKhachHang.Rows.Count)
            {
                txtMaKH.Enabled = false;
                txtMaKH.Text = gVKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = gVKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = gVKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSdt.Text = gVKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HienThiDSKhachHang();
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSdt.Clear();
            txtDiaChi.Clear();
            txtKH.Clear();
        }

        private void btTKH_Click(object sender, EventArgs e)
        {
            string ten = txtKH.Text;
            busKhachHang.timKH(gVKhachHang, ten);
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            CrystalReportKH r = new CrystalReportKH();
            FReportKH f = new FReportKH();
            r.SetDataSource(busKhachHang.HienThiDSKhachHang());
            f.crystalReportViewer1.ReportSource = r;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
