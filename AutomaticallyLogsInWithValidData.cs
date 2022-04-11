using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using vFluxLoginAutomation.PageObjectModels;

namespace vFluxLoginAutomation
{
    public class AutomaticallyLogsInWithValidData 
    {
        [Test]
        public void LoadingAndEnteringData()
        {
            // Initializing Webdriver //
            using (IWebDriver driver = new ChromeDriver())
            {
                // Maximize Window //
                driver.Manage().Window.Maximize();

                // Initialize Page Object Models //
                var loginPage = new LoginPage(driver);
                var mailinatorPage = new MailinatorPage(driver);

                // Go to Login Page // 
                loginPage.NavigateTo();

                // Entering Username & Password //
                loginPage.EnterUserCredentials();

                // Submit Login Form //
                loginPage.SubmitLogin();

                // Open New Tab //
                loginPage.NewTab();

                // Switch to New Tab and Open Mailinator //
                loginPage.SwitchToNext();
                mailinatorPage.NavigateTo();
                WaitToLoad.Pause(5000);

                // Open Mail on Mailinator //
                mailinatorPage.OpenOtpMail();
                WaitToLoad.Pause();

                // Read OTP from Mailinator // 
                string Otp = mailinatorPage.ReadOtpFromMailinator();

                // Switch to vFlux page //
                loginPage.SwitchBack();

                // Enter OTP and Submit //
                loginPage.EnterOtp(Otp);

                // Check that Application has been successfully Logged-in //
                WaitToLoad.Pause(5000);
                loginPage.CheckLoginStatus();
            }
        }
    }
}
