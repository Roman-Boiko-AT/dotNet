using Pages;
using TechTalk.SpecFlow;

namespace Test
{
    [Binding]
    public class LoginSteps
    {

        [Given(@"I login as '(.*)' user with '(.*)' password")]
        public void GivenILoginAsUserWithPassword(string user, string password)
        {
            LoginAsUserWithPass(user, password);
        }

        public void LoginAsUserWithPass(string user, string password)
        {
            var loginPage = new LoginPageContext();
            loginPage.LogInAs(user, password);
        }
    }
}