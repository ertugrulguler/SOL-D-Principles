using SOLID_Principle.DependencyInversion.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principle.DependencyInversion.Log_Manager
{
    public class XmlLog:ILogger
    {
        public bool Log(string value)
        {
            //ilgili işlemler
            return true;
        }
    }
}
