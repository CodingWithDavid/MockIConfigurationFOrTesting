# Mock/Fake IConfiguration for Unit testing

This is a little sample application showing who to Fake application setting in a configuration object during unit testing.


by [David Gallivan](http://twitter.com/CodingwithDavid)


## Why

There are a lot of published ways to solve the issue of running unit test on class that inject an IConfiguration object holding application settings.  This is a new way I came across recently and want to create a sample project showing how to use it.  

## Getting Started

1. Clone this repository

   ```Command Line
   git clone https://github.com/CodingWithDavid/MockIConfigurationForTesting
   cd MockIConfigurationForTesting
   ```

1.	Open in Visual Studio or Visual Code
a.	With Visual Code you will need to install the C# extensions
b.  With Visual Code you will need to install the Blazor extensions
2.	Press F5

## What's in the App

1. Blazor application that I have refactored the WeatherForecastService to inject a configuration.  This service has a new method on it that will retrieve the value of the app setting.
2. Unit test project with a test class for the Weather Forecast Service
    a. The test class shows how to use the new method for faking the IConfiguration object

## Problems or Suggestions

[Open an issue here]( https://github.com/CodingWithDavid/MockIConfigurationForTesting/issues)

## Thank You


## Resources

- [VS Code](https://code.visualstudio.com)
- [Visual Studio]( https://visualstudio.microsoft.com/)



