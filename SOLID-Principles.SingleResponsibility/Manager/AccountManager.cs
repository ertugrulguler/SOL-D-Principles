using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.SingleResponsibility.Manager
{
    class AccountManager
    {
        //Login ve Logout metotları artık olması gerektiği yerde. User classı artık tek bir amaca hitap ediyor.
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
