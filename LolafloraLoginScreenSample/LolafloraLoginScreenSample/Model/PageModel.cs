using System;
using LolafloraLoginScreenSample.Constant;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LolafloraLoginScreenSample.Model {
    public class PageModel {
        IWebDriver webDriver;
        WebDriverWait wait;
        public Constants constants;

        public PageModel(IWebDriver webDriver) {
            this.webDriver = webDriver;
            this.wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(60));
        }
        public void Wait(By by) {
            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
        public IWebElement FindElement(By by) {
            Wait(by);
            return webDriver.FindElement(by);
        }
        public void SetEmailArea(By by, string email) {
            FindElement(by).Clear();
            FindElement(by).SendKeys(email);
        }
        public void SetPasswordArea(By by, string password) {
            FindElement(by).Clear();
            FindElement(by).SendKeys(password);
        }
        public void Click(By by) {
            FindElement(by).Click();
        }
        public string GetText(By by) {
            return FindElement(by).Text;
        }
        public void CloseWarningMessage(By by) {
            Wait(by);
            FindElement(by).Click();
        }
        public string ControlUrl(string url) {
            return webDriver.Url;
        }
    }
}
