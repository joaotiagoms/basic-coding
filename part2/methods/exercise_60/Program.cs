using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
      PrintTriangle(4);
    } 


    public static void PrintStars(int number)
    {
      int i=0;
      while (i<number)
      {
        Console.Write("*");
        i++;
      }
      Console.WriteLine("");
      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");
    }

    public static void PrintSquare(int size)
    {
      int h=0;
      while (h<size)
      {
        int w=0;
        while (w<size)
        {
          Console.Write("*");
          w++;
        }
        h++;
        Console.WriteLine("");
      }   
    }

    public static void PrintRectangle(int width, int height)
    {
      int h=0;
      while (h<height)
      {
        int w=0;
        while (w<width)
        {
          Console.Write("*");
          w++;
        }
        h++;
        Console.WriteLine("");
      }   
    }

    public static void PrintTriangle(int size)
    {
      int h=0;
      while (h<size)
      {
        int w=0;
        while (w<=h)
        {
          Console.Write("*");
          w++;
        }
        h++;
        Console.WriteLine("");
        
      }   
    }
  }
}
