using BaseProject;
using NUnit.Framework;
using PageObjectPattern.PageObjectPattern.Pages;

namespace Tests
{
    [TestFixture]
    public class UnitTest1 : TestBase
    {
        [Test]
        public void TestMethod1()
        {
            Boards boards = new Boards(Driver);
            boards.Header.HomeButton.Click();
            boards.Header.SearchInput.ClickClearSendKeys("Trello");
            boards.Header.PlusButton.Click();
            boards.Header.InfoButton.Click();
            boards.Header.UserButton.Click();
        }
        [Test]
        public void TestMethod2()
        {
        }
    }
}