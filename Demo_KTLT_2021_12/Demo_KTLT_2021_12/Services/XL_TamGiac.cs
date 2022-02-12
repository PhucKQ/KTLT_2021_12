using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_KTLT_2021_12.Entities;
using Demo_KTLT_2021_12.DAL;

namespace Demo_KTLT_2021_12.Services
{
    public class XL_TamGiac
    {
        public static double TinhChuVi(TAMGIAC t)
        {
            double a, b, c;
            a = XL_Diem.TinhKhoangCach(t.B, t.C);
            b = XL_Diem.TinhKhoangCach(t.A, t.C);
            c = XL_Diem.TinhKhoangCach(t.A, t.B);

            return a + b + c;
        }

        public static bool KiemTraTamGiac(TAMGIAC t)
        {
            double a, b, c;
            a = XL_Diem.TinhKhoangCach(t.B, t.C);
            b = XL_Diem.TinhKhoangCach(t.A, t.C);
            c = XL_Diem.TinhKhoangCach(t.A, t.B);

            return a + b > c && a + c > b && b + c > a;
        }

        public static bool LuuTamGiac(TAMGIAC t)
        {
            if (KiemTraTamGiac(t) == false)
            {
                return false;
            }
            LuuTruTamGiac.Luu(t);

            return true;
        }
    }
}
