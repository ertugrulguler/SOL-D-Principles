using SOLID_Principles.InterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.InterfaceSegregation.API_Class
{
    class Notification : IGet
    {
        //artık IBaseApi den implement edilen classlar IBaseApi'nin de IGet ten implement olmasından kaynaklı get işleminde herhangi bir sorun yaşamayacak.
        //Aynı zamanda sadece get işlemi yapacak olan classlar da IGet ten türemesi yeterli olacaktır.
        public void Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
