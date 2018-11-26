using OpenQA.Selenium;
using NUnit.Framework;
using AventStack.ExtentReports;

namespace BaseProject
{
    public abstract class AbstractBase
    {
        //Driver
        public IWebDriver Driver;
        DriverType driverType = DriverType.Chrome;
        DriverFactory driverFactory = new DriverFactory();
        //Reports
        ExtentReports reports = new ExtentReports();

        [OneTimeSetUp]
        public void OneTimeSetUpAbstract()
        {
            Driver = driverFactory.GetWebDriver(driverType);
            reports.AddSystemInfo("Browser",driverType.ToString());
            reports.Flush();
        }

        [OneTimeTearDown]
        public void OneTimeTearDownAbstract()
        {
            Driver.Quit();
        }
    }
}
