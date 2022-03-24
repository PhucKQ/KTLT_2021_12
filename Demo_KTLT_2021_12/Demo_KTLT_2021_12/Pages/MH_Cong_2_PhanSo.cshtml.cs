using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Demo_KTLT_2021_12.Entities;
using Demo_KTLT_2021_12.Services;

namespace Demo_KTLT_2021_12.Pages
{
    public class MH_Cong_2_PhanSoModel : PageModel
    {
        [BindProperty]
        public int Tu1 { get; set; }

        [BindProperty]
        public int Mau1 { get; set; }

        [BindProperty]
        public int Tu2 { get; set; }

        [BindProperty]
        public int Mau2 { get; set; }

        public string Chuoi = string.Empty;

        public void OnGet()
        {

        }

        public void OnPost()
        {
            PHANSO a, b;
            
            a.TuSo = Tu1;
            a.MauSo = Mau1;

            b.TuSo = Tu2;
            b.MauSo = Mau2;

            PHANSO kq = XL_PhanSo.TinhTong(a, b);
            Chuoi = $"Ket qua la: {kq.TuSo}/{kq.MauSo}";
        }
    }
}
