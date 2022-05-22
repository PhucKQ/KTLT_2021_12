using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Demo_KTLT_2021_12.Entities;
using Demo_KTLT_2021_12.Services;
using Microsoft.AspNetCore.Http;

namespace Demo_KTLT_2021_12.Pages
{
    public class MH_DangNhapModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public string Chuoi;
        public void OnGet()
        {
            Chuoi = String.Empty;
        }
        public void OnPost()
        {
            User? user = XuLyUser.DangNhap(Username, Password);
            if (user != null)
            {
                HttpContext.Session.SetString("user", user.Value.Username);
                Response.Redirect("/MH_DanhSachSanPham");
            }
            else
            {
                Chuoi = "Dang nhap khong thanh cong";
            }
        }
    }
}
