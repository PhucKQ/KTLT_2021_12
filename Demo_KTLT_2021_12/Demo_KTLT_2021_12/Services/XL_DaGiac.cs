﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_KTLT_2021_12.Entities;
using Demo_KTLT_2021_12.DAL;

namespace Demo_KTLT_2021_12.Services
{
    public class XL_DaGiac
    {
        public static bool LuuDaGiac(DAGIAC d)
        {
            LuuTruDaGiac.Luu(d);

            return true;
        }

        public static DAGIAC DocDaGiac()
        {
            DAGIAC d;
            d = LuuTruDaGiac.Doc();

            return d;
        }

        public static DAGIAC KhoiTao(string chuoiDinh)
        {
            DAGIAC d;
            //chuoiDinh = "(4,5)|(1,6)|(3,7)|(4,1)"
            string[] m = chuoiDinh.Split("|", StringSplitOptions.RemoveEmptyEntries);
            d.dsDinh = new DIEM[m.Length];
            for (int i = 0; i < m.Length; i++)
            {
                d.dsDinh[i] = XL_Diem.KhoiTao(m[i]);
            }

            return d;
        }

        public static double TinhChuVi(DAGIAC d)
        {
            double kq = 0;
            for (int i = 0; i < d.dsDinh.Length - 1; i++)
            {
                kq += XL_Diem.TinhKhoangCach(d.dsDinh[i], d.dsDinh[i + 1]);
            }
            kq += XL_Diem.TinhKhoangCach(d.dsDinh[d.dsDinh.Length-1], d.dsDinh[0]);

            return kq;
        }
    }
}
