﻿using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      Division(7,3);
    }

    // Write your method here:
    public static void Division(int numerator, int denominator)
    {
      Console.WriteLine((Convert.ToDouble(numerator))/(Convert.ToDouble(denominator)));
    }
    

  }
}
