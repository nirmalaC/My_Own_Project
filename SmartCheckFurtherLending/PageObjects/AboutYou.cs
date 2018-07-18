using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCheckFurtherLending.PageObjects
{
    class AboutYou
    {
        public RemoteWebDriver driver;

        [FindsBy(How = How.Id, Using = "SaysIsExistingCustomerYes")]
        public IWebElement YesRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "SaysIsExistingCustomerNo")]
        public IWebElement NoRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "TermTypeAboutYouCalcMonthly")]
        public IWebElement PayMonthly { get; set; }

        [FindsBy(How = How.Id, Using = "TermTypeAboutYouCalcMonthly")]
        public IWebElement PayWeekly { get; set; }

        [FindsBy(How = How.Id, Using = "JourneyForm")]
        public IWebElement JourneyForm { get; set; }



        public AboutYou(RemoteWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
