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
    public partial class RegistroUsuarioPage : ContentPage
    {
        public RegistroUsuarioPage()
        {
            InitializeComponent();
        }

        private async void CmdVolver(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}