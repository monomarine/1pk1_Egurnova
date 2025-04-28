namespace Task_32_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kolobok kolobok = new Kolobok();
            List<Animal> animals = new List<Animal>
            {
                new Hare(),
                new Wolf(),
                new Bear(),
                new Fox()
            };

            foreach (var animal in animals)
            {
                if (!kolobok.IsAlive)
                    break;

                kolobok.Roll();
                kolobok.MeetAnimal(animal);
            }

            if (kolobok.IsAlive)
            {
                Console.WriteLine("Колобок сбежал и стал Senior .NET-разработчиком!");
            }
            else
            {
                Console.WriteLine("Game Over. Колобок не выжил в этом жестоком ООП-мире.");
            }
        }
    }
}
