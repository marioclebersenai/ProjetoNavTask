namespace ProjetoNavTask;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void TogglePasswordVisibility(object sender, EventArgs e)
    {
        // Alterna a propriedade IsPassword do Entry
        PasswordEntry.IsPassword = !PasswordEntry.IsPassword;

        // Opcional: Troca o �cone para dar feedback visual
        var imageButton = sender as ImageButton;
        if (imageButton != null)
        {
            imageButton.Source = PasswordEntry.IsPassword ? "eye_slash.png" : "eye.png";
        }
    }

    private async void OnForgotPasswordTapped(object sender, TappedEventArgs e)
    {
        await DisplayAlert("Navega��o", "O usu�rio esqueceu a senha.", "OK");
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Aqui iria a sua l�gica de autentica��o
        await DisplayAlert("Login", "Bot�o de login clicado!", "OK");
    }

    private async void OnRegisterTapped(object sender, TappedEventArgs e)
    {
        await DisplayAlert("Navega��o", "Navegar para a tela de registro.", "OK");
    }

    private async void OnGoogleLoginClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Login Social", "Iniciando fluxo de login com Google.", "OK");
    }

    private async void OnFacebookLoginClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Login Social", "Iniciando fluxo de login com Facebook.", "OK");
    }
}