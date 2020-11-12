using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Models
{
    class Employee
    {
        int idEmp;
        string fullname, phone, email, gender, username, position, status;

        public Employee()
        {
        }

        public Employee(int idEmp, string fullname, string phone, string email, string gender, string username, string position, string status)
        {
            this.idEmp = idEmp;
            this.fullname = fullname;
            this.phone = phone;
            this.email = email;
            this.gender = gender;
            this.username = username;
            this.position = position;
            this.status = status;
        }

        public int IdEmp { get => idEmp; set => idEmp = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Username { get => username; set => username = value; }
        public string Position { get => position; set => position = value; }
        public string Status { get => status; set => status = value; }
    }
}
