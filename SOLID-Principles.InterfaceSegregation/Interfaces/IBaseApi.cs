using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.InterfaceSegregation.Interfaces
{
    interface IBaseApi
    {
        void Put(int id);
        void Delete(int id);
        void Post(int id);
        void Get(int id);
    }
}
