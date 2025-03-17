using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_02
{
    /* Напишите класс Logger, который имеет статический конструктор 
         * для инициализации статического поля, 
         * отвечающего за название файла журнала. 
         * Логирование будет осуществляться через статический метод.
        */


    internal static class Logger
    {
       
        private static string log;
        private static string criticalLog;

        static Logger()
        {
            log = "";
        }
        public static void Write(string message, MessageType messageType) 
        {
            switch(messageType)
            {
                case MessageType.LOW:
                case MessageType.MEDIUM:
                    log += message += "\n"; break;
                case MessageType.HIGHT:
                    criticalLog += message + "\n"; break;   
            }
        }

        public static string Read() 
        {
            return log;
        }
        public static string ReadCriticalLog()
        { 
            return criticalLog; 
        }
    }
}
