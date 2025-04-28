namespace Task_30_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person
            {
                Name = "Петров В.Н.",
                Birthday = new DateTime(2005, 2, 15)
            };

            Employee employee1 = new Employee
            {
                Name = "Иванов Д.Е.",
                Birthday = new DateTime(2000, 09, 30),
                Position = "менеджер"
            };

            //создаем сотрудника, но храним как человека
            Person person = new Employee
            {
                Name = "Иванов Д.Е.",
                Birthday = new DateTime(2000, 09, 30),
                Position = "менеджер"
            };

            //1 способ - as (возвращает null при 
            //неудачном преобразовании
            Employee emp1 = person as Employee;
            emp1?.ChangePosition("секретарь");

            //2 способ - is с приведением
            if (person is Employee emp2)
            {
                emp2.ChangePosition("рекрутер");
            }

            //3 способ - явное приведение +
            //обработка исключения
            try
            {
                Employee emp3 = (Employee)person;
                emp3.ChangePosition("бухгалтер");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("приведение не возможно");
            }
        }
    }
}
