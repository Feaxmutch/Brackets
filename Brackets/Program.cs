namespace Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Brackets = "(()(()))";
            char leftBracket = '(';
            char rightBracket = ')';
            int currentDepth = 0;
            int maxDepth = 0;
            bool isCorrect = true;

            for (int i = 0; i < Brackets.Length; i++)
            {
                if (Brackets[i] == leftBracket)
                {
                    currentDepth++;
                }

                if (Brackets[i] == rightBracket)
                {
                    currentDepth--;
                }

                if (currentDepth < 0)
                {
                    isCorrect = false;
                    break;
                }

                if (maxDepth < currentDepth)
                {
                    maxDepth = currentDepth;
                }
            }

            if (currentDepth != 0)
            {
                isCorrect = false;
            }

            if (isCorrect)
            {
                Console.WriteLine("Строка коректная.");
                Console.WriteLine($"Максимальная вложеность: {maxDepth}");
            }
            else
            {
                Console.WriteLine("Строка не коректная.");
            }

            Console.ReadKey();
        }
    }
}
