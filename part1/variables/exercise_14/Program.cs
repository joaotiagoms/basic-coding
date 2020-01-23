using System;

namespace exercise_14
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give me the truth!");
      // Write your code here:
      string fakebool = Console.ReadLine();
      bool truebool = System.Convert.ToBoolean(fakebool);
      Console.WriteLine(truebool);
    }
  }
}
