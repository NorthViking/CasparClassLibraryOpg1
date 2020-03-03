using Microsoft.VisualStudio.TestTools.UnitTesting;
using CasparClassLibraryOpg1;
using System;

namespace BogTest
{
    [TestClass()]
    public class BogTest
    {
        Bog b1 = new Bog("C# for dummies", "Caspar", 999, "1234567890123");
        [TestMethod]
        public void TitleTest()
        {
            Assert.AreEqual("C# for dummies", b1.Titel);
            Assert.AreNotEqual("javascrift for dummies", b1.Titel);
            Assert.AreNotEqual("", b1.Titel);
        }

        [TestMethod]
        public void SideTalTest()
        {
            Assert.AreEqual(999, b1.Sidetal);
            Assert.AreNotEqual(212, b1.Sidetal);
        }

        [TestMethod]
        public void Forfattertest()
        { 
            Assert.AreEqual("Caspar", b1.Forfatter);
            Assert.AreNotEqual("naspar", b1.Forfatter);
        }

        [TestMethod]
        public void IsbnTest()
        {
            Assert.AreEqual("1234567890123", b1.Isbn13);
            Assert.AreNotEqual("2345678901234", b1.Isbn13);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ForfatterOutOfRangeTest()
        {
            Bog b2 = new Bog("Bobbers", "c", 230, "2345678901234");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SideTalOutOfRangeTest()
        {
            Bog b3 = new Bog("bobbers", "CN", 1, "3456789012345");
            Bog b4 = new Bog("bobbers", "CN", 1030, "3456789012345");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsbnOutOfRangeTest()
        {
            Bog b5 = new Bog("bobbers", "CN", 233, "123456789");
        }


    }
}
