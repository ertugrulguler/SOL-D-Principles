using SOLID_Principles.LiskovSubstitution.Models.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LiskovSubstitution.Manager
{
    class PrinterManager
    {
        HPPrinter _hpPrinter = new HPPrinter();
        CanonPrinter _canonPrinter = new CanonPrinter();

        public void Print(string value)
        {
            //burası sıkıntısız çalışır.
            _canonPrinter.Scan(value);
            _canonPrinter.Print(value);



            _hpPrinter.Print(value);
            //scan özelliği olmadığı için NotImplementException hatası alınır.
            _hpPrinter.Scan(value);
        }
        
    }
}
