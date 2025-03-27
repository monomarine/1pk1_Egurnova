namespace Task_21_02
{
    internal class Program
    {
        /*
         * Дан текст. 
         * Написать метод, который возвращает словарь, где ключ — слово, а значение — количество его
            вхождений в тексте.*/
        static void Main(string[] args)
        {
            string text =  Console.ReadLine();

            var countOfWords = GetCountOfWords(text);

            foreach (var word in countOfWords) 
            {
                Console.WriteLine($"слово \"{word.Key}\" встречается {word.Value} раз(а)");
            }
        }

        static Dictionary<string, int> GetCountOfWords(string text)
        {
            Dictionary<string, int> result = new();

            string[] words = text.Split();

            foreach (string word in words)
            {
                if (!result.ContainsKey(word)) //если в словаре нет ключа с текущим словом
                    result[word] = 1; // то в ловарь записывается 1 вхождение этого слова
                else //если в словаре уже есть такущий ключ
                    result[word]++; // то значение увеличивается на 1
            }

            return result;
        }
    }
}
