using Examen1APPMau.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Examen1APPMau.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}