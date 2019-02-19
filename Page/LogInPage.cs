using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages
{
    public class LoginPage : Tests.Framework.Templates.PageObject.Page
    {
        [FindsBy(How = How.Id, Using = "login-email-field")]
        public IWebElement UserNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "login-password-field_")]
        public IWebElement UserPasswordTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "log-in-button")]
        public IWebElement LogInButton { get; set; }
    }
}