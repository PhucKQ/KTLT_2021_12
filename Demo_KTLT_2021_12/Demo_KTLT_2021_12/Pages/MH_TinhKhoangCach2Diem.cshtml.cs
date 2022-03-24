using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Demo_KTLT_2021_12.Services;
using Demo_KTLT_2021_12.Entities;

namespace Demo_KTLT_2021_12.Pages
{
    public class MH_TinhKhoangCach2DiemModel : PageModel
    {
        public string Chuoi;
        public DIEM a, b;

        [BindProperty]
        public int x1 { get; set; }
        [BindProperty]
        public int y1 { get; set; }
        [BindProperty]
        public int x2 { get; set; }
        [BindProperty]
        public int y2 { get; set; }

        public void OnGet()
        {
            Chuoi = string.Empty;
            a.X = 0;
            a.Y = 1;
            b.X = 2;
            b.Y = 3;
        }

        public void OnPost()
        {
            a.X = x1;
            a.Y = y1;

            a.X = x2;
            a.Y = y2;

            double kq = XL_Diem.TinhKhoangCach(a, b);
            Chuoi = $"Ket qua la: {kq}";
        }
    }
}
