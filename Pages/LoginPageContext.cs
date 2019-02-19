using Framework.Templates.PageObject;

namespace Pages
{
    public class LoginPageContext : PageContextNavigable<LoginPage>
    {
        public LoginPageContext() : base("https://codepen.io/login?secure=true") {}
         
        public void LogInAs(string user, string password)
        {
            page.UserNameTextBox.Clear();
            page.UserNameTextBox.SendKeys(user);
            page.UserPasswordTextBox.Clear();
            page.UserPasswordTextBox.SendKeys(password);
            page.LogInButton.Click();
        }
    }
}