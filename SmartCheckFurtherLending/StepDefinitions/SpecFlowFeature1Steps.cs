using NUnit.Framework;
using TechTalk.SpecFlow;
using SmartCheckFurtherLending.PageObjects;
using SmartCheckFurtherLending.Helpers;

namespace SmartCheckFurtherLending.StepDefinitions
{
    [Binding]
    public class SpecFlowFeature1Steps
    {        
        [Given(@"I am on the haome page")]
        public void GivenIAmOnTheHaomePage()
        {
            HomePage = new HomePage(Hooks.driver);
            Hooks.driver.Url = Hooks.baseURL;
            Assert.IsTrue(HomePage.HomePageCheck.Displayed);
        }
        
        [Given(@"I have clicked the apply button on the homepage")]
        public void GivenIHaveClickedTheApplyButtonOnTheHomepage()
        {            
            HomePage.ApplyLink.Click();
        }
        
        [When(@"I click continue button")]
        public void WhenIClickContinueButton()
        {
            HomePage.ContinueButton.Click();
        }
        
        [Then(@"the user is been navigated to the main page")]
        public void ThenTheUserIsBeenNavigatedToTheMainPage()
        {
            AboutYou = new AboutYou(Hooks.driver);
            Assert.IsTrue(AboutYou.JourneyForm.Displayed);
        }

        private HomePage HomePage
        {
            get
            { 
                return ScenarioContext.Current["HomePage"] as HomePage;
            }
            set
            {
                ScenarioContext.Current["HomePage"] = value;                
            }
        }

        private AboutYou AboutYou
        {
            get
            {
                return ScenarioContext.Current["AboutYou"] as AboutYou;
            }
            set
            {
                ScenarioContext.Current["AboutYou"] = value;
            }
        }
    }    
}
