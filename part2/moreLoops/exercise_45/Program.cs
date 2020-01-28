using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int output1 = 0;
      int input1 = Convert.ToInt32(Console.ReadLine());
      while (true)
      {
        if (output1 > input1)
        {
        break;
        }
        Console.WriteLine(output1);
        output1 = output1 + 1;
      }
    }
  }
}
