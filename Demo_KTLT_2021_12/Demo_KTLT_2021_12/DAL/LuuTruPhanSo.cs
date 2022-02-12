using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Demo_KTLT_2021_12.Entities;

namespace Demo_KTLT_2021_12.DAL
{
    public class LuuTruPhanSo
    {
        public static void Luu(PHANSO a)
        {
            //code luu phan so a xuong tap tin
            StreamWriter file = new StreamWriter("c:\\CODE\\KTLT_2021_12\\phanso.txt");
            file.Write($"{a.TuSo}/{a.MauSo}");
            file.Close();
        }
    }
}
