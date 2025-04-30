using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_33_02
{
    //интерфейс IComporable является предопределнным в .NET
    //поэтому не требует отдельного описания в файле
    //поставьте указатель на название интерфейса и нажмите F12 чтобы 
    //уыидкть объявление интерфейса
    internal class Student : IComparable
    {
        public Guid Id { get; set; }
        public string FIO { get; set; }

        /// <summary>
        /// реализация интерфейса для осуществления сравнения с другим объектом
        /// </summary>
        /// <param name="obj">объект, с которым происходит сравнение</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object? obj)
        {
            //если obj можно привести к типу Student то сохраняем его в переменную stud
            if (obj is Student stud)
                //сравниваем FIO  текущего объекта с FIO объекта stud. 
                //вы вправе сами определять по какому полю будет просиходить сравнение объектов
                return FIO.CompareTo(stud.FIO);
            else
                //если приведение невозможно - генерируется соответствующее исключение, которое нужно будет обработать
                throw new ArgumentException($"{nameof(obj)} не является студентом");
        }

        //переопредяем метод ToString для того чтобы при выводе на консоль самого объекта
        //выводились данные по объекту (ID и FIO)
        public override string ToString()
        {
            return $"{Id} - студент {FIO}";
        }

    }
}
