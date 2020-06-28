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
            //Liskov substitution  prensibine göre kalıtım sırasındaki bir alt sınıf üst sınıfın tüm özelliklerini tüm metotlarını
            //kullanabilmelidir. Printerlardan biri scan özelliğine sahip değildi. Base printerda önceki yapıda yanlış tanımlanmıştı.
            //artık scan özelliği IScan interfacesine alınarak, scanlama özelliği olan printer classları bu interfaceden de implement edilmelidir. Böylece daha doğru bir yapıya kavuşmuş oluruz.
            _canonScanner.Scan(value);
            _canonPrinter.Print(value);



            _hpPrinter.Print(value);
        }
        
    }
}
