namespace ProjetoNavTask;

public partial class TodoListPage : ContentPage
{
	public TodoListPage()
	{
		InitializeComponent();
	}

    // M�todo gen�rico para os cliques nos �cones do cabe�alho
    private async void OnHeaderIconClicked(object sender, EventArgs e)
    {
        await DisplayAlert("A��o do Cabe�alho", "Um �cone foi clicado!", "OK");
    }

    // Evento para o filtro que parece um dropdown
    private async void OnFilterDropdownTapped(object sender, TappedEventArgs e)
    {
        // Em um app real, isso poderia abrir um menu ou um Picker
        string action = await DisplayActionSheet("Filtrar por Status", "Cancelar", null, "On Going", "Completed", "All");

        // Aqui voc� usaria a 'action' para filtrar os dados da sua CollectionView
    }

    private async void OnAddTaskClicked(object sender, EventArgs e)
    {
        // Navega para a p�gina de cria��o de nova tarefa
        // await Shell.Current.GoToAsync("//AddTaskPage");
        await DisplayAlert("Navega��o", "Indo para a tela 'Adicionar Nova Tarefa'.", "OK");
    }
}