using System;

namespace exercise_124
{
  class anyClass
  {
    private int value;
  public anyClass(int value)
  {
    this.value=value;
  }
    public void addValue()
    {
      this.value += 1;
    }
  }
  class Program
  {
    public static void Main(string[] args)
    {
      // Implement your program here!
    anyClass newobject = new anyClass(3);
    Console.WriteLine(newobject);

    newobject = null;
    newobject.addValue();
    
      
      
    }
  }
}
