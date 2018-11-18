using PageObjectPattern.PageObjectPattern.Objects;
using OpenQA.Selenium;

namespace PageObjectPattern.PageObjectPattern.Pages
{
    partial class LoginPage
    {
        public LoginForm LoginForm => new LoginForm(driver.FindElement(By.XPath("//div[@class='layout-twothirds-center']")));
    }
}
