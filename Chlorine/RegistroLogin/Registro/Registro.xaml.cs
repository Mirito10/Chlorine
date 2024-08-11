namespace Chlorine.RegistroLogin.Registro;

    public partial class Registro : ContentPage
{
    public Registro()
    {
        InitializeComponent();
    }

    private async void OnVolverAlLoginClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login.Login());
    }

    private async void OnProfilePictureClicked(object sender, EventArgs e)
    {
        try
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Images,
                PickerTitle = "Selecciona una imagen de perfil"
            });

            if (result != null)
            {
                var stream = await result.OpenReadAsync();
                ((ImageButton)sender).Source = ImageSource.FromStream(() => stream);
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", "No se pudo seleccionar la imagen: " + ex.Message, "OK");
        }
    }
}

