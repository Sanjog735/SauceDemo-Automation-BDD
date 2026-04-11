using Microsoft.Extensions.Configuration;
using System.IO;

namespace SauceDemoAutomation.Config
{
    public static class ConfigHelper
    {
        private static IConfigurationRoot configuration;
        static ConfigHelper()
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("Config/appsettings.json", optional:false, reloadOnChange: true)
                .Build();
        }

        public static string GetBaseUrl() => configuration["baseUrl"];
        public static string GetUsername() => configuration["username"];
        public static string GetPassword() => configuration["password"];
    }
}
