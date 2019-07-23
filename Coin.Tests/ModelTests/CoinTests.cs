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
    [TestMethod]
    public void MinCoins_ResultofOne()
    {
      Coin myCoin = new Coin();
      int testResult = myCoin.MinCoins(25);
      Assert.AreEqual(1, testResult);
    }
    [TestMethod]
    public void MinCoins_ResultofFour()
    {
      Coin myCoin = new Coin();
      int secondResult = myCoin.MinCoins(100);
      Assert.AreEqual(4, secondResult);
    }
  }
}