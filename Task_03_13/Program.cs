namespace Task_03_13
{
    internal class Program
    {
        /*программа должна проанализировать ввод пользователя и 
         * подстроится по тот тип данных, который содержится в  строке
         * ввода. 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("осуществите ввод данных");
            while (true)
            {
                string tem = Console.ReadLine();    
                
                if(Int32.TryParse(tem, out int value))
                {
                    Console.WriteLine("вы ввели целое число " + value);
                }
                else if(Double.TryParse(tem, out double value2))
                    Console.WriteLine("вы ввели дробное число " + value2);
                else
                    Console.WriteLine("вы ввели строку ");
            }
        }
    }
}
