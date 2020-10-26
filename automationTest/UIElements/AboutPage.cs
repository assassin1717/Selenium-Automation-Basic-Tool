using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace automationTest.UIElements
{
    class AboutPage
    {
        public AboutPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "div > h3")]
        public IWebElement FormTitleText { get; set; }

        [FindsBy(How = How.Id, Using = "wpforms-14-field_0")]
        public IWebElement NameInput { get; set; }

        [FindsBy(How = How.Id, Using = "wpforms-14-field_5")]
        public IWebElement TitleInput { get; set; }

        [FindsBy(How = How.Id, Using = "wpforms-14-field_4")]
        public IWebElement EmailInput { get; set; }

        [FindsBy(How = How.Id, Using = "wpforms-14-field_2")]
        public IWebElement MessageInput { get; set; }

        [FindsBy(How = How.Id, Using = "wpforms-submit-14")]
        public IWebElement ContactFormBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "strong > span")]
        public IWebElement FinalMessage { get; set; }
    }
}
