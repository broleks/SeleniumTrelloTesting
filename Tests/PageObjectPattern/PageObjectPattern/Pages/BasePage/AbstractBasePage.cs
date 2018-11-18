using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjectPattern.PageObjectPattern.Objects;
using System;

namespace PageObjectPattern.PageObjectPattern.Pages
{
    public abstract class AbstractBasePage
    {
        private IWebDriver driver;
        private string url;
        public AbstractBasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public Header Header => new Header(driver.FindElement(By.Id("header")));

        protected void NavigateToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
            new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.UrlContains(url));
        }
        
        protected void WaitOnPage(string url = null, string title = null)
        {
            if (url != null)
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.UrlContains(url));
            }
            if (title != null)
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.TitleContains(title));
            }
        }
    }
}
