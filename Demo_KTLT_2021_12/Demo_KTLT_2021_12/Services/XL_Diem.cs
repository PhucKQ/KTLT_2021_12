using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_KTLT_2021_12.Entities;
using Demo_KTLT_2021_12.DAL;

namespace Demo_KTLT_2021_12.Services
{
    public class XL_Diem
    {
        public static double TinhKhoangCach(DIEM a, DIEM b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X)
                + (a.Y - b.Y) * (a.Y - b.Y));
        }

        public static bool LuuDiem(DIEM a)
        {
            LuuTruDiem.Luu(a);
            return true;
        }
    }
}
