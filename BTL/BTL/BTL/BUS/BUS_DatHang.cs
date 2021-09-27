using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using BTL.DAO;
namespace BTL.BUS
{
    class BUS_DatHang
    {
        DAO_DatHang dDatHang;
        int maDH;
        public BUS_DatHang()
        {
            dDatHang = new DAO_DatHang();
        }
        public void HienThiDSDonHang(DataGridView dg)
        {
            dg.DataSource = dDatHang.LayDSDonHang();
        }
        public void LayDSKhachHang(ComboBox cb)
        {
            cb.DataSource = dDatHang.LayDSKH();
            cb.DisplayMember = "Ten";
            cb.ValueMember = "MaKhachHang";
        }
        public bool TaoDonHang(DatHang d)
        {
            try
            {
                dDatHang.ThemDonHang(d);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SuaDH(DatHang d)
        {
            if (dDatHang.KiemTraDH(d))
            {
                try
                {
                    dDatHang.SuaDH(d);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool XoaDH(DatHang d)
        {
            if (dDatHang.KiemTraDH(d))
            {
                try
                {
                    dDatHang.XoaDH(d);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }
        public void HienThiDSCTDH(DataGridView dg, int maDH)
        {
            dg.DataSource = dDatHang.DSCTDH(maDH);
        }
        public bool ThemCTDH(int maDH, DataTable dtDonHang)
        {
            bool ketQua = false;
            using (var tran = new TransactionScope())
            {
                try
                {
                    foreach (DataRow item in dtDonHang.Rows)
                    {
                        ChiTietDonHang d = new ChiTietDonHang();
                        d.MaDonHang = maDH;
                        d.MaSP = int.Parse(item[0].ToString());
                        d.DonGia = int.Parse(item[1].ToString());
                        d.SoLuong = short.Parse(item[2].ToString());
                        if (dDatHang.KiemTraSPDonHang(d))
                        {
                            dDatHang.themCTDH(d);
                        }
                        else
                        {
                            throw new Exception("Mã sản phẩm: " + d.MaSP + " đã tồn tại bạn không thể đặt nữa" );
                        }
                        //dDonHang.themCTDH(d);
                    }
                    tran.Complete();
                    ketQua = true;
                }
                catch (Exception ex)
                {
                    ketQua = false;// chua xu ly quai lui thao tac
                    MessageBox.Show(ex.Message);
                }
            }
            return ketQua;
        }

    }
}
