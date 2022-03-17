using Examen1APPMau.Services;
using Examen1APPMau.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen1APPMau
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
