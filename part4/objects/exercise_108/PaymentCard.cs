namespace exercise_108
{
  public class PaymentCard
  {
    private double balance;

    public PaymentCard(double openingBalance)
    {
      // write code here
      this.balance = openingBalance;
    }
    public void EatLunch()
    {
      if (this.balance >= 10.60)
      {
      this.balance = balance-10.60;
      } 
    } 
    public void DrinkCoffee()
    {
      if (this.balance >= 2)
      {
      this.balance = balance-2;
      }
    }    
   


    public override string ToString()
    {
      return "The card has a balance of " + this.balance + " euros";
    }
  }
}