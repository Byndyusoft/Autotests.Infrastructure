using NUnit.Framework;
using Shared.PageLogics;

namespace Tests.Tests
{
    /// <summary>
    ///     В классе лежат тесты
    /// </summary>
    [TestFixture]
    internal class DefaultTests
    {
        [OneTimeSetUp]
        public void SetUp()
        {
        }

        [OneTimeTearDown]
        public void TearDown()
        {
        }

        [Test]
        public void SearchPageTest()
        {
            new SearchPageLogic().SearchPhrase("Test");
        }


        [Test]
        public void SmallPageTest()
        {
            new SmallPageLogic().SearchPhrase("Test");
        }
    }
}