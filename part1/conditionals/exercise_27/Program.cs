using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      string number = Console.ReadLine();
      int numberInt = Convert.ToInt32(number);
      if (numberInt <= 0)
      {
        Console.WriteLine("It is not positive");
      }
      else
      {
        Console.WriteLine("It is positive");
      }

    }
  }
}
