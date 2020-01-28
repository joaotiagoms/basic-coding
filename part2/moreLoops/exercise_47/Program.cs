using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
      int toInput = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
      int fromInput = Convert.ToInt32(Console.ReadLine());
      while (fromInput <= toInput)
      {
        Console.WriteLine(fromInput);
        fromInput = fromInput + 1;
      }
      
    }
  }
}
