using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int userInput = Convert.ToInt32(Console.ReadLine());
      if (userInput<0)
      {
        Console.WriteLine(userInput*-1);
      }
      else
        Console.WriteLine(userInput);
    }
  }
}
