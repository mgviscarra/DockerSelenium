using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

namespace SeleniumDocker
{
    public class DriverFactory:WebDriver
    {
       
        public void ChooseDriverInstance(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
            {
                ChromeOptions op = new ChromeOptions();
                op.BrowserVersion = "";
                op.PlatformName = "LINUX";
                Driver = new RemoteWebDriver(new Uri("http://192.168.99.100:4446/wd/hub"), op);


            }
            else if (browserType == BrowserType.Firefox)
            {
                FirefoxOptions op = new FirefoxOptions();
                op.BrowserVersion = "";
                op.PlatformName = "LINUX";
                Driver = new RemoteWebDriver(new Uri("http://192.168.99.100:4446/wd/hub"), op);
            }
        }
    }
}
