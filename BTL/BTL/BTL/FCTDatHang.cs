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
    public partial class FCTDatHang : Form
    {
        #region khi bao bien
        public int maDH;
        private BUS_SanPham bSP;
        bool co = false;
        DataTable dtDonHang;
        private BUS_DatHang bDonHang;
        #endregion
        public FCTDatHang()
        {
            InitializeComponent();
            bSP = new BUS_SanPham();
        }

        private void FCTDatHang_Load(object sender, EventArgs e)
        {
            // hien thi ds sp ra combox
            bSP.LayDSSanPham(cbSP);
            co = true;
            // hien thi ma don hag
            txtMaDH.Text = maDH.ToString();
            // hien thi dataGridView co 4 cot: ProductId, UnitPrice, Quanitity, Discount
            dtDonHang = new DataTable();
            dtDonHang.Columns.Add("Mã sản phẩm");
            dtDonHang.Columns.Add("Đơn giá");
            dtDonHang.Columns.Add("Số lượng");
            dGSP.DataSource = dtDonHang;
            // dinh dang 4 cot cho GridView
            dGSP.Columns[0].Width = (int)(dGSP.Width * 0.20);
            dGSP.Columns[1].Width = (int)(dGSP.Width * 0.3);
            dGSP.Columns[2].Width = (int)(dGSP.Width * 0.3);
        }

        private void dGSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGSP.Rows.Count)
            {
                txtMaDH.Enabled = false;
                txtDonGia.Text = dGSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                numSoLuong.Text = dGSP.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void cbSP_SelectedIndexChanged(object sender, EventArgs e)
        {

            // dua vao ma san pham -> thong tin san pham
            SanPham p;
            int maSP;
            if (co)
            {
            maSP = int.Parse(cbSP.SelectedValue.ToString());
            p = bSP.LayThongTinSanPham(maSP);
            // hien thi ra cac textbox tuong ung
            txtLoaiSP.Text = p.Loai.TenLoai.ToString();
            txtNhaCC.Text = p.NhaCungCap.TenNCC.ToString();
            txtDonGia.Text = p.DonGia.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DataRow r;
            bool kiemTraSP = true;
            // ktra sp co trong dt chua 
            foreach (DataRow item in dtDonHang.Rows)
            {
                if (cbSP.SelectedValue.ToString() == item[0].ToString())
                {
                    // cap nhat so luong
                    item[2] = int.Parse(item[2].ToString()) + numSoLuong.Value;
                    kiemTraSP = false;
                    break;
                }
            }
            if (kiemTraSP)
            {
                r = dtDonHang.NewRow();
                // them 1 dong du lieu vao dataGridView
                r[0] = Int32.Parse(cbSP.SelectedValue.ToString());
                r[1] = Int32.Parse(txtDonGia.Text.Replace(".0000", ""));
                r[2] = Convert.ToInt32(numSoLuong.Value);
                dtDonHang.Rows.Add(r);
            }
        }
        
        
        private void btTaoDonHang_Click(object sender, EventArgs e)
        {
            bDonHang = new BUS_DatHang();
            DialogResult dialogResult = MessageBox.Show("Bạn chắc muốn thêm các món hàng này ?", "Thông báo",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (bDonHang.ThemCTDH(maDH, dtDonHang))
                {
                    MessageBox.Show("Đặt hàng thành công");
                    Close();
                }
                else
                {
                    MessageBox.Show("Đặt hàng thất bại");
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

        private void btSua_Click(object sender, EventArgs e)
        {
            DataRow r;
            foreach (DataRow item in dtDonHang.Rows)
            {
                if (cbSP.SelectedValue.ToString() == item[0].ToString())
                {
                    item[0] = Int32.Parse(cbSP.SelectedValue.ToString());
                    item[1] = Int32.Parse(txtDonGia.Text.Replace(".0000", ""));
                    item[2] = numSoLuong.Value;
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc xóa các sản phẩm ?", "Thông báo",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                dtDonHang.Clear();
            }
            else
            {
                return;
            }
                
        }
    }
}
