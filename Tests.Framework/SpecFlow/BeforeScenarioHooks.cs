using TechTalk.SpecFlow;

namespace Tests.Framework.SpecFlow
{
    class BeforeScenarioHooks
    {
        [BeforeScenario(Order = 1)]
        public static void TestSetUp()
        {
        }
    }
}