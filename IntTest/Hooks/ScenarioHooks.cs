﻿namespace IntTest.Hooks
{
    using BoDi;

    using IntTest.Pages;

    using TechTalk.SpecFlow;

    [Binding]
    public class ScenarioHooks
    {
        private readonly IObjectContainer objectContainer;

        public ScenarioHooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario(Order = 10)]
        public void BeforeScenario()
        {
            this.objectContainer.RegisterInstanceAs(new PageContext(TestRunContext.Driver));
        }
    }
}
