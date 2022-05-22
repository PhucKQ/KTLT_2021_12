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
    public class MH_XoaSanPhamModel : PageModel
    {
        public string Chuoi;
        public bool coSanPham;
        public SanPham SanPham;

        [BindProperty]
        public bool XacNhan { get; set; }

        [BindProperty (SupportsGet = true)]
        public string Id { get; set; }
        
        public void OnGet()
        {
            Chuoi = string.Empty;
            SanPham? sp = XuLySanPham.DocSanPham(Id);
            if (sp != null)
            {
                SanPham = sp.Value;
                coSanPham = true;
            }
            else
            {
                Chuoi = "Khong tim thay san pham";
            }
            coSanPham = (sp != null);
        }

        public void OnPost()
        {
            bool kq;
            if (XacNhan)
            {
                kq = XuLySanPham.XoaSanPham(Id);
                Chuoi = $"Ket qua la {kq}";
            }
            else
            {
                Response.Redirect("/MH_DanhSachSanPham");
            }
        }


    }
}
