namespace ProjetoNavTask;

public partial class NewTaskPage : ContentPage
{
	public NewTaskPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }
}