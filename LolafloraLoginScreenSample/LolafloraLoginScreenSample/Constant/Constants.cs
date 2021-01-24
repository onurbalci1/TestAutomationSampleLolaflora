using OpenQA.Selenium;

namespace LolafloraLoginScreenSample.Constant {
    public class Constants {
        public static By txtEmail = By.CssSelector("input[id = 'EmailLogin']");
        public static By txtPassword = By.CssSelector("input[id = 'Password']");
        public static By txtForgotPasswordInMail = By.CssSelector("input[id = 'Mail']");
        public static By btnSignIn = By.XPath("//*[@id='userLogin']/div[6]/button");
        public static By btnSend = By.XPath("/html/body/main/div/div[1]/div/form[2]/div[3]/button");
        public static By btnForgotPassword = By.XPath("//*[@id='userLogin']/div[6]/a");
        public static By txtWarningMessage = By.XPath("//*[@id='modalBox']/div/div/div[2]");
        public static By txtWarningPasswordMessageCharacter = By.CssSelector("span[id = 'Password-error']");
        public static By txtWarningEmailMessageCharacter = By.CssSelector("span[id = 'EmailLogin-error']");
        public static By btnCloseWarning = By.XPath("//*[@id='modalBox']/div/div/div[3]/button");
        public static By txtResetPassword = By.XPath("/html/body/main/div/div[1]/div/div");
        public static By btnSignOut = By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/nav/ul/li[4]/a/span");
        public static By btnClosePopup = By.XPath("//span[@class='icon-close']");
    }
}
