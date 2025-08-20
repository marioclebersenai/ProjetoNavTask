namespace ProjetoNavTask;

public partial class TodoListPage : ContentPage
{
	public TodoListPage()
	{
		InitializeComponent();
	}

    // Método genérico para os cliques nos ícones do cabeçalho
    private async void OnHeaderIconClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Ação do Cabeçalho", "Um ícone foi clicado!", "OK");
    }

    // Evento para o filtro que parece um dropdown
    private async void OnFilterDropdownTapped(object sender, TappedEventArgs e)
    {
        // Em um app real, isso poderia abrir um menu ou um Picker
        string action = await DisplayActionSheet("Filtrar por Status", "Cancelar", null, "On Going", "Completed", "All");

        // Aqui você usaria a 'action' para filtrar os dados da sua CollectionView
    }

    private async void OnAddTaskClicked(object sender, EventArgs e)
    {
        // Navega para a página de criação de nova tarefa
        // await Shell.Current.GoToAsync("//AddTaskPage");
        await DisplayAlert("Navegação", "Indo para a tela 'Adicionar Nova Tarefa'.", "OK");
    }
}