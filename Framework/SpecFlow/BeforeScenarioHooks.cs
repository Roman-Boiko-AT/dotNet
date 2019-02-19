using TechTalk.SpecFlow;

namespace Framework.SpecFlow
{
    class BeforeScenarioHooks
    {
        [BeforeScenario(Order = 1)]
        public static void TestSetUp()
        {
        }
    }
}