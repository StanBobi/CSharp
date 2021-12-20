using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucrarea4_Remaster2
{
    class LoginClass
    {
        private string username;
        private string password;

        public LoginClass(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username { get { return username; } }
        public string Password { get { return password; } }

    }
}
