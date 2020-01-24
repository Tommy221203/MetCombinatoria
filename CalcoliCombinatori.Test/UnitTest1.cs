using System;
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
    }
}
