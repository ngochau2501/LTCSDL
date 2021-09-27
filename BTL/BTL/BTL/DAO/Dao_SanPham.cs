using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DAO
{
    class DAO_SanPham
    {
        QLCHNEntities db;
        public DAO_SanPham()
        {
            db = new QLCHNEntities();
        }
        public dynamic LayDSSanPham()
        {
            var ds = db.SanPhams.Select(s => new
            {
                s.MaSP,
                s.TenSP,
                s.DonGia,
                s.SoLuong,
                s.Loai.TenLoai,
                s.NhaCungCap.TenNCC
            }).ToList();
            return ds;
        }
        public List<SanPham> LayDSSanPhamReport()
        {
            var ds = db.SanPhams.Select(s => s).ToList();
            return ds;
        }

        public dynamic LayDSLoaiSP()
        {
            var ds = db.Loais.Select(s => new
            {
                s.MaLoai,
                s.TenLoai
            }).ToList();
            return ds;
        }
        public dynamic LayDSLoaiNCC()
        {
            var ds = db.NhaCungCaps.Select(s => new
            {
                s.MaNCC,
                s.TenNCC
            }).ToList();
            return ds;
        }
        public void xoaSP(SanPham p)
        {
            SanPham o = db.SanPhams.Find(p.MaSP);
            db.SanPhams.Remove(o);
            db.SaveChanges();
        }

        public void themSP(SanPham p)
        {
            db.SanPhams.Add(p);
            db.SaveChanges();
        }

        public void suaSP(SanPham p)
        {
            SanPham o = db.SanPhams.Find(p.MaSP);
            o.TenSP = p.TenSP;
            o.SoLuong = p.SoLuong;
            o.DonGia = p.DonGia;
            o.MaNCC = p.MaNCC;
            o.MaLoai = p.MaLoai;
            db.SaveChanges();
        }

        public bool kiemTraSP(SanPham p)
        {
            SanPham o = db.SanPhams.Find(p.MaSP);
            if (p != null)
            {
                return true;
            }
            else
                return false;
        }
       
        public dynamic TimSP(string ten)
        {
            var sp = db.SanPhams.Where(s => s.TenSP.Contains(ten)).ToList();   
            return sp;
        }
        public SanPham LayThongTinSP(int maSP)
        {
            SanPham p = db.SanPhams.Where(s => s.MaSP == maSP)
                                           .FirstOrDefault();
            return p;
        }

    }
}
