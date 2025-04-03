using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_25_02
{
    /// <summary>
    /// POCO класс пользователя с логином и паролем
    /// </summary>
    internal class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public User(string login, string password) 
        { 
            Login = login;
            Password = password;
        }
    }
}
