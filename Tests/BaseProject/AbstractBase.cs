using OpenQA.Selenium;
using NUnit.Framework;

namespace BaseProject
{
    public abstract class AbstractBase
    {
        public IWebDriver Driver;
        DriverFactory driverFactory = new DriverFactory();

        [OneTimeSetUp]
        public void OneTimeSetUpAbstract()
        {
            Driver = driverFactory.GetWebDriver(DriverType.Chrome);
        }

        [OneTimeTearDown]
        public void OneTimeTearDownAbstract()
        {
            Driver.Quit();
        }
    }
}
