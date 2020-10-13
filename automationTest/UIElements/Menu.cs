

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace automationTest.UIElements
{
    class Menu
    {
        public Menu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "menu-item-1548")]
        public IWebElement HomeTab { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-828")]
        public IWebElement AboutTab { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-2045")]
        public IWebElement ServicesTab { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-829")]
        public IWebElement ContactsTab { get; set; }
    }
}
