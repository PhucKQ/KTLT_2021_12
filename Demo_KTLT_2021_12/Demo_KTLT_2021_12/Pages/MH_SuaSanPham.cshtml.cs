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
    public class MH_SuaSanPhamModel : PageModel
    {
        public SanPham SanPham;
        public string Chuoi = string.Empty;
        public bool coSanPham;
        
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }

        [BindProperty]
        public string TenSP { get; set; }
        [BindProperty]
        public int GiaSP { get; set; }

        public void OnGet()
        {
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
            bool kq = XuLySanPham.SuaSanPham
                (Id, TenSP, GiaSP);
            if (kq)
            {
                //Quay lai man hinh danh sach
                Response.Redirect("/MH_DanhSachSanPham");
            }
            else 
            { 
                Chuoi = $"Ket qua la {kq}";
            }
        }
    }
}
