using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int fortyTwo = 0;
      while (fortyTwo != 42)
      {
        Console.WriteLine("Give a number:");
        fortyTwo = Convert.ToInt32(Console.ReadLine());
      }

    }
  }
}
