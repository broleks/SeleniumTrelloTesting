using OpenQA.Selenium;
using System.Collections.Generic;

namespace PageObjectPattern.PageObjectPattern.Objects
{
    public class BoardsList : AbstractBaseObject
    {
        protected IWebElement element;
        public IList<Board> listBoards = new List<Board>();

        public BoardsList(IWebElement element) : base(element)
        {
            this.element = element;
            CreateBoardList();
        }

        public void CreateBoardList()
        {
            IList<IWebElement> boardElements = element.FindElements(By.XPath(".//li//a[@class='board-tile']"));
            foreach (IWebElement b in boardElements)
            {
                listBoards.Add(new Board(b));
            }
        }

        public int GetBoardsNumber()
        {
            return listBoards.Count;
        }


    }
}
