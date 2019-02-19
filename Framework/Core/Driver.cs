using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace Framework.Core
{
    public static class Driver
    {
        private static IWebDriver browser;
        private static WebDriverWait browserWait;

        public static IWebDriver Browser
        {
            get
            {
                if (browser == null || browserWait == null)
                {
                    throw new NullReferenceException(
                        "The WebDriver browser instance was not initialized. You should first call the method StartBrowser.");
                }
                return browser;
            }
        }

        public static WebDriverWait Wait
        {
            get
            {
                if (browser == null || browserWait == null)
                {
                    throw new NullReferenceException(
                        "The WebDriverWait instance was not initialized. You should first call the method StartBrowser.");
                }
                return browserWait;
            }
        }

        public static void StartBrowser(Drivers browser = Drivers.Chrome, int defaultTimeOut = 60)
        {
            switch (browser)
            {
                case Drivers.Chrome:
                {
                    Driver.browser = new ChromeDriver();
                    break;
                }
                case Drivers.Firefox:
                {
                    Driver.browser = new FirefoxDriver();
                    break;
                }
                case Drivers.IE:
                {
                    InternetExplorerOptions ieOptions = new InternetExplorerOptions();
                    ieOptions.EnsureCleanSession = true;
                    Driver.browser = new InternetExplorerDriver(ieOptions);
                    break;
                }                           
            }
            browserWait = new WebDriverWait(Driver.browser, TimeSpan.FromSeconds(defaultTimeOut));
        }
    }
}