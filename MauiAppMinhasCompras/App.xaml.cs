namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MinPage = new AppShell();
            MainPage = new NavigationPage(new Views.ListaProduto());
        }
    }
}
