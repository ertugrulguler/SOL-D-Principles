using SOLID_Principle.DependencyInversion.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principle.DependencyInversion.Log_Manager
{
    class Logger
    {

        //bağımlılığı tersine çevirmiş olduk. Bağımlılık dışarıdan el ile veriliyor artık. İçerideki bir şeye bağımlılık kalmadı.
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
