using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int sum = 0;
      int answer = 1;
      while (answer != 0)
      {
        Console.WriteLine("Give a number:");
        answer = Convert.ToInt32(Console.ReadLine());
        if (answer <0)
        {
          sum = sum + 1;
        }
      }
      Console.WriteLine("Total amount of negative numbers: " + sum);

    }
  }
}
