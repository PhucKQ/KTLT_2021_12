using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_KTLT_2021_12.Entities;
using Demo_KTLT_2021_12.Services;
using System.IO;
using Newtonsoft.Json;

namespace Demo_KTLT_2021_12.DAL
{
    public class LuuTruUser
    {
        public static bool TaoMoiUser(User u)
        {
            List<User> dsUser =
                DocDanhSachUser();
            dsUser.Add(u);
            LuuDanhSachUser(dsUser);

            return true;
        }

        public static List<User> DocDanhSachUser()
        {
            StreamReader reader = new StreamReader
                ("./DAL/user.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();

            List<User> dsUser = JsonConvert.
                DeserializeObject<List<User>>(jsonString);

            return dsUser;
        }

        public static bool LuuDanhSachUser
            (List<User> dsUser)
        {
            StreamWriter writer = new StreamWriter
                ("./DAL/user.json");

            string jsonString = JsonConvert.
                SerializeObject(dsUser);
            writer.Write(jsonString);
            writer.Close();

            return true;
        }

        public static User? TimUser(User findUser)
        {
            List<User> dsUser = DocDanhSachUser();
            foreach(User user in dsUser)
            {
                if (user.Username == findUser.Username)
                {
                    return user;
                }
            }

            return null;
        }
    }
}
