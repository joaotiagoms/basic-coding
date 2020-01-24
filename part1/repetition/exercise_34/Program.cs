using System;

namespace exercise_34
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      string answer = ("start");
      while (answer != ("no"))
      {
        Console.WriteLine("Do you want to continue?");
        answer = Console.ReadLine();
      }

    }
  }
}
