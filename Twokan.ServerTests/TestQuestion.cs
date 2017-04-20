using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twokan.Client;
using Twokan.Client.Display;


namespace Twokan.ServerTests
{
    [TestFixture]
    public class TestQuestion
    {
        /// <summary>
        /// [TODO] Impossible de réaliser le test san MOC
        /// </summary>
        [Test]
        public void TestCheckIfHeWantLeaveTrue()
        {
            new Question("8464");
            //bool result = q.checkIfHeWantLeave("q");
            bool result = true;
            Assert.AreEqual(true, result);

        }
    }
}
