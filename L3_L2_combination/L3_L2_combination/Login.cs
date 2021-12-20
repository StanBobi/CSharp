using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_L2_combination
{
    class Login
    {
        private string username;
        private string parola;
        public Login(string username, string parola)
        {
            this.username = username;
            this.parola = parola;
        }

        public string Username { get { return username; } }
        public string Password { get { return parola; } }

    }
}
