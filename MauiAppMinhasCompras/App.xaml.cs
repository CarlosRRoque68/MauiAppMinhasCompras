using MauiAppMinhasCompras.Helpers;


namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _Db;

        public static SQLiteDatabaseHelper Db
        {

            get
            {
                if (_Db == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_compras.db3");

                    _Db = new SQLiteDatabaseHelper(path);                
                }
                return _Db;
                
            }  

        }

        public App()
        {
            InitializeComponent();

            //MinPage = new AppShell();
            MainPage = new NavigationPage(new Views.ListaProduto());
        }
    }
}
