using System;
using System.Collections.Generic;
using System.Text;

namespace GitGoryczka.ClassModel
{
    public class Account
    {
        public Account(string login, string password, UserClass @class)
        {
            Login = login;
            Password = password;
            Class = @class;
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public UserClass Class { get; set; }
    }
}
