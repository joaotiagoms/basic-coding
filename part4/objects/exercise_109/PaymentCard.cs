namespace exercise_109
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
   public void AddMoney(double amount) 
   {
    if (amount > 0)
    {
      if (this.balance + amount <= 150)
      {
      balance = this.balance + amount;
      }
       else if ((this.balance + amount) > 150)
      {
      if (this.balance < 150)
       {
        this.balance = balance + (150-this.balance);
       }
      }
    }
   }


    public override string ToString()
    {
      return "The card has a balance of " + this.balance + " euros";
    }
  }
}