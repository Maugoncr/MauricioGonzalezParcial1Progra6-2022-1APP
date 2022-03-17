using Examen1APPMau.ViewModels;
using Examen1APPMau.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Examen1APPMau
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
