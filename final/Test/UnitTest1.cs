using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new Condorcet.Eshop.Services.EmailService();
            sut.SendEmail("adrien.clerbois@outlook.com");
        }
    }
}
