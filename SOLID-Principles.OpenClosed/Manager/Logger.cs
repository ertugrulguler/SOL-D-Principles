using SOLID_Principles.OpenClosed.Models;
using SOLID_Principles.OpenClosed.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosed.Manager
{
    public class Logger
    {
        private readonly XMLLog _xMLLog;
        private readonly DbLog _dbLog;

        public Logger(XMLLog xMLLog, DbLog dbLog)
        {
            _xMLLog = xMLLog;
            _dbLog = dbLog;
        }


        //Bu durumda yeni gelecek her bir Loglama yapısı için kendisine Log classı oluşturulacak, enum typeslara eklenecek ve burada da gerekli işlemler yapılacak. Ancak bu durum OpenClosed yapısına çok uygun gibi gözükmüyor. Yani biraz gereksiz iş yükü oluşuyor.

        public void Log(LogTypes logType, string value)
        {
            switch (logType)
            {

                case LogTypes.Xml:
                    _xMLLog.Log(value);
                    break;
                case LogTypes.Db:
                    _dbLog.Log(value);
                    break;
                default:
                    break;
            }
        }

    }
}
