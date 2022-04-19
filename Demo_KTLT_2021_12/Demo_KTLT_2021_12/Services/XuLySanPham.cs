using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_KTLT_2021_12.Entities;
using Demo_KTLT_2021_12.DAL;

namespace Demo_KTLT_2021_12.Services
{
    public class XuLySanPham
    {
        public static bool TaoSanPham(SanPham p)
        {
            //kiem tra tinh hop le cua san pham
            if (string.IsNullOrWhiteSpace(p.MaSanPham) ||
                string.IsNullOrWhiteSpace(p.TenSanPham) ||
                p.Gia <= 0)
            {
                return false;
            }

            //LuuSanPham
            return LuuTruSanPham.LuuSanPham(p);
        }

        public static List<SanPham> TimKiem(string tuKhoa)
        {
            if (tuKhoa == null)
            {
                tuKhoa = string.Empty;
            }

            List<SanPham> dssp = LuuTruSanPham.DocDanhSachSanPham();
            List<SanPham> dskq = new List<SanPham>();
            foreach (SanPham sp in dssp)
            {
                if (sp.TenSanPham.Contains(tuKhoa))
                {
                    dskq.Add(sp);
                }
            }

            return dskq;
        }

        public static SanPham? DocSanPham(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return null;
            }

            List<SanPham> dssp = LuuTruSanPham.DocDanhSachSanPham();
            foreach (SanPham sp in dssp)
            {
                if (sp.MaSanPham == id)
                {
                    return sp;
                }
            }

            return null;
        }

        public static bool SuaSanPham(string id, string ten, int gia)
        {
            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(ten) ||
                gia <= 0)
            {
                return false;
            }

            SanPham? sp = DocSanPham(id);
            if (sp != null)
            {
                SanPham sanPhamMoi;
                sanPhamMoi.MaSanPham = id;
                sanPhamMoi.TenSanPham = ten;
                sanPhamMoi.Gia = gia;

                LuuTruSanPham.SuaSanPham(sanPhamMoi);
            }

            return true;
        }

        public static bool XoaSanPham(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return false;
            }
            bool kq = LuuTruSanPham.XoaSanPham(id);

            return kq;
        }
    }
}
