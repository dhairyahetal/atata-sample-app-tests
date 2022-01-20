using Atata;
using NUnit.Framework;

namespace AtataSampleApp.UITests
{
    [SetUpFixture]
    public class SetUpFixture
    {
        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            AtataContext.GlobalConfiguration
                .ApplyJsonConfig<AtataConfig>()
                .UseDefaultArtifactsPathIncludingBuildStart(
                    TestContext.Parameters.Get("UseDefaultArtifactsPathIncludingBuildStart", true));
               
         AtataContext.Build().
    UseDriver(() =>
    {
        string driverType = ConfigurationManager.AppSettings["DriverType"];
        switch (driverType)
        {
            case "Firefox":
                return new FirefoxDriver();
            case "Chrome":
                return new ChromeDriver();
            case "InternetExplorer":
                return new InternetExplorerDriver();
            default:
                throw new InvalidOperationException($"Unknown '{driverType}' driver type.");
        }
    })
        }
    }
}
