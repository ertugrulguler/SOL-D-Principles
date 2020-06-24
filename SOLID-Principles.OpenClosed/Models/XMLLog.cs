using SOLID_Principles.OpenClosed.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosed.Models
{
    public class XMLLog:ILogger
    {
        public bool Log(string value)
        {
            //gerekli işlemler.
            return true;
        }
    }
}
