using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;

namespace PageObjectPattern.PageObjectPattern.Objects
{
    public class LoginForm : AbstractBaseObject
    {
        protected IWebElement element;
        public LoginForm(IWebElement element) : base(element)
        {
            this.element = element;
        }
        public Input UserInput => new Input(element.FindElement(By.Id("user")));
        public Input PasswordInput => new Input(element.FindElement(By.Id("password")));
        public Button LoginButton => new Button(element.FindElement(By.Id("login")));

        public void LogIn(string user, string password)
        {
            UserInput.ClickClearSendKeys(user);
            PasswordInput.ClickClearSendKeys(password);
            LoginButton.Click();
            new WebDriverWait(GetWebDriverFromElement(), TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists(By.Id("header")));
        }
    }
}