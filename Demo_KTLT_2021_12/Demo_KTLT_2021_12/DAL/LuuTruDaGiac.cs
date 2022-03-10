using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_KTLT_2021_12.Services;
using Demo_KTLT_2021_12.Entities;
using System.IO;

namespace Demo_KTLT_2021_12.DAL
{
    public class LuuTruDaGiac
    {
        public static void Luu(DAGIAC d)
        {
            StreamWriter file = new StreamWriter("c:\\CODE\\KTLT_2021_12\\dagiac.txt");
            file.WriteLine(d.dsDinh.Length);
            for (int i = 0; i < d.dsDinh.Length; i++)
            {
                file.WriteLine($"{d.dsDinh[i].X},{d.dsDinh[i].Y}");
            }
            
            file.Close();
        }
        
        public static DAGIAC Doc()
        {
            DAGIAC d;
            StreamReader file = new StreamReader("c:\\CODE\\KTLT_2021_12\\dagiac.txt");
            int soDinh = int.Parse(file.ReadLine());
            string s = file.ReadLine();
            d.dsDinh = new DIEM[soDinh];
            for (int i = 0; i < soDinh; i++)
            {
                d.dsDinh[i] = LuuTruDiem.KhoiTaoDiem(s);
                s = file.ReadLine();
            }
            file.Close();

            return d;
        }
    }
}
