namespace ProjetoNavTask;

public partial class TodoListPage : ContentPage
{
	public TodoListPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("novaTarefa");
    }
}