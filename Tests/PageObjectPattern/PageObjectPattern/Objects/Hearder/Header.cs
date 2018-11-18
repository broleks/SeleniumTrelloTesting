using OpenQA.Selenium;

namespace PageObjectPattern.PageObjectPattern.Objects
{
    public class Header : AbstractBaseObject
    {
        protected IWebElement element;
        public Header(IWebElement element) : base(element)
        {
            this.element = element;
        }
        public Button HomeButton => new Button(element.FindElement(By.XPath(".//a[@class='header-logo js-home-via-logo']")));
        public Button TableButton => new Button(element.FindElement(By.XPath(".//a[@class='header-btn header-boards js-boards-menu']")));
        public Input SearchInput => new Input(element.FindElement(By.XPath(".//input")));
        public Button LogoButton => new Button(element.FindElement(By.XPath(".//a[@class='header-logo js-home-via-logo']")));
        public Button PlusButton => new Button(element.FindElement(By.XPath(".//a[@class='header-btn js-open-add-menu']")));
        public Button InfoButton => new Button(element.FindElement(By.XPath(".//a[@class='header-btn header-info js-open-header-info-menu']")));
        public Button BellButton => new Button(element.FindElement(By.XPath(".//a[@class='header-btn header-notifications js-open-header-notifications-menu']")));
        public Button UserButton => new Button(element.FindElement(By.XPath(".//a[@class='header-btn header-avatar js-open-header-member-menu']")));
    }
}
