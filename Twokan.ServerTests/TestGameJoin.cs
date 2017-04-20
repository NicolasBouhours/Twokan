using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twokan.Client;

[assembly: CLSCompliant(true)]
namespace Twokan.ServerTests
{
    [TestFixture]
    public class TestGameJoin
    {

        /// <summary>
        /// [TODO] Remplacer le code par un futur code existant sur le serveur 
        /// </summary>
        [Test]
        public void TestCodeExistTrue()
        {
            GameJoin gj = new GameJoin();
            bool result = gj.checkIfCodeExist("54654646");
            Assert.AreEqual(true, result);

        }

        /// <summary>
        /// Test un code de partie faux
        /// </summary>
        [Test]
        public void TestCodeExistFalse()
        {
            GameJoin gj = new GameJoin();
            bool result = gj.checkIfCodeExist("FFJDKS46546");
            Assert.AreEqual(false, result);

        }
    }
}
