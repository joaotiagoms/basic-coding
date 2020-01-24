using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int numba = 1;
      while (numba !=0)
      {
        Console.WriteLine("Give a number:");
        numba = Convert.ToInt32(Console.ReadLine());
        if (numba < 0)
        {
          Console.WriteLine("That is negative");
        }
        else if (numba > 0)
        {
            Console.WriteLine(numba*numba);
        }



      }

    }
  }
}
