namespace Chlorine
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RegistroLogin.Login.Login());
        }

    }
}
