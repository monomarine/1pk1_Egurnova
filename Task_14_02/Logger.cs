using System;
using System.Collections.Generic;
using System.Linq;
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

        static Logger()
        {
            log = "";
        }
        public static void Write(string message) 
        {
            log += message += "\n";
        }

        public static string Read() 
        {
            return log;
        }
    }
}
