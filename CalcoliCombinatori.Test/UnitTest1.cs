using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcoliCombinatori.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            long n = 0;
            long ris = EquazioniLibrary.CalcoliCombinatori.Fattoriale(n);
            long risasp = 1;
            Assert.AreEqual(risasp, ris);
        }
        [TestMethod]
        public void TestMethod2()
        {
            long n = 1;
            long ris = EquazioniLibrary.CalcoliCombinatori.Fattoriale(n);
            long risasp = 1;
            Assert.AreEqual(risasp, ris);
        }
        [TestMethod]
        public void TestMethod3()
        {
            long n = 5;
            long ris = EquazioniLibrary.CalcoliCombinatori.Fattoriale(n);
            long risasp = 120;
            Assert.AreEqual(risasp, ris);
        }
        [TestMethod]
        public void TestMethod4()
        {
            long n = 10;
            long ris = EquazioniLibrary.CalcoliCombinatori.Fattoriale(n);
            long risasp = 3628800;
            Assert.AreEqual(risasp, ris);
        }
        [TestMethod]
        public void TestMethod5()
        {
            long n = 50;
            long ris = EquazioniLibrary.CalcoliCombinatori.Fattoriale(n);
            BigInteger risasp = new BigInteger ();
            Assert.AreEqual(risasp, ris);
        }
    }
}
