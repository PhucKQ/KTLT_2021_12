using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_KTLT_2021_12.Entities;
using Demo_KTLT_2021_12.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo_KTLT_2021_12.Pages
{
    public class MH_DangKyModel : PageModel
    {
        public string Chuoi = string.Empty;
        public User newUser;

        [BindProperty]
        public string FName { get; set; }
        [BindProperty]
        public string LName { get; set; }
        [BindProperty]
        public string UserName { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            newUser.FirstName = FName;
            newUser.LastName = LName;
            newUser.Username = UserName;
            newUser.Password = Password;
            bool kq = XuLyUser.DangKy(newUser);
            if (kq)
            {
                Response.Redirect("/MH_DanhSachSanPham");
            }
            Chuoi = $"ket qua la {kq}";
            
        }
    }
}
