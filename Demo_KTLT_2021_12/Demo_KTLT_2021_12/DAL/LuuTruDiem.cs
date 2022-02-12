using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_KTLT_2021_12.Services;
using Demo_KTLT_2021_12.Entities;
using System.IO;

namespace Demo_KTLT_2021_12.DAL
{
    public class LuuTruDiem
    {
        public static void Luu(DIEM a)
        {
            StreamWriter file = new StreamWriter("c:\\CODE\\KTLT_2021_12\\diem.txt");
            file.Write($"{a.X},{a.Y}");
            file.Close();
        }
    }
}
