using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LiskovSubstitution.Models.Abstract
{
    public abstract class BasePrinter
    {
        public abstract void Print(string value);
        public abstract void Scan(string value);

    }
}
