using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_KTLT_2021_12.Entities;
using Demo_KTLT_2021_12.DAL;

namespace Demo_KTLT_2021_12.Services
{
    public class XL_PhanSo
    {
        public static PHANSO TinhTong(PHANSO a, PHANSO b)
        {
            PHANSO kq;
            kq.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;

            return kq;
        }

        public static bool LuuPhanSo(PHANSO a)
        {
            if (a.MauSo == 0)
            {
                return false;
            }
            LuuTruPhanSo.Luu(a);
            return true;
        }
    }

    
}
