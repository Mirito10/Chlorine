using Chlorine.Menu.MenuPrincipal;

namespace Chlorine.RegistroLogin.Login;

public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
    }

    private async void Boton_Loguearse(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPrincipal());
    }

    private async void Boton_Registrarse(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Registro.Registro());
    }
}