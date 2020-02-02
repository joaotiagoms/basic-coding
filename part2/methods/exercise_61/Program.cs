using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
      ChristmasTree(10);
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
    }

    public static void PrintSpaces(int number)
    {
      int i=0;
      while (i<number)
      {
        Console.Write(" ");
        i++;
      }
    }

    public static void PrintRightTriangle(int size)
    {
        int w=1;
        while (w<=size)
        {
          PrintSpaces(size-w);
          PrintStars(w);
          w++;
        }      
    }

    public static void ChristmasTree(int height)
    {
      int i=1;
      int s=1;
        while (i<=height)
        {
          PrintSpaces(height-i);
          PrintStars(s);
          i++;
          s=s+2;
        }  
      for (int t = 0; t < 2; t++)
      {  
        PrintSpaces((s/2)-2);
        PrintStars(3);
      } 
    }
    
  }
}
