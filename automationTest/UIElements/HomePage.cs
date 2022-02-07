
using OpenQA.Selenium;

namespace automationTest
{
    public class HomePage
    {
        public IWebElement AcceptCookies { get=>Driver.driver.FindElement(By.Id("cn-accept-cookie"));  }
        
    }
}
