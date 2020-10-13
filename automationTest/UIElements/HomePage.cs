
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace automationTest
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "cn-accept-cookie")]
        public IWebElement AcceptCookies { get; set; }
        
    }
}
