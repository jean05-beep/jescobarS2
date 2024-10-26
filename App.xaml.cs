using jescobarS2.Views;

namespace jescobarS2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Estudiante();
        }
    }
}
