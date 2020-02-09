using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
    int oldest = 0;
    string name = "0";

    while (true)
    {
      string input = Console.ReadLine();
      if (input == "")
      {
        break;
      }
      string[] parts = input.Split(",");

      int number = Convert.ToInt32(parts[1]);
      if (oldest < number)
      {
          oldest = number;
          name = parts[0];
      }
    }
    Console.WriteLine("Name of the oldest: " + name);
    }
  }
}



