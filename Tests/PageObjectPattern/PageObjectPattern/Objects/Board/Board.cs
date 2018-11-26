using OpenQA.Selenium;

namespace PageObjectPattern.PageObjectPattern.Objects
{
    public class Board : AbstractBaseObject
    {
        protected IWebElement element;
        public Board(IWebElement element) : base(element)
        {
            this.element = element;
        }
    }
}