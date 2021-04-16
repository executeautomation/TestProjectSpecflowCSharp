using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestProject.OpenSDK.Drivers.Web;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumCSharpNetCore.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private DriverHelper _driverHelper;
        public Hooks1(DriverHelper driverHelper) => _driverHelper = driverHelper;

        [BeforeScenario]
        public void BeforeScenario()
        {

            //new DriverManager().SetUpDriver(new ChromeConfig());


            OpenQA.Selenium.Chrome.ChromeOptions options = new OpenQA.Selenium.Chrome.ChromeOptions();
            options.AddArgument("--headless");

            Console.WriteLine("Setup");

            //Using TestProject OpenSDK replacing the existing WebDriverManager
            //Note: Here the Token is taken from the .runsettings file
            _driverHelper.Driver = new FirefoxDriver(null, "U--LKi5tve35kNidu4uRp5IzAWrhL7PNVp3jEn4Y55U1");

        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
    }
}
