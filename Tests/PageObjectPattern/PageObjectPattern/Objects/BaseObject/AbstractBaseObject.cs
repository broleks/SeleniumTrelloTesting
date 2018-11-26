using System;
using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;

namespace PageObjectPattern.PageObjectPattern.Objects
{
    public abstract class AbstractBaseObject
    {
        IWebElement element;
        protected AbstractBaseObject(IWebElement element)
        {
            this.element = element;
        }

        protected string TagName => element.TagName;

        protected string Text => element.Text;

        protected bool Enabled => element.Enabled;

        protected bool Selected => element.Selected;

        protected Point Location => element.Location;

        protected Size Size => element.Size;

        protected bool Displayed => element.Displayed;

        protected void Clear()
        {
            element.Clear();
        }

        protected void Click()
        {
            element.Click();
        }

        public IWebElement FindElement(By by)
        {
            return element.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return element.FindElements(by);
        }

        protected string GetAttribute(string attributeName)
        {
            return element.GetAttribute(attributeName);
        }

        protected string GetCssValue(string propertyName)
        {
            return element.GetCssValue(propertyName);
        }

        protected string GetProperty(string propertyName)
        {
            return element.GetProperty(propertyName);
        }

        protected void SendKeys(string text)
        {
            element.SendKeys(text);
        }

        protected void Submit()
        {
            element.Submit();
        }

        protected IWebDriver GetWebDriverFromElement()
        {
            return ((IWrapsDriver)element).WrappedDriver;
        }

        protected void WaitElementClickable()
        {
            new WebDriverWait(GetWebDriverFromElement(), TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(element));
        }
       
    }
}
