using SOLID_Principles.InterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.InterfaceSegregation.API_Class
{
    class Video : IBaseApi
    {
        //sıkıntı yok
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
