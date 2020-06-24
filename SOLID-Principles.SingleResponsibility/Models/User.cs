using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.SingleResponsibility.Models
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public void ChangeAddress(string city)
        {
            //bu alanda addresi değiştirecek kodlar yazılır...
        }

        public void Login(string username, string password)
        {
            //bu alanda bir userın login olmasıyla ilgili işlemler yapılır...
        }

        public void Logout(string username)
        {
            //bu alanda logout olma işlemi yapılır...
        }
    }


}
