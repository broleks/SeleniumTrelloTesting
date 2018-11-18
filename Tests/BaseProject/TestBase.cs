using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjectPattern.PageObjectPattern.Pages;
using System;

namespace BaseProject
{
    public class TestBase : AbstractBase
    {
        public string baseUrl = "https://trello.com";

        [OneTimeSetUp]
        public void OneTimeSetUpTestBase()
        {
            Driver.Navigate().GoToUrl(baseUrl);
            HomePage homePage = new HomePage(Driver);
            homePage.LoginButton.Click();
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginForm.LogIn("adam.testowy@cyberia.pl", "Test12345678-q");
        }
    }
}
