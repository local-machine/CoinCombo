using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Coins.Model;

namespace Coins.Test
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void CoinConstructor_CreatesInstanceOfCoin_Coin()
        {
            Coin myCoin = new Coin();
            String str = new String("hakjsdf");
            Assert.AreEqual(typeof(String), myCoin.GetType());
            

        }
    }
}