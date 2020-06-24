using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosed.Models.Interfaces
{
    public interface ILogger
    {
        bool Log(string value);
    }
}
