namespace exercise_107
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
      this.balance = balance-10.60;
    } 
    public void DrinkCoffee()
    {
      this.balance = balance-2;
    }    
   


    public override string ToString()
    {
      return "The card has a balance of " + this.balance + " euros";
    }
  }
}