using System.IO;
using System.Reflection;
using LolafloraLoginScreenSample.Constant;
using LolafloraLoginScreenSample.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace LolafloraLoginScreenSample.PageTest {
    [Binding, Scope(Feature = "LolafloraLoginScreen")]
    public class PageTest {
        public static IWebDriver webDriver { get; set; }
        public PageModel pageModel;


        [BeforeScenario]
        public void Setup() {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            options.AddArguments("--disable-infobars");
            options.AddArguments("--disable-notifications");
            options.AddArguments("enable-automation");
            webDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            pageModel = new PageModel(webDriver);
        }

        [StepDefinition(@"'(.*)' sayfasına girilir")]
        public void GoToUrl(string url) {
            webDriver.Navigate().GoToUrl(url);
        }

        [StepDefinition(@"'(.*)' sayfası kontrol edilir")]
        public void ControlUrl(string url) {
            pageModel.Wait(Constants.btnSignOut);
            string urlValue = pageModel.ControlUrl(url);
            Assert.AreEqual(urlValue, url, "Yönlendirilen web sayfası hatalı");
        }

        [StepDefinition(@"E-Mail kutucuğuna '(.*)' girişi yapılır")]
        public void SetEmailArea(string email) {
            pageModel.SetEmailArea(Constants.txtEmail, email);
        }

        [StepDefinition(@"Mail kutucuğuna '(.*)' girişi yapılır")]
        public void SetForgotPasswordInEmailArea(string email) {
            pageModel.SetEmailArea(Constants.txtForgotPasswordInMail, email);
        }

        public int passwordCharacter;
        [StepDefinition(@"Şifre kutucuğuna '(.*)' girişi yapılır")]
        public void SetPasswordArea(string password) {
            passwordCharacter = password.Length;
            pageModel.SetPasswordArea(Constants.txtPassword, password);
        }

        [StepDefinition(@"Sign In butonuna tıklanır")]
        public void ClickSignInButton() {
            pageModel.Click(Constants.btnSignIn);
        }

        [StepDefinition(@"Popup kapatılır")]
        public void ClickPopupCloseButton() {
            pageModel.Click(Constants.btnClosePopup);
        }

        [StepDefinition(@"Sign Out butonuna tıklanır")]
        public void ClickSignOutButton() {
            pageModel.Click(Constants.btnSignOut);
        }

        [StepDefinition(@"Send butonuna tıklanır")]
        public void ClickSendButton() {
            pageModel.Click(Constants.btnSend);
        }

        [StepDefinition(@"Forgot Password butonuna tıklanır")]
        public void ClickForgotPasswordButton() {
            pageModel.Click(Constants.btnForgotPassword);
        }

        [StepDefinition(@"'(.*)' uyarısı görülür")]
        public void ControlWarningMessage(string expectedMessage) {
            string value = pageModel.GetText(Constants.txtWarningMessage);
            Assert.AreEqual(value, expectedMessage, "İlgili mesaj görüntülenemedi");
        }

        [StepDefinition(@"Password için '(.*)' uyarısı görülür")]
        public void ControlPasswordWarningMessage(string expectedMessagePassword) {
            string value = pageModel.GetText(Constants.txtWarningPasswordMessageCharacter);
            Assert.AreEqual(value, expectedMessagePassword, "İlgili mesaj görüntülenemedi");
        }

        [StepDefinition(@"Email için '(.*)' uyarısı görülür")]
        public void ControlEmailWarningMessage(string expectedMessageEmail) {
            string value = pageModel.GetText(Constants.txtWarningEmailMessageCharacter);
            Assert.AreEqual(value, expectedMessageEmail);
        }

        [StepDefinition(@"Forgot Password için '(.*)' uyarısı görülür")]
        public void ControlForgotPasswordWarningMessage(string expectedMessageForgotPassword) {
            string value = pageModel.GetText(Constants.txtResetPassword);
            Assert.AreEqual(value, expectedMessageForgotPassword);
        }

        [StepDefinition(@"Uyarı penceresi kapatılır")]
        public void CloseWarningMessage() {
            pageModel.CloseWarningMessage(Constants.btnCloseWarning);
        }

        [AfterScenario]
        public void TearDown() {
            webDriver.Quit();
        }
    }
}
