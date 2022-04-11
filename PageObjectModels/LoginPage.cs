using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;

namespace vFluxLoginAutomation.PageObjectModels
{
    class LoginPage
    {
        private readonly IWebDriver Driver;
        private const string UserName = "qaapprover2";
        private const string PassWord = "Test@123";
        private const string PageUrl = "http://34.75.248.77:9080/#/";
        private const string PageTitle = "vFlux";

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void EnterUserCredentials()
        {
            Driver.FindElement(By.Name("Username")).SendKeys(UserName);
            Driver.FindElement(By.Name("Password")).SendKeys(PassWord);
        }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(PageUrl);
            EnsurePageLoaded();
        }

        public void EnsurePageLoaded()
        {
            bool pageLoaded = Driver.Url == PageUrl && Driver.Title == PageTitle;

            if (!pageLoaded)
            {
                throw new Exception($"Failed to load page. Page URL = '{Driver.Url}' Page Source \r\n {Driver.PageSource}");
            }
        }

        public void SwitchToNext()
        {
            ReadOnlyCollection<string> allTabs = Driver.WindowHandles;
            string NextTab = allTabs[1];
            Driver.SwitchTo().Window(NextTab);
        }

        public void SwitchBack()
        {
            ReadOnlyCollection<string> allTabs = Driver.WindowHandles;
            string LoginTab = allTabs[0];
            Driver.SwitchTo().Window(LoginTab);
        }

        public void EnterOtp(string otp)
        {
            Driver.FindElement(By.ClassName("otpInput")).SendKeys(otp);
            Driver.FindElement(By.CssSelector("button:nth-child(2)")).Click();
        }

        public void NewTab()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.open();");
        }

        public void SubmitLogin() => Driver.FindElement(By.Name("Password")).Submit();

        public void CheckLoginStatus() => Assert.AreEqual(Driver.FindElement(By.ClassName("my-textCorporateCalender")).Text, "Corporate Actions Calendar");
    }
}
