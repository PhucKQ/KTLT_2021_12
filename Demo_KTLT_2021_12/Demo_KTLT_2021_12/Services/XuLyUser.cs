using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_KTLT_2021_12.Entities;
using Demo_KTLT_2021_12.DAL;

namespace Demo_KTLT_2021_12.Services
{
    public class XuLyUser
    {
        public static bool DangKy(User user)
        {
            //kiem tra tinh hop le cua san pham
            if (string.IsNullOrWhiteSpace(user.FirstName) ||
                string.IsNullOrWhiteSpace(user.LastName) ||
                string.IsNullOrWhiteSpace(user.Username) ||
                string.IsNullOrWhiteSpace(user.Password))
            {
                return false;
            }

            //LuuSanPham
            return LuuTruUser.LuuUser(user);
        }
    }
}
