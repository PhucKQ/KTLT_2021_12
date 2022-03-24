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
    public class MH_TinhChuVi_TamGiacModel : PageModel
    {
        public string Chuoi;
        public TAMGIAC t;

        [BindProperty]
        public int xA { get; set; }
        [BindProperty]
        public int yA { get; set; }

        [BindProperty]
        public int xB { get; set; }
        [BindProperty]
        public int yB { get; set; }

        [BindProperty]
        public int xC { get; set; }
        [BindProperty]
        public int yC { get; set; }
        
        public void OnGet()
        {
            Chuoi = string.Empty;
            t.A.X = 0; t.A.Y = 0;
            t.B.X = 1; t.B.Y = 0;
            t.C.X = 0; t.C.Y = 1;
        }

        public void OnPost()
        {
            t.A.X = xA;
            t.A.Y = yA;
            t.B.X = xB;
            t.B.Y = yB;
            t.C.X = xC;
            t.C.Y = yC;

            double kq = XL_TamGiac.TinhChuVi(t);
            Chuoi = $"ket qua la {kq}";
        }
    }
}
