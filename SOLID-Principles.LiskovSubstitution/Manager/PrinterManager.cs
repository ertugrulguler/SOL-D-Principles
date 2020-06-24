using SOLID_Principles.LiskovSubstitution.Models.Abstract;
using SOLID_Principles.LiskovSubstitution.Models.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LiskovSubstitution.Manager
{
    class PrinterManager
    {
        BasePrinter _hpPrinter = new HPPrinter();
        BasePrinter _canonPrinter = new CanonPrinter();
        CanonPrinter _canonScanner = new CanonPrinter();
        
        public void Print(string value)
        {
            //burası sıkıntısız çalışır.
            _canonScanner.Scan(value);
            _canonPrinter.Print(value);



            _hpPrinter.Print(value);
        }
        
    }
}
