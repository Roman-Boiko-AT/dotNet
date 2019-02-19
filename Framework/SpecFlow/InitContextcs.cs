using Framework.Core;
using TechTalk.SpecFlow;

namespace Framework.SpecFlow
{
    [Binding]
    public static class InitContext
    {
        [BeforeFeature(Order = 0)]
        public static void InitDriver()
        {
            Driver.StartBrowser(Drivers.Firefox);
        }

        [AfterFeature(Order = 10000)]
        public static void AfterFeature()
        {
            Driver.Browser.Quit();
        }
    }
}