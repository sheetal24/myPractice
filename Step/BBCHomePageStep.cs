using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using BBCProject.Base;
using BBCProject.Page;

namespace BBCProject
{
    [Binding]
    public class BBCHomePageStep : SetUp
    {
        public IWebDriver browser;
        BBCHomePage HomePage;


        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://bbc.co.uk");

        }

        [Then(@"I see the page loads")]
        public void ThenISeeThePageLoads()
        {
            HomePage = new BBCHomePage(browser);
            HomePage.CheckSignINButton();
        }



    }
}
