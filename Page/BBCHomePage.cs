using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using Shouldly;

namespace BBCProject.Page
{
    public class BBCHomePage
    {
        public IWebDriver Driver;

        public BBCHomePage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.Id, Using = "idcta-username")]
        public IWebElement Signin;

        public void CheckSignINButton()
        {
            Signin.Displayed.Should().BeTrue();
        }
    }
}
