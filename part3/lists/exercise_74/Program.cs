using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
      Console.WriteLine("Search for?");
      string searchName = Console.ReadLine();
      int found = 0; //this variable indicates if the search was successful or not
      for (int i = 0; i < list.Count; i++)
      {
        if (searchName == list[i])
        {
          Console.WriteLine(searchName + " was found!");
          found = 1; //means a successful search that has results
        }
      }
     if (found == 0) //if search have no results
      {
      Console.WriteLine(searchName + " was not found!");
      }
    }
  }
}

