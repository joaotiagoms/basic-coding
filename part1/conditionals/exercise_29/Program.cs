using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first number!");
      string firstNumber = Console.ReadLine();
      int firstNumberInt = Convert.ToInt32(firstNumber);
      Console.WriteLine("Give the second number!");
      string secondNumber = Console.ReadLine();
      int secondNumberInt = Convert.ToInt32(secondNumber);
      if (firstNumberInt > secondNumberInt)
      {
          Console.WriteLine("The larger number is " + firstNumberInt + "!");
      }
      else if (firstNumberInt < secondNumberInt)
      {
          Console.WriteLine("The larger number is " + secondNumberInt + "!");
      }
      else
      {
          Console.WriteLine("They are equal!");
      }

    }
  }
}
