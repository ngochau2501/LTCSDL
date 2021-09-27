using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DAO
{
    
    class DAO_DatHang
    {
        QLCHNEntities db;
        public DAO_DatHang()
        {
            db = new QLCHNEntities();
        }
        public dynamic LayDSDonHang()
        {
            var ds = db.DatHangs.Select(s => new
            {
                s.MaDonHang,
                s.NgayDatHang,
                s.KhachHang.Ten,
                s.KhachHang.SoDienThoai
            }).ToList();
            return ds;
        }

        public dynamic LayDSKH()
        {
            var ds = db.KhachHangs.Select(s => new
            {
                s.MaKhachHang,
                s.Ten
            }).ToList();
            return ds;
        }
        public void ThemDonHang(DatHang d)
        {
            db.DatHangs.Add(d);
            db.SaveChanges();
        }
        public void SuaDH(DatHang d)
        {
            DatHang o = db.DatHangs.Find(d.MaDonHang);
            o.NgayDatHang = d.NgayDatHang;
            o.MaKhachHang = d.MaKhachHang;
            db.SaveChanges();
        }
        public void XoaDH(DatHang d)
        {
            DatHang o = db.DatHangs.Find(d.MaDonHang);
            db.DatHangs.Remove(o);
            db.SaveChanges();
        }
        public bool KiemTraDH(DatHang d)
        {
            DatHang o = db.DatHangs.Find(d.MaDonHang);
            if (d != null)
            {
                return true;
            }
            else
                return false;
        }
        public dynamic DSCTDH(int maDH)
        {
            var ds = db.ChiTietDonHangs.Where(s => s.MaDonHang == maDH).Select(s => new {
                s.MaDonHang,
                s.SanPham.TenSP,
                s.DonGia,
                s.SoLuong
            }).ToList();
            return ds;
        }
        public void themCTDH(ChiTietDonHang d)
        {
            db.ChiTietDonHangs.Add(d);
            db.SaveChanges();
        }
        public bool KiemTraSPDonHang(ChiTietDonHang d)
        {
            int? sl;
            sl = db.sp_KiemTraSPDonHang(d.MaDonHang, d.MaSP).FirstOrDefault();
            if (sl != 0)
                return false;
            else
                return true;
        }

    }
}
