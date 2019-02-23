using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAritmetica
{
    [TestClass]
    public class UTsuma
    {
        [TestMethod]
        public void tmSuma1()
        {
            //Arrange
            const int a = 1;
            const int b = 2;
            const int c = 3;

            //Act
            using (srvAritmetica.WSaritmeticaClient cliente = new srvAritmetica.WSaritmeticaClient())
            {
                var rsp=cliente.sumar(a, b);

                //assert
                Assert.AreEqual(c, rsp.resultado);
            }
        }

        [TestMethod]
        public void tmSumaNegativa()
        {
            const int a = 3;
            const int b = -5;
            const int c = -2;

            //act
            using (srvAritmetica.WSaritmeticaClient cliente = new srvAritmetica.WSaritmeticaClient())
            {
                var rsp = cliente.sumar(a, b);

                Assert.AreEqual(c, rsp.resultado);
                Assert.AreNotEqual(rsp.Error.Length, 0);
            }
        }
    }
}
