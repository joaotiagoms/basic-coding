using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
      string longest = "";
      int oldest = 0;

    while (true)
    {
      string input = Console.ReadLine();
      if (input == "")
      {
      break;
      }
    string[] parts = input.Split(",");
    
    string currentName = parts[0];
    if (longest.Length < currentName.Length)
      {
      longest = currentName;
      }

    int year = Convert.ToInt32(parts[1]);
      if (oldest < (2020-year))
      {
          oldest = (2020-year);
      }

    }
    Console.WriteLine("Longest name: "+longest);
    Console.WriteLine("Highest age: " + oldest);
    }
  }
}



