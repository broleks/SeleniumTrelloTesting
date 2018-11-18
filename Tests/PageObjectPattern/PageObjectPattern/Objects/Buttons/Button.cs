using OpenQA.Selenium;

namespace PageObjectPattern.PageObjectPattern.Objects
{
    public class Button : AbstractBaseObject
    {
        protected IWebElement element;
        public Button(IWebElement element):base(element)
        {
            this.element = element;
        }
    }
}
