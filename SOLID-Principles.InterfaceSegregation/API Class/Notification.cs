using SOLID_Principles.InterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.InterfaceSegregation.API_Class
{
    class Notification : IBaseApi
    {
        //Bildirimler için sadece get işlemi yapılır. Peki burada neden diğerleri de yer alıyor? Çünkü Interface Segregation prensibine uymuyoruz.
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(int id)
        {
            throw new NotImplementedException();
        }

        public void Put(int id)
        {
            throw new NotImplementedException();
        }
    }
}
