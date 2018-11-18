using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;

namespace PageObjectPattern.PageObjectPattern.Objects
{
    public abstract class AbstractBaseObject : IWebElement
    {
        IWebElement element;
        public AbstractBaseObject(IWebElement element)
        {
            this.element = element;
        }

        public string TagName => element.TagName;

        public string Text => element.Text;

        public bool Enabled => element.Enabled;

        public bool Selected => element.Selected;

        public Point Location => element.Location;

        public Size Size => element.Size;

        public bool Displayed => element.Displayed;

        public void Clear()
        {
            element.Clear();
        }

        public void Click()
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

        public string GetAttribute(string attributeName)
        {
            return element.GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            return element.GetCssValue(propertyName);
        }

        public string GetProperty(string propertyName)
        {
            return element.GetProperty(propertyName);
        }

        public void SendKeys(string text)
        {
            element.SendKeys(text);
        }

        public virtual void Submit()
        {
            element.Submit();
        }

        public IWebDriver GetWebDriverFromElement()
        {
            return ((IWrapsDriver)element).WrappedDriver;
        }
       
    }
}
