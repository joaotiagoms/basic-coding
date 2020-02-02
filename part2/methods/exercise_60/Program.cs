using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
      PrintTriangle(4);
      PrintSquare(4);
      PrintRectangle(12, 3);
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
      int i=0;
      while (i<size)
      {
       PrintStars(size);
       i++;
      }   
    }

    public static void PrintRectangle(int width, int height)
    {
      int i=0;
      while (i<height)
      {
       PrintStars(width);
       i++;
      }    
    }

    public static void PrintTriangle(int size)
    {
        int i=1;
        while (i<=size)
        {
          PrintStars(i);
          i++;
        }   
    }
  }
}
