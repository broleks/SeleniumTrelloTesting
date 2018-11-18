using OpenQA.Selenium;

namespace PageObjectPattern.PageObjectPattern.Pages
{
    public partial class HomePage : AbstractBasePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
    }
}
