using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_01
{
    /// <summary>
    /// класс описывающий студента с характеристиками: имя, фамилия, отчество, дата рождения
    /// </summary>
    internal class Student
    {
        #region поля
        private string name;        //закрытое поле имени
        private string surname;     //закрытое поле фамилии
        private string patronomyc;  //закрытое поле отчества
        private DateTime birthday;  //закрытое поле даты рождения
        #endregion

        #region свойства
        //открытое свойство имени, связанное с полем имени и выполняющее предварительную проверка на попытку записать пустое имя
        public string Name
        {
            get { return name; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                if (value != null) //если приходящее значение не null
                    name = value;   //то в поле записывается приходящее значение
                else Console.WriteLine("Warning! name is empty"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }
        }
        //открытое свойство фамилии (логика совпадает с именем)
        public string Surname
        {
            get { return surname; }
            set
            {
                if (value != null)
                    surname = value;
                else Console.WriteLine("Warning! surname is empty");
            }
        }
        //открытое свойство отчетства (логика совпадает с именем)
        public string Patronomyc
        {
            get { return patronomyc; }
            set
            {
                if (value != null)
                    patronomyc = value;
                else Console.WriteLine("Warning! patronomyc is empty");
            }
        }
        //открытое свойство даты рождения
        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                if (DateTime.Now.Year -  value.Year > 14) //если текущий возраст больще 14 лет, то значение сохраняется во внутреннее поле
                    birthday = value;
                else
                    Console.WriteLine("student is too yong");
            }
        }
        #endregion

        #region методы
        /// <summary>
        /// возврат текущей информации по объекту
        /// </summary>
        /// <returns>строка с информацией</returns>
        public string GetInfo()
        {
            return $"{surname} {name} {patronomyc}\n" +
                $"дата рождения: {birthday.ToShortDateString()}";
        }
        #endregion

        #region конструкторы
        /*можно создавать неограниченное количество конструкторов 
         * для создания объектов с разным набором параметров*/

        /// <summary>
        /// конструктор создает объект студента с именем и фамилией, остальные
        /// поля остаются непроинициализированы
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        
        public Student(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        /// <summary>
        /// конструктор создает объект студента с именем, фамилией и отчетством
        /// дата рождения остается не заданной
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="patronomyc">отчетсво</param>
        public Student(string name, string surname, string patronomyc)
        {
            this.name = name;
            this.surname = surname;
            this.patronomyc = patronomyc;
        }
        /// <summary>
        /// полный конструктор, с помощью которого заполняются данными все поля
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="patronomyc">отчетство</param>
        /// <param name="bd">дата рождения</param>
        public Student(string name, string surname, string patronomyc, DateTime bd)
        {
            this.name = name;
            this.surname = surname;
            this.patronomyc = patronomyc;
            this.birthday = bd;
        }
        /// <summary>
        /// конструтор по умолчанию, который становиться недоступным как только прописываются
        /// остальные конструкторы и его необходимо явно прописать
        /// </summary>
        public Student() { }

        #endregion
    }
}
