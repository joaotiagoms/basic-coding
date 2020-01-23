using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a string:");
      string userString = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      string userInteger = Console.ReadLine();
      int realInteger = Convert.ToInt32(userInteger);
      Console.WriteLine("Give a double:");
      string userDouble = Console.ReadLine();
      double realDouble = Convert.ToDouble(userDouble);
      Console.WriteLine("Give a boolean:");
      string userBoolean = Console.ReadLine();
      bool realBool = System.Convert.ToBoolean(userBoolean);
      Console.WriteLine("Your string: " + userString);
      Console.WriteLine("Your integer: " + realInteger);
      Console.WriteLine("Your double: " + realDouble);
      Console.WriteLine("Your boolean: " + realBool);

    }
  }
}
