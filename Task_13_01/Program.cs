namespace Task_13_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student("Иван", "Иванов");
            //Console.WriteLine(student.GetInfo());


            //Student student2 = new Student("Сергей", "Петров", "Иванович", new DateTime(2005, 10, 05));
            //Console.WriteLine(student2.GetInfo());

            Student st = new Student
            {
                Name = "Петр",
                Surname = "Иванов",
                Patronomyc = "Сергеевич",
                Birthday = new DateTime(2000, 01, 01)
            };

            Student st2 = new Student("Сергей", "Иванов", "Иванович", new DateTime(2005, 05, 20));
            Console.WriteLine(st2.GetInfo());
            Console.WriteLine(st2.FIO);
        }
    }
}
