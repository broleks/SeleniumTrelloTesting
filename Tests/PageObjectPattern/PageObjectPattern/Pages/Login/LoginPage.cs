using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace PageObjectPattern.PageObjectPattern.Pages
{
    public partial class LoginPage : AbstractBasePage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
    }
}
