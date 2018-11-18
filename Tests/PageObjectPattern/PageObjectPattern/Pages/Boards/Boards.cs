using OpenQA.Selenium;

namespace PageObjectPattern.PageObjectPattern.Pages
{
    public class Boards : AbstractBasePage
    {
        IWebDriver driver;
        public string url = "https://trello.com";
        public Boards(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void NavigateToPage()
        {
            NavigateToPage(url);
        }
    }
}
