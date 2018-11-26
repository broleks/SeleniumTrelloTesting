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
            BoardsPage boardsPage = new BoardsPage(Driver);
            //Check boards number is correct
            boardsPage.AsserBoardListNumber(1);
            //Add nwe board
            boardsPage.BoardAdd.Click();

            boardsPage.AddBoardForm.InputName("Tablica publiczna 1");
            boardsPage.AddBoardForm.SubmitForm();
            boardsPage.AsserBoardListNumber(2);

        }
        [Test]
        public void TestMethod2()
        {
        }
    }
}