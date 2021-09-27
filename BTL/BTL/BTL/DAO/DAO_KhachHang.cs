using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DAO
{
    class DAO_KhachHang
    {
        QLCHNEntities db;
        public DAO_KhachHang()
        {
            db = new QLCHNEntities();
        }
        public dynamic layDSKhachHang()
        {
            var ds = db.KhachHangs.Select(s => new
            {
                s.MaKhachHang,
                s.Ten,
                s.DiaChi,
                s.SoDienThoai,
            }).ToList();
            return ds;
        }
        public List<KhachHang> layDSKhachHangReport()
        {
            var ds = db.KhachHangs.Select(s => s).ToList();
            return ds;
        }
        public void ThemKhachHang(KhachHang d)
        {
            db.KhachHangs.Add(d);
            db.SaveChanges();
        }
        public void suaKhachHang(KhachHang d)
        {
            KhachHang o = db.KhachHangs.Find(d.MaKhachHang);
            o.Ten = d.Ten;
            o.DiaChi = d.DiaChi;
            o.SoDienThoai = d.SoDienThoai;
            db.SaveChanges();
        }
        public void xoaKhachHang(KhachHang d)
        {
            KhachHang o = db.KhachHangs.Find(d.MaKhachHang);
            db.KhachHangs.Remove(o);
            db.SaveChanges();
        }
        public bool KiemKhachHang(KhachHang d)
        {
            KhachHang o = db.KhachHangs.Find(d.MaKhachHang);
            if (d != null)
            {
                return true;
            }
            else
                return false;
        }
        public dynamic TimKH(string ten)
        {
            var sp = db.KhachHangs.Where(s => s.Ten.Contains(ten)).ToList();
            return sp;
        }

    }
}
