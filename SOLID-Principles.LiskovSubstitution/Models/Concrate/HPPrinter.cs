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

        //şuanda Liskova aykırı bir yapıda 
        public override void Scan(string value)
        {
            //bu yazıcının scan özelliği yok ise??
            //bu sınıfın üst sınıfı göze alınarak bu özelliği varmış sanılıp gerekli kodlar doldurulur ise hata ile karşılaşılır. Kaldı kii yeni yazılımcının bu şekilde anlaması çok normaldir. 
            throw new NotImplementedException();
        }
    }
}
