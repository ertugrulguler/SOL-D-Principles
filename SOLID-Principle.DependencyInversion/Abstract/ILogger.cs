using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principle.DependencyInversion.Abstract
{
    public interface ILogger
    {
        bool Log(string value);
    }
}
