using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Models
{
    class Account
    {
        string username, password, role;

        public Account(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public Account()
        {
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
