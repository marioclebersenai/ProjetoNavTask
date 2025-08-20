namespace ProjetoNavTask
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNextButtonClicked(object sender, EventArgs e)
        {
            // Aqui você implementa a lógica de navegação para a próxima tela.
            // Por exemplo, usando a Shell:
            // await Shell.Current.GoToAsync("//ProximaPagina");

            // Por enquanto, vamos apenas mostrar um alerta para teste.
            await DisplayAlert("Ação", "O botão 'Next' foi clicado!", "OK");
        }
    }

}
