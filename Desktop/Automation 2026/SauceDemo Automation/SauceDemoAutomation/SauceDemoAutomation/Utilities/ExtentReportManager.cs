using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.IO;

namespace SauceDemoAutomation.Utilities
{
    public static class ExtentReportManager
    {
        private static readonly ExtentReports _extent;
        public static ExtentReports Instance => _extent;

        static ExtentReportManager()
        {
            // Get the project root directory (three levels up from bin/Debug/net8.0)
            var projectRoot = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", ".."));
            var reportsDir = Path.Combine(projectRoot, "Reports");
            Directory.CreateDirectory(reportsDir); // Ensure Reports folder exists

            var reportPath = Path.Combine(reportsDir, $"TestReport_{DateTime.Now:yyyyMMdd_HHmmss}.html");
            var sparkReporter = new ExtentSparkReporter(reportPath);
            _extent = new ExtentReports();
            _extent.AttachReporter(sparkReporter);
        }
    }
}
