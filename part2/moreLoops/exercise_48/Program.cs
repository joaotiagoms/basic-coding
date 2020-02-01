using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int userInput = 0;
      int sumInput = 0;
      int countInput = 0;
      int evenNumber = 0;
      Console.WriteLine("Give Numbers:");
      while (userInput !=-1)
      {
        userInput = Convert.ToInt32(Console.ReadLine());
        if (userInput !=-1)
        {
          sumInput = sumInput + userInput;
          countInput = countInput + 1;
          if (userInput % 2 == 0)
          {
            evenNumber = evenNumber +1;
          }
        }
      }
      double average = sumInput/Convert.ToDouble(countInput);
      Console.WriteLine("Thx! Bye!\nSum: " + sumInput + "\nNumbers: " + countInput + "\nAverage: "+average+ "\nEven: "+evenNumber+ "\nOdd: "+(countInput-evenNumber));
      //this code is running the program well but doesn't pass the test
    }
  }
}
