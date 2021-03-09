using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SchoolReminder.ViewModels;
using SchoolReminder.Views;

namespace SchoolReminder.Views
{
    public partial class TimeTablePage : ContentPage
    {
        public TimeTablePage()
        {
            InitializeComponent();
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