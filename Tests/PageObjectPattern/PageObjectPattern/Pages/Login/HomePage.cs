﻿using OpenQA.Selenium;

namespace PageObjectPattern.PageObjectPattern.Pages
{
    public partial class HomePage : AbstractBasePage
    {
        IWebDriver driver;
        public string url = "https://trello.com";
        public HomePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void NavigateToPage()
        {
            NavigateToPage(url);
        }
    }
}
