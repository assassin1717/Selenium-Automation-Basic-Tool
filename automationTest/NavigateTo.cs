

namespace automationTest
{
    public class NavigateTo
    {
        public void Navigate(string url)
        {
            Driver.driver.Navigate().GoToUrl(url);
        }
    }
}
