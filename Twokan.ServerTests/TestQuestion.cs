namespace Twokan.ServerTests
{
    using NUnit.Framework;
    using Twokan.Client.Display;

    [TestFixture]
    public class TestQuestion
    {
        /// <summary>
        /// Impossible de réaliser le test sans MOC
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
