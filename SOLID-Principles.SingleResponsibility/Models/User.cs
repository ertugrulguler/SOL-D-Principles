using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.SingleResponsibility.Models
{

    //bu alanda city gerekli değildir. City daha çok adres için gereklidir ve adress adında bir class oluşturup oraya eklenmesi daha mantıklıdır. Daha sonra zipcode, street vb gibi yeni propertyler de rahatlıkla eklenebilir. 
    //Aynı şekilde ChangeAddress, Login ve Logout işlemleri ne kadar User classı üzerinden yapılsa da tamamıyla bu class ile ilgili değildir. O yüzden bu classın sorumlulukları düzenlenmelidir.
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


     

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
