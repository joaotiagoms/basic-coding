using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Your speed:");
      string speed = Console.ReadLine();
      int speedInt = Convert.ToInt32(speed);
      if (speedInt > 120)
      {
        Console.WriteLine("Speeding!");
      }
      
    }
  }
}
