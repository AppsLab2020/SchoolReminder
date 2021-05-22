using SchoolReminder.ViewModels;
using SchoolReminder.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using SchoolReminder.Models;

using SQLite;
using System.Threading.Tasks;
using System.IO;

namespace SchoolReminder
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }


        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LogiPage");
        }
    }

    public partial class App : Application
    {
    }
}
