using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjectPattern.PageObjectPattern.Pages;
using System;

namespace BaseProject
{
    public class TestBase : AbstractBase
    {
        [OneTimeSetUp]
        public void OneTimeSetUpTestBase()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.NavigateToPage();
            homePage.LoginButton.Click();
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginForm.LogIn("adam.testowy@cyberia.pl", "Test12345678-q");
        }
    }
}
