using OpenQA.Selenium;

namespace PageObjectPattern.PageObjectPattern.Objects
{
    public class BoardAdd : AbstractBaseObject
    {
        protected IWebElement element;
        public BoardAdd(IWebElement element) : base(element)
        {
            this.element = element;
        }

        public new void Click()
        {
            base.Click();
        }
    }
}