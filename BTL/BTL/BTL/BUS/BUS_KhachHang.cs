using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.DAO;
namespace BTL.BUS
{
    class BUS_KhachHang
    {
        DAO_KhachHang dKhachHang;
        public BUS_KhachHang()
        {
            dKhachHang = new DAO_KhachHang();
        }
        public void HienThiDSKhachHang(DataGridView dg)
        {
            dg.DataSource = dKhachHang.layDSKhachHang();
        }
        public List<KhachHang> HienThiDSKhachHang()
        {
            return dKhachHang.layDSKhachHangReport();
        }
        public bool ThemKhachHang(KhachHang d)
        {
            try
            {
                dKhachHang.ThemKhachHang(d);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaKhachHang(KhachHang d)
        {
            if (dKhachHang.KiemKhachHang(d))
            {
                try
                {
                    dKhachHang.suaKhachHang(d);
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
        public bool XoaDH(KhachHang d)
        {
            if (dKhachHang.KiemKhachHang(d))
            {
                try
                {
                    dKhachHang.xoaKhachHang(d);
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
        public void timKH(DataGridView dg, string ten)
        {
            dg.DataSource = dKhachHang.TimKH(ten);
        }
    }
}
