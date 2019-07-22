using System;
namespace Coins.Model
{
    public class Coin
    {
        private int[] coinArray = {1,5,10,25};
        public Coin(){}

        public int MinCoins(int target)
        {
            if(target == 0)
            {
                return 0;
            }
            return target;
        }
    }
} 