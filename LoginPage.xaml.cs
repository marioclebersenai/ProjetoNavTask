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

        // Opcional: Troca o ícone para dar feedback visual
        var imageButton = sender as ImageButton;
        if (imageButton != null)
        {
            imageButton.Source = PasswordEntry.IsPassword ? "eye_slash.png" : "eye.png";
        }
    }

    private async void OnForgotPasswordTapped(object sender, TappedEventArgs e)
    {
        await DisplayAlert("Navegação", "O usuário esqueceu a senha.", "OK");
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Aqui iria a sua lógica de autenticação
        await DisplayAlert("Login", "Botão de login clicado!", "OK");
    }

    private async void OnRegisterTapped(object sender, TappedEventArgs e)
    {
        await DisplayAlert("Navegação", "Navegar para a tela de registro.", "OK");
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