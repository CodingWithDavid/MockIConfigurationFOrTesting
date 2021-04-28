using Microsoft.Extensions.Configuration;
using MockIConfigurationForTesting.Data;
using NUnit.Framework;
using System.Collections.Generic;

namespace MockIConfigurationForTestingTest
{
    public class WeatherForecastServiceTests
    {
        private WeatherForecastService UUT;
        private IConfiguration config;

        public WeatherForecastServiceTests()
        {
            var inMemorySettings = new Dictionary<string, string>()
            {
                { "Location", "TestLocation"}
            };

            config = new ConfigurationBuilder()
                .AddInMemoryCollection(inMemorySettings)
                .Build();
        }


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetForcastPositiveTest()
        {
            UUT = new WeatherForecastService(config);
            Assert.Pass();
        }


        [Test]
        public void GetLocationPositiveTest()
        {
            UUT = new WeatherForecastService(config);
            string result = UUT.GetLocation();
            Assert.AreEqual("TestLocation", result);
        }
    }
}