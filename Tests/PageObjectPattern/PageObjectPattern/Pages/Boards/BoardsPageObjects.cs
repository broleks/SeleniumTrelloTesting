using OpenQA.Selenium;
using PageObjectPattern.PageObjectPattern.Objects;

namespace PageObjectPattern.PageObjectPattern.Pages
{
    public partial class BoardsPage : AbstractBasePage
    {
        public BoardsList BoardsList => new BoardsList(driver.FindElement(By.XPath("//h3[contains(text(),'Tablice prywatne')]//ancestor::div[@class='boards-page-board-section mod-no-sidebar']")));
        public BoardAdd BoardAdd => new BoardAdd(driver.FindElement(By.XPath("//span[contains(text(),'Utwórz nową tablicę…')]//ancestor::li[@class='boards-page-board-section-list-item']")));
        public AddBoardForm AddBoardForm => new AddBoardForm(driver.FindElement(By.XPath("//form[@class='create-board-form']")));
    }
}
