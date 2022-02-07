using OpenQA.Selenium;

namespace automationTest.UIElements
{
    class Menu
    {
        public IWebElement HomeTab { get=> Driver.driver.FindElement(By.CssSelector("#menu-item-727 > a")); }
        public IWebElement NutreiaTab { get=> Driver.driver.FindElement(By.CssSelector("#menu-item-1842 > a")); }
        public IWebElement AboutTab { get=> Driver.driver.FindElement(By.CssSelector("#menu-item-726 > a")); }
        public IWebElement ServicesTab { get=> Driver.driver.FindElement(By.CssSelector("#menu-item-725 > a")); }
    }
}
