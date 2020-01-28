using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int input1 = Convert.ToInt32(Console.ReadLine());
      int input2 = Convert.ToInt32(Console.ReadLine());
      if (input1 > input2)
      {
        Console.WriteLine(input1 + " is greater than " + input2 + ".");
      }
      else if (input2 > input1)
      {
        Console.WriteLine(input1 + " is less than " + input2 + ".");
      }
      else
        Console.WriteLine(input1 + " is equal to " + input2 + ".");

    }
  }
}
