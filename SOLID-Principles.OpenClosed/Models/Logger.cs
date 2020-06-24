using SOLID_Principles.OpenClosed.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosed.Models
{

    //artık ne bir enum type'a ne de switch e ihtiyaç var. Ayrıca eski yapıda her bir oluşturulan Loglama classı için cunstructor'a da ekleme yapılıyordu. Burada interface kullanmanın da önemi anlaşılıyor.
    public class Logger
    {
        private readonly ILogger _logger;

        public Logger(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string value)
        {
            _logger.Log(value);
        }
    }
}
