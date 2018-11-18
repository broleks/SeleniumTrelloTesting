using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace BaseProject
{
    /// <summary>
    /// Create and setup browser class
    /// </summary>
    public class DriverFactory
    {
        public IWebDriver driver = null;
        /// <summary>
        /// Return driver with setup
        /// </summary>
        /// <param name="type">Driver type from enum DriverType</param>
        /// <returns>Driver with specific setup</returns>
        public IWebDriver GetWebDriver(DriverType type)
        {
            switch (type)
            {
                case DriverType.Chrome:
                    driver = new ChromeDriver();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    break;
                case DriverType.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case DriverType.InternetExplorer:
                    driver = new InternetExplorerDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }
            return driver;
        }
    }

    public enum DriverType
    {
        Chrome = 0,
        Firefox = 1,
        InternetExplorer = 2
    }
}
