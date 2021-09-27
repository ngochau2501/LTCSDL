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
    public partial class FSanPham : Form
    {
        BUS_SanPham busSP;
        public FSanPham()
        {
            InitializeComponent();
            busSP = new BUS_SanPham();
        }
        private void HienThiDSSanPham()
        {
            gVSanPham.DataSource = null;
            busSP.LayDSSanPham(gVSanPham);
            gVSanPham.Columns[0].Width = (int)(gVSanPham.Width * 0.09);
            gVSanPham.Columns[1].Width = (int)(gVSanPham.Width * 0.3);
            gVSanPham.Columns[2].Width = (int)(gVSanPham.Width * 0.1);
            gVSanPham.Columns[3].Width = (int)(gVSanPham.Width * 0.1);
            gVSanPham.Columns[4].Width = (int)(gVSanPham.Width * 0.2);
            gVSanPham.Columns[5].Width = (int)(gVSanPham.Width * 0.15);
        }

        private void gVSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVSanPham.Rows.Count)
            {
                txtTenSP.Text = gVSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoLuong.Text = gVSanPham.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDonGia.Text = gVSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbLoaiSP.Text = gVSanPham.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbNCC.Text = gVSanPham.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.TenSP = txtTenSP.Text;
            sp.SoLuong = int.Parse(txtSoLuong.Text);
            sp.DonGia = int.Parse(txtDonGia.Text.Replace(".0000", ""));
            sp.MaLoai = int.Parse(cbLoaiSP.SelectedValue.ToString());
            sp.MaNCC = int.Parse(cbNCC.SelectedValue.ToString());
            DialogResult dialogResult = MessageBox.Show("Bạn chắc muốn thêm sản phẩm này ?", "Thông báo",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (busSP.themSP(sp))
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                    busSP.LayDSSanPham(gVSanPham);
                    txtDonGia.Clear();
                    txtSoLuong.Clear();
                    txtTenSP.Clear();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại");
                }
            }
            else
            {
                return;
            }
                
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = int.Parse(gVSanPham.CurrentRow.Cells[0].Value.ToString());
            sp.TenSP = txtTenSP.Text;
            sp.SoLuong = int.Parse(txtSoLuong.Text);
            sp.DonGia = Int32.Parse(txtDonGia.Text.Replace(".0000", ""));
            sp.MaLoai = int.Parse(cbLoaiSP.SelectedValue.ToString());
            sp.MaNCC = int.Parse(cbNCC.SelectedValue.ToString());
            DialogResult dialogResult = MessageBox.Show("Bạn chắc muốn sửa sản phẩm này ?", "Thông báo",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (busSP.suaSP(sp))
                {
                    MessageBox.Show("Sữa sản phẩm thành công");
                    busSP.LayDSSanPham(gVSanPham);
                    txtDonGia.Clear();
                    txtSoLuong.Clear();
                    txtTenSP.Clear();
                }
                else
                {
                    MessageBox.Show("Sữa sản phẩm thất bại");
                }
            }
            else
            {
                return;
            }
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = int.Parse(gVSanPham.CurrentRow.Cells[0].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("Bạn chắc muốn xóa sản phẩm này ?", "Thông báo",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (busSP.xoaSP(sp))
                {
                    MessageBox.Show("Xóa sản phẩm thành công");
                    busSP.LayDSSanPham(gVSanPham);
                    txtDonGia.Clear();
                    txtSoLuong.Clear();
                    txtTenSP.Clear();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại");
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

        private void FSanPham_Load(object sender, EventArgs e)
        {
            HienThiDSSanPham();
            busSP.LayDSLoaiSP(cbLoaiSP);
            busSP.LayDSNCC(cbNCC);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = txtTim.Text;
            busSP.timSP(gVSanPham,ten);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gVSanPham.DataSource = null;
            txtTim.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtTenSP.Clear();
            busSP.LayDSSanPham(gVSanPham);
            gVSanPham.Columns[0].Width = (int)(gVSanPham.Width * 0.09);
            gVSanPham.Columns[1].Width = (int)(gVSanPham.Width * 0.3);
            gVSanPham.Columns[2].Width = (int)(gVSanPham.Width * 0.1);
            gVSanPham.Columns[3].Width = (int)(gVSanPham.Width * 0.1);
            gVSanPham.Columns[4].Width = (int)(gVSanPham.Width * 0.2);
            gVSanPham.Columns[5].Width = (int)(gVSanPham.Width * 0.15);

        }

        private void ReportSP_Click(object sender, EventArgs e)
        {
            CrystalReportSP r = new CrystalReportSP();
            FReportSP f = new FReportSP();
            r.SetDataSource(busSP.LayDSSanPham().ToList());
            f.crystalReportViewer1.ReportSource = r;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
