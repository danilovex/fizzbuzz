using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections.Generic;
using Dojo_FizzBuzz;

namespace FizzBuzzTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void deveRetornarListaComCemElementos()
        {
            List<int> UmACem = Program.escrever();
            Assert.AreEqual(UmACem.Count, 100);
        }

        [TestMethod]
        public void deveRetornarListaDeUmACem()
        {
            List<int> UmACem = Program.escrever();
            for (int i = 0; i < 100; i++)
            {
                Assert.IsTrue(i + 1 == UmACem[i]);
            }
        }

        [TestMethod]
        public void deveRetornarVerdadeiroParaModApenasDeTres()
        {
            Assert.IsTrue(Program.Divisivel(3, 3));
            Assert.IsFalse(Program.Divisivel(3, 5));
        }

        [TestMethod]
        public void deveRetornarVerdadeiroParaModApenasDeCinco()
        {
            Assert.IsTrue(Program.Divisivel(5, 5));
            Assert.IsFalse(Program.Divisivel(5, 3));
        }

        [TestMethod]
        public void deveRetornarFalsoParaModDeTres()
        {
            Assert.IsFalse(Program.Divisivel(2, 3));
        }

        [TestMethod]
        public void deveRetornarFalsoParaModDeCinco()
        {
            Assert.IsFalse(Program.Divisivel(2, 5));
        }

        [TestMethod]
        public void deveRetornarVerdadeiroParaModDeTresECinco()
        {
            var entrada = 15;

            Assert.IsTrue(Program.Divisivel(entrada, 5));
            Assert.IsTrue(Program.Divisivel(entrada, 3));
        }

        [TestMethod]
        public void deveRetornarFizzParaModTres()
        {
            var entrada = 21;

            Assert.AreEqual(Program.ObterFizzBuzz(entrada), "FIZZ");
        }
        [TestMethod]
        public void deveRetornarBUZZParaModCinco()
        {
            var entrada = 20;

            Assert.AreEqual(Program.ObterFizzBuzz(entrada), "BUZZ");
        }
        [TestMethod]
        public void deveRetornarFIZZBUZZParaModCincoETres()
        {
            var entrada = 15;

            Assert.AreEqual(Program.ObterFizzBuzz(entrada), "FIZZBUZZ");
        }
    }
}
