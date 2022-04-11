using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace vFluxLoginAutomation.PageObjectModels
{
    class MailinatorPage
    {
        private readonly IWebDriver Driver;
        private const string PageUrl = "https://www.mailinator.com/v4/public/inboxes.jsp?to=qaapprover2";
        private const string PageTitle = "Mailinator";

        public MailinatorPage(IWebDriver driver)
        {
            Driver = driver;
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

        public void OpenOtpMail()
        {
            IWebElement mailClickOTP = Driver.FindElement(By.XPath("//td[contains(text(),'Verify your identity to log in to vFlux')]"));
            Actions actions = new Actions(Driver);
            actions.MoveToElement(mailClickOTP).DoubleClick().Perform();
        }

        public void EnsureEmailLoaded()
        {
            Driver.SwitchTo().Frame("html_msg_body");
            bool emailLoaded = Driver.FindElement(By.CssSelector("div:nth-child(3) p:nth-child(2)")).Text == "For security reasons, do not use this code outside of vFlux QA.";

            if (!emailLoaded)
            {
                throw new Exception($"Failed to load Email!");
            }
        }

        public string ReadOtpFromMailinator()
        {
            EnsureEmailLoaded(); // Throw Exception if the email is not loaded //
            string readOTP = Driver.FindElement(By.CssSelector("div[class='bg'] p:nth-child(3)")).Text;
            return readOTP;
        }
    }
}
