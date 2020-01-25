using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int sum = 0;
      int answer = 0;
      int userAnswer = 1;
      while (userAnswer != 0)
      {
        Console.WriteLine("Give a number:");
        userAnswer = Convert.ToInt32(Console.ReadLine());
        if (userAnswer != 0)
        {
          answer = answer + userAnswer;
          sum = sum + 1;
        }
      }
      Console.WriteLine("Total sum of numbers: " + answer);
      Console.WriteLine("Total amount of numbers: " + sum);
    }
  }
}
