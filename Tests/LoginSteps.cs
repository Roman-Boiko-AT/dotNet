using Pages;
using TechTalk.SpecFlow;

namespace Tests
{
    [Binding]
    public class LoginSteps
    {
        public void LoginAsUserWithPass(string user, string password)
        {
            var loginPage = new LoginPageContext();
            loginPage.LogInAs(user, password);
        }
    }
}