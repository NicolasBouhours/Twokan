namespace Twokan.ServerTests
{
    using NUnit.Framework;
    using Twokan.Client.Display;

    [TestFixture]
    public class TestGameJoin
    {

        /// <summary>
        /// Remplacer le code par un futur code existant sur le serveur 
        /// </summary>
        [Test]
        public void TestCodeExistTrue()
        {
            GameJoin gj = new GameJoin();
            bool result = gj.CheckIfCodeExist("54654646");
            Assert.AreEqual(true, result);

        }

        /// <summary>
        /// Test un code de partie faux
        /// </summary>
        [Test]
        public void TestCodeExistFalse()
        {
            GameJoin gj = new GameJoin();
            bool result = gj.CheckIfCodeExist("FFJDKS46546");
            Assert.AreEqual(false, result);

        }
    }
}
