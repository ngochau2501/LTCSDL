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
    class BUS_SanPham
    {
        DAO_SanPham dSanPham;
        public BUS_SanPham()
        {
            dSanPham = new DAO_SanPham();
        }
        public void LayDSLoaiSP(ComboBox cb)
        {
            cb.DataSource = dSanPham.LayDSLoaiSP();
            cb.DisplayMember = "TenLoai";
            cb.ValueMember = "MaLoai";
        }

        public void LayDSNCC(ComboBox cb)
        {
            cb.DataSource = dSanPham.LayDSLoaiNCC();
            cb.DisplayMember = "TenNCC";
            cb.ValueMember = "MaNCC";
        }
        public void LayDSSanPham(DataGridView dg)
        {
            dg.DataSource = dSanPham.LayDSSanPham();
        }
        public List<SanPham> LayDSSanPham()
        {
           return  dSanPham.LayDSSanPhamReport();
        }
        //public void DSTimSP(DataGridView dg, int ma)
        //{
        //    dg.DataSource = dSanPham.TimSP(ma);
        //}
        public void LayDSSanPham(ComboBox cb)
        {
            cb.DataSource = dSanPham.LayDSSanPham();
            cb.DisplayMember = "TenSP";
            cb.ValueMember = "MaSP";
        }
        public bool themSP(SanPham p)
        {
            try
            {
                dSanPham.themSP(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool suaSP(SanPham p)
        {
            if (dSanPham.kiemTraSP(p))
            {
                try
                {
                    dSanPham.suaSP(p);
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

        public bool xoaSP(SanPham p)
        {
            if (dSanPham.kiemTraSP(p))
            {
                try
                {
                    dSanPham.xoaSP(p);
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
        public SanPham LayThongTinSanPham(int maSP)
        {
            // kiem tra ma san pham co thi moi lay 
            return dSanPham.LayThongTinSP(maSP);
        }
        public void timSP(DataGridView dg,string ten)
        {
            dg.DataSource = dSanPham.TimSP(ten);
        }
    }
}
