using projetdm1.Vues;

namespace projetdm1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new VueProduits());

        }
    }
}
