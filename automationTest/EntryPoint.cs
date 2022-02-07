
using automationTest.UIElements;

namespace automationTest
{
    class EntryPoint
    {
        static void Main()
        {
            HomePage home = new HomePage();
            Menu menu = new Menu();
            AboutPage about = new AboutPage();
            NavigateTo navigate = new NavigateTo();
            Actions actions = new Actions();

            navigate.Navigate(Globals.BaseUrl);

            actions.Pause(1200);

            home.AcceptCookies.Click();

            menu.AboutTab.Click();

            if (actions.GetText(about.FormTitleText).Equals("Sobre Nós"))
            {
                actions.GetText(about.FirstBoxTitle).Equals("Quem somos?");

                actions.GetText(about.SecondBoxTitle).Equals("A missão?");

                actions.GetText(about.FirstTextBox).Contains("Uma Nutricionista e um Informático juntos");

                actions.GetText(about.SecondTextBox).Contains("Tornar a nossa vida mais facil");

                actions.Scroll(about.NumbersDiv);

                actions.Pause(500);
            }
            else
            {
                actions.ErrorTrigger("Error getting the page");
            }

            actions.CloseBrowser();
        }
    }
}
