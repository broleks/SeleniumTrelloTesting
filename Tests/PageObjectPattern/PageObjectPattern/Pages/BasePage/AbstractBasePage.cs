using OpenQA.Selenium;

namespace PageObjectPattern.PageObjectPattern.Pages
{
    public abstract class AbstractBasePage
    {
        private IWebDriver driver;
        public AbstractBasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
