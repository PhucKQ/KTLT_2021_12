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
    public class MH_TinhChuVi_DaGiacModel : PageModel
    {
        public string Chuoi;
        public DAGIAC d;
        [BindProperty]
        public string chuoiDinh { get; set; }

        public void OnGet()
        {
            Chuoi = string.Empty;
            chuoiDinh = "(0,2)|(3,1)|(2,4)|(1,0)";
            d = XL_DaGiac.KhoiTao(chuoiDinh);
        }

        public void OnPost()
        {
            //d = XL_DaGiac.KhoiTao(chuoiDinh);
            double kq = XL_DaGiac.TinhChuVi(d);
            Chuoi = $"Ket qua la: {kq}";
        }
    }
}
