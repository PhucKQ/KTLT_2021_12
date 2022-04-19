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
    public class MH_Tao_SanPhamModel : PageModel
    {
        public string Chuoi;

        [BindProperty]
        public string TenSanPham { get; set; }
        [BindProperty]
        public string MaSanPham { get; set; }
        [BindProperty]
        public int GiaSanPham { get; set; }

        public void OnGet()
        {
            Chuoi = string.Empty;
        }

        public void OnPost()
        {
            SanPham p;
            p.MaSanPham = MaSanPham;
            p.TenSanPham = TenSanPham;
            p.Gia = GiaSanPham;
            bool kq = XuLySanPham.TaoSanPham(p);
            Chuoi = $"ket qua la {kq}";
        }
    }
}
