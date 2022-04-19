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
    public class MH_DanhSachSanPhamModel : PageModel
    {
        public List<SanPham> dsSanPham;

        [BindProperty]
        public string TuKhoa { get; set; }
        
        public void OnGet()
        {
            dsSanPham = XuLySanPham.TimKiem(string.Empty);
        }

        public void OnPost()
        {
            dsSanPham = XuLySanPham.TimKiem(TuKhoa);
        }
    }
}
