using OpenQA.Selenium;
using PageObjectPattern.PageObjectPattern.Objects;

namespace PageObjectPattern.PageObjectPattern.Pages
{
    partial class HomePage
    {
        public Button LoginButton => new Button(driver.FindElement(By.XPath("//a[(text()='Zaloguj')]")));
    }
}
