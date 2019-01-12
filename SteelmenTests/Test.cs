using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Steelmen;

namespace SteelmenTests
{
    [TestFixture]
    public class Test
    {
        Guy guy;
        [SetUp]
        public void SetUp()
        {
            guy = new Guy()
            {
                Name = "test",
                Cash = 90
            };
        }
        [Test]
        public void AddMoneyToBankTest()
        {
            int bank = 100;
            bank += guy.GiveCash(50);
            Assert.AreEqual("test", guy.Name);
            Assert.AreEqual(90-50, guy.Cash);
            Assert.AreEqual(100+50, bank);
            

        }
    }
}
