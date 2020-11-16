using CoffeeOnlineSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace CoffeeOnlineSystem.DAO
{
    public class CustomerDao
    {
        private Coffee context = null;
        public CustomerDao()
        {
            context = new Coffee();
        }
        public string LoginCustomer(string username, string password)
        {
            String check = null;
            password = encryption(password);
            var acc = context.Accounts.Where(dbo => dbo.username == username && dbo.password == password && dbo.role == 0).SingleOrDefault();
            if (acc == null)
            {
                return null;
            }
            check = acc.username;
            return check;
        }
        public int Register(Customer customer, Account acc)
        {
            
            encryption(acc.password);
            var account = new Account { username = acc.username, password = acc.password, role = 0 };
            var cus = new Customer {fullnameCus=customer.fullnameCus, phoneCus=customer.phoneCus,emailCus=customer.emailCus,DOBCus=customer.DOBCus,genderCus=customer.genderCus,usernameCus=customer.usernameCus,statusCus=customer.statusCus};

            context.Accounts.Add(account);
            context.Customers.Add(cus);
            int check = context.SaveChanges();
            return check;
        }
        public static string encryption(string input)
        {
            // Step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

    }
}




