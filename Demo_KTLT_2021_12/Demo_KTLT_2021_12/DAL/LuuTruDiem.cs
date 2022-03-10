using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_KTLT_2021_12.Services;
using Demo_KTLT_2021_12.Entities;
using System.IO;
using Newtonsoft.Json;

namespace Demo_KTLT_2021_12.DAL
{
    public class LuuTruDiem
    {
        public static void Luu_Diem(DIEM a)
        {
            StreamWriter file = new StreamWriter("c:\\CODE\\KTLT_2021_12\\diem.txt");
            file.Write($"{a.X},{a.Y}");
            file.Close();
        }

        public static void Luu(DIEM a)
        {
            StreamWriter file = new StreamWriter("c:\\CODE\\KTLT_2021_12\\diem.json");
            string json = JsonConvert.SerializeObject(a);
            file.WriteLine(json);
            file.Close();
        }

        public static DIEM Doc()
        {
            DIEM a;
            StreamReader file = new StreamReader("c:\\CODE\\KTLT_2021_12\\diem.json");
            string json = file.ReadToEnd();
            a = JsonConvert.DeserializeObject<DIEM>(json);
            file.Close();

            return a;
        }

        public static DIEM DocFile()
        {
            DIEM a;
            StreamReader file = new StreamReader("c:\\CODE\\KTLT_2021_12\\diem.txt");
            string s = file.ReadLine();//doc 1 dong tu tap tin
            string[] m = s.Split(',');
            a.X = int.Parse(m[0]);
            a.Y = int.Parse(m[1]);
            file.Close();

            return a;
        }

        public static DIEM KhoiTaoDiem(string s)
        {
            DIEM a;
            StreamReader file = new StreamReader("c:\\CODE\\KTLT_2021_12\\tamgiac.txt");
            string[] m = s.Split(',');
            a.X = int.Parse(m[0]);
            a.Y = int.Parse(m[1]);
            file.Close();

            return a;
        }
    }
}
