using OpenQA.Selenium;

namespace PageObjectPattern.PageObjectPattern.Objects
{
    public class Input : AbstractBaseObject
    {
        protected IWebElement element;
        public Input(IWebElement element) : base(element)
        {
            this.element = element;
        }

        public void ClickClearSendKeys(string text)
        {
            base.Click();
            base.Clear();
            base.SendKeys(text);
        }
    }
}
