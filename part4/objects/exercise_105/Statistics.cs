namespace exercise_105
{
  public class Statistics
  {
    public int count { get; set; }
    public int sum { get; set; }

    public Statistics()
    {
      // initialize the variables here
      count = 0;
      sum = 0;
    }

    public void AddNumber(int number)
    {
      // write code here
      count++;
      sum = sum + number;
      
    }
  }
}