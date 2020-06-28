using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principle.DependencyInversion.Log_Manager
{
    class Logger
    {

        //şuanda Dependency Inversion prensibine uymuyoruz. Çünkü Logger classı şuanda XmlLog classına bağımlıdır. 
        private readonly XmlLog xmlLog = new XmlLog();


        public void Log(string value)
        {
            xmlLog.Log(value);
        }

    }
}
