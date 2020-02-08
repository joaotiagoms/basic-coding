using System;
using System.Collections.Generic;

namespace exercise_82
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your method here
      int[] array = { 5, 1, 3, 4, 2 };
      PrintArrayInStars(array);

    }

    public static void PrintArrayInStars(int[] array)
    {
      foreach (int i in array) //for each array number
      {
        int l=0;
      while (l<i) 
      {
        Console.Write("*");
        l++;
      }
      Console.WriteLine("");
      }
    }
  }
}

