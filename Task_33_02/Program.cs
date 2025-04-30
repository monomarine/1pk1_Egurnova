namespace Task_33_02
{
    internal class Program
    {
        //пример реализации интерфейса IComporable для возможности сортировки
        //коллекций из пользовательских типов
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    FIO = "Иванов ИИ",
                    Id = Guid.NewGuid(),
                },
                 new Student
                 {
                     FIO = "Акимов АА",
                     Id = Guid.NewGuid(),
                 },
                  new Student
                  {
                     FIO = "Волков ДИ",
                     Id = Guid.NewGuid(),
                  }
            };

            foreach (var student in students)
                Console.WriteLine(student);

            students.Sort(); //если в классе Student не был бы реализован интерфейс IComporable
            //то попытка отсортировать данную коллекцию привела бы к ошибке

            Console.WriteLine("--------------после сортировки\n\n");
            foreach (var student in students)
                Console.WriteLine(student);
        }
    }
}
