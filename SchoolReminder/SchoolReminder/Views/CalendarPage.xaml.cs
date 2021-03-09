using SchoolReminder.Models;
using SchoolReminder.ViewModels;
using SchoolReminder.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchoolReminder.Views
{
    public partial class CalendarPage : ContentPage
    {
        CalendarViewModel _viewModel;

        public CalendarPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new CalendarViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Alert!", "Určite chceš ukončiť aplikáciu?", "Áno", "Nie");
                if (result) await this.Navigation.PopAsync();
            });

            return true;
        }
    }
}