using Reqnroll;
using OpenQA.Selenium;
using SauceDemoAutomation.Drivers;
using AventStack.ExtentReports;
using SauceDemoAutomation.Utilities;

[Binding]
public class TestHooks
{
    public static IWebDriver driver;
    public static ExtentTest test;

    [BeforeScenario]
    public void BeforeScenario(ScenarioContext scenarioContext)
    {
        driver = DriverFactory.InitDriver();
        test = ExtentReportManager.Instance.CreateTest(scenarioContext.ScenarioInfo.Title);
    }

    [AfterScenario]
    public void AfterTestRun(ScenarioContext scenarioContext)
    {
        if (scenarioContext.TestError != null)
        {
            test.Fail("Scenario failed: " + scenarioContext.TestError.Message);
        }
        else
        {
            test.Pass("Scenario passed");
        }

        DriverFactory.QuitDriver();
    }

    [AfterTestRun]
    public static void AfterTestRun()
    {
        ExtentReportManager.Instance.Flush();
    }

}
