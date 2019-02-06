using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class Equazioni_test
    {
        [TestMethod]
        public void TestIsDetermired()
        {
            double a = 3;
            bool respattesa = true;
            bool resp = Equazioni.IsDetermired(a);
            Assert.AreEqual(respattesa, resp);


        }
        [TestMethod]
        public void TestIsDetermired1()
        {
            double a = 0;
            bool respattesa = false, resp = Equazioni.IsDetermired(a);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestIsDetermired2()
        {
            double a = -2;
            bool respattesa = true, resp = Equazioni.IsDetermired(a);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestIsDetermired3()
        {
            double a = 0;
            bool respattesa = false, resp = Equazioni.IsDetermired(a);
            Assert.AreEqual(respattesa, resp);
        }
    }
}
