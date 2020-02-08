using System;
using System.Collections.Generic;

namespace exercise_79
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT CHANGE THE FOLLOWING CODE!
      int[] array = new int[10];
      array[0] = 6;
      array[1] = 2;
      array[2] = 8;
      array[3] = 1;
      array[4] = 3;
      array[5] = 0;
      array[6] = 9;
      array[7] = 7;

      Console.WriteLine("Search for?");
      int searching = Convert.ToInt32(Console.ReadLine());

      // Implement the search functionality here
      int found = 0; //this variable indicates if the search was successful or not
      for (int i = 0; i < array.Length; i++)
      {
        if (searching == array[i])
        {
          Console.WriteLine(searching + " is at index " + i+".");
          found = 1; //means a successful search that has results
        }
      }
     if (found == 0) //if search have no results
      {
      Console.WriteLine(searching + " was not found.");
      }
    }

  }
}


