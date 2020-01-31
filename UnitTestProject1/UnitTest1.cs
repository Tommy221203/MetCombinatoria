using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
            [TestMethod]

            public void TestMethod1()
            {
                int n = 0;
            BigInteger ris = EquazioniLibrary.CalcoliCombinatori.Fattoriale(n);
            BigInteger risasp = 1;
                Assert.AreEqual(risasp, ris);
            }
            [TestMethod]
            public void TestMethod2()
            {
                int n = 1;
            BigInteger ris = EquazioniLibrary.CalcoliCombinatori.Fattoriale(n);
            BigInteger risasp = 1;
                Assert.AreEqual(risasp, ris);
            }
            [TestMethod]
            public void TestMethod3()
            {
                int n = 5;
            BigInteger ris = EquazioniLibrary.CalcoliCombinatori.Fattoriale(n);
            BigInteger risasp = 120;
                Assert.AreEqual(risasp, ris);
            }
            [TestMethod]
            public void TestMethod4()
            {
                int n = 10;
            BigInteger ris = EquazioniLibrary.CalcoliCombinatori.Fattoriale(n);
            BigInteger risasp = 3628800;
                Assert.AreEqual(risasp, ris);
            }
            [DataTestMethod]
            [DataRow(5,120)]
            [DataRow(6, 720)]
            [DataRow(7, 5040)]
        public void TestMethod5(int n, long risasp)
            {
                BigInteger ris = EquazioniLibrary.CalcoliCombinatori.Fattoriale(n);
                Assert.AreEqual(risasp, ris);
            }
        }
    }

