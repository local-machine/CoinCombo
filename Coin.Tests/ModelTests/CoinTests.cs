using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Coins.Model;

namespace Coins.Test
{
    [TestClass]
    public class CoinTest
    {
        [TestMethod]
        public void CoinConstructor_CreatesInstanceOfCoin_Coin()
        {
            Coin myCoin = new Coin();
            Assert.AreEqual(typeof(Coin), myCoin.GetType());
        }

        [TestMethod]
        public void ValueIsZero_MinCoin()
        {
            int zero = 0;
            Coin testCoin = new Coin();
            int result = testCoin.MinCoins(zero);
            Assert.AreEqual(zero, result);
        }
    }
}