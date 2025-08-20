namespace ProjetoNavTask
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registra as rotas para navegação
            Routing
                .RegisterRoute("novaTarefa", 
                            typeof(NewTaskPage));
        }
    }
}
