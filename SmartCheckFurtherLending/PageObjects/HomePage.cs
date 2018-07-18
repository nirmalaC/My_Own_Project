using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace SmartCheckFurtherLending.PageObjects
{
    public class HomePage
    {
        public RemoteWebDriver driver;

        [FindsBy(How = How.Id, Using = "header-apply-link")]
        public IWebElement ApplyLink { get; set; }

        [FindsBy(How = How.Id, Using = "header-login-link")]
        public IWebElement LoginLink { get; set; }

        [FindsBy(How = How.Id, Using = "ContinueButton")]
        public IWebElement ContinueButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "home-page")]
        public IWebElement HomePageCheck { get; set; }
        


        public HomePage(RemoteWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
