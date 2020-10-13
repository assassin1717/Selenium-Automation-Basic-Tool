using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace automationTest
{
    public class Actions
    {
        public void SetText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public string GetText(IWebElement element)
        {
            return element.Text;
        }

        public void Scroll(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public void ErrorTrigger(string text)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
            CloseBrowser();
        }

        public void CloseBrowser()
        {
            Driver.driver.Close();
        }

        public void Pause(int num)
        {
            Thread.Sleep(num);
        }

    }
}
