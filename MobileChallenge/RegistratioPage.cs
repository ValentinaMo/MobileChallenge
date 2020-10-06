using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileChallenge
{
    class RegistratioPage
    {
        public AppiumDriver<AndroidElement> driver;
        public RegistratioPage(AppiumDriver<AndroidElement> _driver)
        {
            driver = _driver;
        }

        public AndroidElement nameField { get; set; }

        public AndroidElement lastNameField { get; set; }

        public AndroidElement e_mailField { get; set; }

        public AndroidElement passwordField { get; set; }

        public AndroidElement continueButton { get; set; }

        public AndroidElement noneAbove { get; set; }

        public void registration(String name, String lastName, String e_mail, String password)
        {
            nameField = driver.FindElementByXPath("//*[@text = 'Nombre']");
            nameField.Click();
            nameField.SendKeys(name);

            lastNameField = driver.FindElementByXPath("//*[@text = 'Apellido']");
            lastNameField.Click();
            lastNameField.SendKeys(lastName);

            e_mailField= driver.FindElementByXPath("//*[@text = 'E-mail']");
            e_mailField.Click();
            noneAbove = driver.FindElementByXPath("//*[@text = 'NONE OF THE ABOVE']");
            noneAbove.Click();
            e_mailField.SendKeys(e_mail);
            driver.HideKeyboard();

            passwordField = driver.FindElementByXPath("//*[@text = 'Clave']");
            passwordField.Click();
            passwordField.SendKeys(password);
            driver.HideKeyboard();

            continueButton = driver.FindElementByXPath("//*[@text = 'Continuar']");
            continueButton.Click();
        }

    }
}
