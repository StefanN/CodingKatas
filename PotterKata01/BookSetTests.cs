using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterKata
{
    [TestClass]
    public class BookSetTests
    {

        [TestMethod]
        public void EmptySet_CostsNothing()
        {
            BookSet set = new BookSet();
            Assert.AreEqual(0, set.CalculatePrice());
        }

        [TestMethod]
        public void OneBook_8Bucks()
        {
            BookSet set = new BookSet();
            set.AddBook(0);
            Assert.AreEqual(8, set.CalculatePrice());
        }

        [TestMethod]
        public void TwoBooks_16Bucks()
        {
            BookSet set = new BookSet();
            set.AddBook(0);
            set.AddBook(1);
            Assert.AreEqual(15.2d, set.CalculatePrice());
        }
    }
}
