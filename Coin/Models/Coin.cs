using System;
namespace Coins.Model
{
  public class Coin
  {
    private int[] coinArray = { 25, 10, 5, 1 };
    public Coin() { }

    // target value from user, returns min number of coins
    public int MinCoins(int target)
    {
      int result = int.MaxValue;
      if (target == 0)
      {
        return 0;
      }
      else
      {
        for (int i = 0; i < coinArray.Length; i++)
        {
          if(coinArray[i] <= target)
          {
            int sub_result = MinCoins(target - coinArray[i]);
            if(sub_result != int.MaxValue && sub_result + 1 < result)
            {
              result = sub_result + 1;
              return result;
            }
          }
        }
      }
      return result;
    }

  }
}