using System;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
      string userInput = "";
      while (true)
      {
        userInput=Console.ReadLine();
        if (userInput == "end")
        {
          break;
        }
        Console.WriteLine(Math.Pow((Convert.ToInt32(userInput)), 2));
        //Convert.ToString(userInput);
      }

    }
  }
}