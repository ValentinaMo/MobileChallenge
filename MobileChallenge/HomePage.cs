using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MobileChallenge
{
    class HomePage
    {
        public AppiumDriver<AndroidElement> driver;
        public HomePage(AppiumDriver<AndroidElement> _driver)
        {
            driver = _driver;
        }

        public AndroidElement registerButton { get; set; }

        public RegistratioPage clickOnRegistration()
        {
            registerButton = driver.FindElementById("home_onboarding_email_register_button");
            registerButton.Click();
            return new RegistratioPage(driver);
        }

    }
}
