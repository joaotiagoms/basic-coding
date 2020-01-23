using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("How many days?");
      string userDays = Console.ReadLine();
      int intDays = Convert.ToInt32(userDays);
      Console.WriteLine(intDays*24*60*60);

    }
  }
}
