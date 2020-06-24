using SOLID_Principles.LiskovSubstitution.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LiskovSubstitution.Models.Concrate
{
    public class HPPrinter : BasePrinter
    {
        public override void Print(string value)
        {
            //print ile ilgili işlemler
        }

    }
}
