using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput = "";
            int count = -1;
            while (userInput != "end")
            {
                userInput = Console.ReadLine();
                count++;
            }
            Console.WriteLine(count);

        }
    }
}
