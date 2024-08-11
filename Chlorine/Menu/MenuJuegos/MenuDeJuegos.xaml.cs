namespace Chlorine.Menu.MenuJuegos;

public partial class MenuDeJuegos : ContentPage
{
	public MenuDeJuegos()
	{
		InitializeComponent();
	}
    private async void OnVolverAlMenuPrincipalClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}