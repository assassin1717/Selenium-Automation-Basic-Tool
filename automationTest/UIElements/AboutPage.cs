using OpenQA.Selenium;

namespace automationTest.UIElements
{
    class AboutPage
    {
        public IWebElement FormTitleText { get => Driver.driver.FindElement(By.CssSelector("div > h1")); }
        public IWebElement FirstBoxTitle { get=> Driver.driver.FindElement(By.CssSelector("div.elementor-element.elementor-element-1ee123e2.elementor-widget.elementor-widget-heading > div > h3")); }
        public IWebElement SecondBoxTitle { get=> Driver.driver.FindElement(By.CssSelector("div.elementor-element.elementor-element-dda7c65.elementor-widget.elementor-widget-heading > div > h3")); }
        public IWebElement FirstTextBox { get=>Driver.driver.FindElement(By.CssSelector("div.elementor-element.elementor-element-abb4b96.elementor-widget.elementor-widget-text-editor > div > div")); }
        public IWebElement SecondTextBox { get=>Driver.driver.FindElement(By.CssSelector("div.elementor-element.elementor-element-afa68de.elementor-widget.elementor-widget-text-editor > div > div")); }
        public IWebElement NumbersDiv { get => Driver.driver.FindElement(By.CssSelector("section.elementor-section.elementor-top-section.elementor-element.elementor-element-131ffd2d.elementor-section-content-middle.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div.elementor-background-overlay")); }
    }
}
