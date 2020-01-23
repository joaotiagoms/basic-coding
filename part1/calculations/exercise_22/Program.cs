using System;

namespace exercise_22
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
      Console.WriteLine("Give the third number!");
      string thirdNumber = Console.ReadLine();
      int thirdInt = Convert.ToInt32(thirdNumber);
      double average = (firstInt + secondInt + thirdInt) / 3.0;
      Console.WriteLine("The average is " + average);

    }
  }
}
