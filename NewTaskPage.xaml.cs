namespace ProjetoNavTask;

public partial class NewTaskPage : ContentPage
{
	public NewTaskPage()
	{
		InitializeComponent();
	}

    private void OnCategoryClicked(object sender, EventArgs e)
    {
        if (sender is not Button clickedButton)
            return;

        // Troca os estilos para dar o feedback visual de seleção.
        // Em uma arquitetura MVVM, isso seria controlado por binding de dados.
        if (clickedButton == PersonalButton)
        {
            PersonalButton.Style = (Style)Application.Current.Resources["SegmentedButtonSelected"];
            GroupButton.Style = (Style)Application.Current.Resources["SegmentedButtonUnselected"];
        }
        else if (clickedButton == GroupButton)
        {
            PersonalButton.Style = (Style)Application.Current.Resources["SegmentedButtonUnselected"];
            GroupButton.Style = (Style)Application.Current.Resources["SegmentedButtonSelected"];
        }
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        // Volta para a página anterior
        if (Navigation.NavigationStack.Count > 1)
        {
            await Navigation.PopAsync();
        }
    }

    private async void OnCreateClicked(object sender, EventArgs e)
    {
        // Aqui você adicionaria a lógica para salvar a nova tarefa
        await DisplayAlert("Sucesso", "Tarefa criada!", "OK");

        // Volta para a página anterior após criar
        if (Navigation.NavigationStack.Count > 1)
        {
            await Navigation.PopAsync();
        }
    }
}