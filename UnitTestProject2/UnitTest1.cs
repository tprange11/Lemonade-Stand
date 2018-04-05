using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arange
            string value1;
            string result;

            // Act
            value1 = "todd";
            Player player = new Player();
            player.SetPlayerName();
            result = player.DisplayPlayerName();


            // Assert
            Assert.AreEqual(value1, result);

        }
    }
}
