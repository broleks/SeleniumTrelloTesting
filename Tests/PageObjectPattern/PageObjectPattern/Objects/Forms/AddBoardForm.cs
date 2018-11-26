using OpenQA.Selenium;

namespace PageObjectPattern.PageObjectPattern.Objects
{
    public class AddBoardForm : AbstractBaseObject
    {
        protected IWebElement element;
        protected Input BoardNameInput => new Input(element.FindElement(By.XPath(".//input[@class='subtle-input']")));
        protected Button AddButton => new Button(element.FindElement(By.XPath(".//button[@type='submit']")));

        public AddBoardForm(IWebElement element) : base(element)
        {
            this.element = element;
        }

        public void InputName(string tableName)
        {
            BoardNameInput.ClickClearSendKeys(tableName);
        }

        public void SubmitForm()
        {
            AddButton.Click();
        }
    }
}