using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SauceDemoAutomation.Drivers
{
    public class DriverFactory
    {
        public static IWebDriver driver;

        public static IWebDriver InitDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }
    }
}