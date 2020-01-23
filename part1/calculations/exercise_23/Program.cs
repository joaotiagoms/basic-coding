using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      string firstNumber = Console.ReadLine();
      int firstInt = Convert.ToInt32(firstNumber);
      Console.WriteLine("Give the second number!");
      string secondNumber = Console.ReadLine();
      int secondInt = Convert.ToInt32(secondNumber);
      Console.WriteLine(firstInt + " + " + secondInt + " = " + (firstInt+secondInt));
      Console.WriteLine(firstInt + " - " + secondInt + " = " + (firstInt-secondInt));
      Console.WriteLine(firstInt + " * " + secondInt + " = " + (firstInt*secondInt));
      double firstDoub = Convert.ToDouble(firstNumber);
      double secondDoub = Convert.ToDouble(secondNumber);
      Console.WriteLine(firstDoub + " / " + secondDoub + " = " + (firstDoub/secondDoub));

    }
  }
}
