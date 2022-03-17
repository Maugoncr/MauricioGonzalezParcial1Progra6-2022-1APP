using Examen1APPMau.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen1APPMau.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        private void CmdVerContra(object sender, ToggledEventArgs e)
        {
            if (SwSeePassword.IsToggled)
            {

                TxtPassword.IsPassword = false;


            }
            else
            {
                TxtPassword.IsPassword = true;
            }

        }

        private async void CmdRegistrar(object sender, EventArgs e)
        {


            await Navigation.PushAsync(new RegistroUsuarioPage());


        }
    }
}