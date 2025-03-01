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

            Student st = new Student();
            st.Name = "Петр";
            st.Surname = "Иванов";
            st.Patronomyc = null;
            st.Birthday = DateTime.Now
                ;

            Console.WriteLine(st.GetInfo());
        }
    }
}
