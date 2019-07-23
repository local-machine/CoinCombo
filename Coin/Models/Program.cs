using System;


namespace Coins.Model
{

  public class Program
  {
    public static void Main()
    {
      Coin myCoin = new Coin();

      Console.WriteLine("Enter a number you'd like to make change with: ");
      int userInput = int.Parse(Console.ReadLine());
      int coinReturn = myCoin.MinCoins(userInput);
      Console.WriteLine($"You will need {coinReturn} coin(s) to make the least amount of change for {userInput}.");
      Console.WriteLine("--------------------------");
      Console.WriteLine("Would you like to make more change?");
      Console.WriteLine("Enter Y for yes or N for no: ");
      string againCheck = Console.ReadLine();
      if (againCheck.ToLower() == "y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye my love...");
      }
    }
  }
}