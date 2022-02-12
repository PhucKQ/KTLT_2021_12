using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_KTLT_2021_12.Services;
using Demo_KTLT_2021_12.Entities;
using System.IO;

namespace Demo_KTLT_2021_12.DAL
{
    public class LuuTruTamGiac
    {
        public static void Luu(TAMGIAC t)
        {
            StreamWriter file = new StreamWriter("c:\\CODE\\KTLT_2021_12\\tamgiac.txt");
            file.WriteLine($"{t.A.X},{t.A.Y}");
            file.WriteLine($"{t.B.X},{t.B.Y}");
            file.WriteLine($"{t.C.X},{t.C.Y}");
            file.Close();
        }
    }
}
