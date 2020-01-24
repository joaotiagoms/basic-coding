using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your percent [0 - 100]:");
      string grade = Console.ReadLine();
      int gradeInt = Convert.ToInt32(grade);
      if (gradeInt < 0)
      {
         Console.WriteLine("Impossible");
      }
      else if (gradeInt <= 49)
      {
          Console.WriteLine("Fail");
      }
       else if (gradeInt <= 59)
      {
          Console.WriteLine("Grade: 1");
      }
       else if (gradeInt <= 69)
      {
          Console.WriteLine("Grade: 2");
      }
       else if (gradeInt <= 79)
      {
          Console.WriteLine("Grade: 3");
      }
       else if (gradeInt <= 89)
      {
          Console.WriteLine("Grade: 4");
      }
       else if (gradeInt <= 100)
      {
          Console.WriteLine("Grade: 5");
      }
       else
      {
          Console.WriteLine("Outstanding!");
      }

    }
  }
}
