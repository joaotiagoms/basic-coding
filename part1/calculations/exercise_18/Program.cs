﻿using System;

namespace exercise_18
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
      Console.WriteLine("The sum is " + (firstInt + secondInt + thirdInt));

    }
  }
}
