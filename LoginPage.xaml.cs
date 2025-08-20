using System.Threading.Tasks;

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

    
}