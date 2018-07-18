using System;
using TechTalk.SpecFlow;
using System.Configuration;
using OpenQA.Selenium.Remote;


namespace SmartCheckFurtherLending.Helpers
{
    [Binding]
    public sealed class Hooks
    {
        public static RemoteWebDriver driver = null;
        public static string baseURL = ConfigurationManager.AppSettings["UiTestMainSiteUrl"];
        private static string browser = ConfigurationManager.AppSettings["UiTestBrowser"];

        [BeforeScenario]
        public void BeforeScenario()
        {
            DesiredCapabilities dc = new DesiredCapabilities();

            switch (browser)
            {
                case "Chrome":
                    dc.SetCapability(CapabilityType.BrowserName, "chrome");
                    dc.SetCapability(CapabilityType.Platform, "WINDOWS");
                    dc.SetCapability(CapabilityType.AcceptInsecureCertificates, true);
                    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), dc, TimeSpan.FromSeconds(500));
                    break;

                case "Firefox":
                    dc.SetCapability(CapabilityType.BrowserName, "firefox");
                    dc.SetCapability(CapabilityType.Platform, "WINDOWS");
                    dc.SetCapability(CapabilityType.AcceptInsecureCertificates, true);
                    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), dc, TimeSpan.FromSeconds(500));
                    break;
                case "IE":
                    DesiredCapabilities capability = DesiredCapabilities.InternetExplorer();
                    //dc.SetCapability(CapabilityType.BrowserName, DesiredCapabilities.InternetExplorer());
                    capability.SetCapability(CapabilityType.Version, "11");
                    capability.SetCapability(CapabilityType.Platform, "WINDOWS");
                    capability.SetCapability(CapabilityType.AcceptInsecureCertificates, true);
                    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capability, TimeSpan.FromSeconds(500));
                    break;
            }
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);         
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }

}
