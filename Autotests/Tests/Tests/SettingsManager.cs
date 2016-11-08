using System;
using System.Configuration;

namespace Tests.Tests
{
    public static class SettingsManager
    {
        public const int SomeSetting = 2000;

        public static int SomeIntSettingFromAppConfig =
            Convert.ToInt32(ConfigurationManager.AppSettings["SomeIntSettingFromAppConfig"]);

        public static string SomeStringSettingFromAppConfig =
            ConfigurationManager.AppSettings["SomeStringSettingFromAppConfig"];

        public static void SomeMethod()
        {
            //somemethod
        }
    }
}