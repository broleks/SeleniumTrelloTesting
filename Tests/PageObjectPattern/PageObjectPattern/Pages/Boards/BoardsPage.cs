using NUnit.Framework;
using OpenQA.Selenium;
using PageObjectPattern.PageObjectPattern.Objects;

namespace PageObjectPattern.PageObjectPattern.Pages
{
    public partial class BoardsPage : AbstractBasePage
    {
        IWebDriver driver;
        public string url = "https://trello.com";

        public BoardsPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void NavigateToPage()
        {
            NavigateToPage(url);
        }

        public void AsserBoardListNumber(int boardNumber)
        {
            Assert.AreEqual(boardNumber,BoardsList.GetBoardsNumber(),"Number of user boards is not correct");
        }
    }
}
