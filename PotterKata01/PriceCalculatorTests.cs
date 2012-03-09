using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterKata
{
    [TestClass]
    public class PriceCalculatorTests
    {
        [TestMethod]
        public void BuyExampleCase()
        {
            PriceCalculator calculator = new PriceCalculator();
            ////    PotterPrizeCalculator potter = new PotterPrizeCalculator();
            int[] basket = new int[] { 2, 2, 2, 1, 1 };

            double result = calculator.Calculate(basket);
            Assert.AreEqual(51.2d, result);
        }


        [TestMethod]
        public void TwoSameOneDifferentBook()
        {
            PriceCalculator calculator = new PriceCalculator();
            double result = calculator.Calculate(new int[] { 2, 1, 0, 0, 0 });
            Assert.AreEqual(23.2d, result);
        }

        [TestMethod]
        public void BuyOneBook()
        {
            PriceCalculator calculator = new PriceCalculator();
            ////    PotterPrizeCalculator potter = new PotterPrizeCalculator();
            int[] basket = new int[] { 1, 0, 0, 0, 0 };

            double result = calculator.Calculate(basket);
            Assert.AreEqual(8d, result);
        }


        [TestMethod]
        public void BuyTwoDifferentBooks()
        {
            PriceCalculator calculator = new PriceCalculator();
            ////    PotterPrizeCalculator potter = new PotterPrizeCalculator();
            int[] basket = new int[] { 1, 1, 0, 0, 0 };

            double result = calculator.Calculate(basket);
            Assert.AreEqual(15.2d, result);
        }

        [TestMethod]
        public void BuyTwoSameBooks()
        {
            PriceCalculator calculator = new PriceCalculator();
            ////    PotterPrizeCalculator potter = new PotterPrizeCalculator();
            int[] basket = new int[] { 2, 0, 0, 0, 0 };

            double result = calculator.Calculate(basket);
            Assert.AreEqual(16d, result);
        }

    }
}
