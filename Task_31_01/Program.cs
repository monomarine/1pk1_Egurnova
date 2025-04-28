using OOP.Shapes;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Shape[] shapes =
             {
                  new Circle(5),
                  new Circle(10),
                  new Square(5),
                  new Square(10)
             };

             foreach (Shape shape in shapes)
             {
                 Console.WriteLine($"{shape.GetType()}: площадь: {shape.GetArea():F2},\tпериметр: {shape.GetPerimetr():F2}");
             }

        }
    }
}
