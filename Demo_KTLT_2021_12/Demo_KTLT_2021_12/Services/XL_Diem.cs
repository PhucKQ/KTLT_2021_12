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

        public static DIEM DocDiem()
        {
            DIEM kq;
            kq = LuuTruDiem.Doc();

            return kq;
        }

        public static DIEM KhoiTao(string s)
        {
            s = s.Substring(1, s.Length - 2);
            string[] chuoi = s.Split(",");
            DIEM a;
            a.X = int.Parse(chuoi[0]);
            a.Y = int.Parse(chuoi[1]);

            return a;
        }
    }
}
