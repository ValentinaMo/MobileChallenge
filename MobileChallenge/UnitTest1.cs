using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MobileChallenge
{
    public class Tests
    {
        private AppiumDriver<AndroidElement> _driver;
   
        [SetUp]
        public void Setup()
        {
            var appPath = "C:/Users/vmoreno/Downloads/MercadoLibre.apk";
            var capabilities = new AppiumOptions();

            capabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            capabilities.AddAdditionalCapability(MobileCapabilityType.App, appPath);
            capabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel 2 API 30");

            _driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), capabilities);
        }

        [Test]
        public void Test1()
        {
            HomePage homePage = new HomePage(_driver);
            RegistratioPage registrationPage = homePage.clickOnRegistration();
            registrationPage.registration("Lina", "Pinzon", "vallen12nansnsns@hotmail.com", "pabsd231_7");    

            Assert.Pass();
        }
    }
}