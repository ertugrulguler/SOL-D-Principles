using SOLID_Principles.LiskovSubstitution.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LiskovSubstitution.Models.Concrate
{
    public class CanonPrinter : BasePrinter,IScan
    {
        public override void Print(string value)
        {
            //ilgili işlemler
        }

        public  void Scan(string value)
        {
            //ilgili işlemler
        }
    }
}
