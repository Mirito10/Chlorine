namespace Chlorine.Menu.MenuPrincipal;

using Chlorine.Menu.MenuJuegos;
using Chlorine.RegistroLogin.Login;


public partial class MenuPrincipal : ContentPage
{
	public MenuPrincipal()
	{
		InitializeComponent();
	}
    private async void OnSalirClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegistroLogin.Login.Login());
    }

    private async void BotonAMenuJuegos(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuDeJuegos());
    }
}