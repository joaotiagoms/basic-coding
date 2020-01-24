using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first string:");
      string answer = Console.ReadLine();
      Console.WriteLine("Give the second string:");
      string answer2 = Console.ReadLine();
      if (answer == answer2)
      {
          Console.WriteLine("Echo!");
      }
      else
      {
          Console.WriteLine("Nope!");
      }


    }
  }
}
