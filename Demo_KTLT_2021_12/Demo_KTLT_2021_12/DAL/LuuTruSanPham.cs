using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_KTLT_2021_12.Entities;
using Demo_KTLT_2021_12.Services;
using System.IO;
using Newtonsoft.Json;

namespace Demo_KTLT_2021_12.DAL
{
    public class LuuTruSanPham
    {
        public static bool LuuSanPham(SanPham p)
        {
            List<SanPham> danhSachSanPham = 
                DocDanhSachSanPham();
            danhSachSanPham.Add(p);
            LuuDanhSachSanPham(danhSachSanPham);

            return true;
        }

        public static List<SanPham> DocDanhSachSanPham()
        {
            StreamReader reader = new StreamReader
                ("c:\\CODE\\KTLT_2021_12\\sanpham.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();

            List<SanPham> danhSachSanPham = JsonConvert.
                DeserializeObject<List<SanPham>>(jsonString);

            return danhSachSanPham;
        }

        public static bool LuuDanhSachSanPham
            (List<SanPham> dsSP)
        {
            StreamWriter writer = new StreamWriter
                ("c:\\CODE\\KTLT_2021_12\\sanpham.json");

            string jsonString = JsonConvert.
                SerializeObject(dsSP);
            writer.Write(jsonString);
            writer.Close();

            return true;
        }

        public static bool SuaSanPham(SanPham sp)
        {
            List<SanPham> dssp = DocDanhSachSanPham();
            for (int i = 0; i < dssp.Count; i++)
            {
                if (dssp[i].MaSanPham == sp.MaSanPham)
                {
                    dssp[i] = sp;
                    LuuDanhSachSanPham(dssp);
                    return true;
                }
            }

            return false;
        }

        public static bool XoaSanPham(string id)
        {
            List<SanPham> dssp = DocDanhSachSanPham();
            for (int i = 0; i < dssp.Count; i++)
            {
                if (dssp[i].MaSanPham == id)
                {
                    dssp.RemoveAt(i);
                    LuuDanhSachSanPham(dssp);
                    return true;
                }
            }
            
            return false;
        }

    }
}
