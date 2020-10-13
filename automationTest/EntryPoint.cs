
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

            menu.ContactsTab.Click();

            if (actions.GetText(about.FormTitleText).Equals("Fale conosco"))
            {
                actions.SetText(about.NameInput, "Tiago André");

                actions.SetText(about.TitleInput, "Message Test");

                actions.SetText(about.EmailInput, "tiago.eugenio.andre@gmail.com");

                actions.SetText(about.MessageInput, "Message body test");

                actions.Scroll(about.ContactFormBtn);

                about.ContactFormBtn.Click();

                actions.Pause(500);

                if (!actions.GetText(about.FinalMessage).Equals("Obrigado por nos contatar! Entraremos em contato contigo em breve."))
                {
                    actions.ErrorTrigger("Error sending message");
                }
            }
            else
            {
                actions.ErrorTrigger("Error getting the page");
            }

            actions.CloseBrowser();
        }
    }
}
