using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      // Write your code here:
      int answer = 1;
      while (answer != 0)
      {
        Console.WriteLine("Give a number:");
        answer = Convert.ToInt32(Console.ReadLine());
        sum = sum + 1;
      }
      Console.WriteLine("Total amount of numbers: " + (sum - 1));

    }
  }
}
