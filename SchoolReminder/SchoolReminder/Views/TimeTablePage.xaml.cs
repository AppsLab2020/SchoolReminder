using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SchoolReminder.ViewModels;
using SchoolReminder.Views;
using System.IO;
    using SQLite;

namespace SchoolReminder.Views
{
    public partial class TimeTablePage : ContentPage
    {
        public TimeTablePage()
        {
            InitializeComponent();
        ///    using var conn = new SQLiteConnection(Path.Combine(App.FilePath, "rozvrh_db.db3"));
           /// var enteries = conn.Table<Entries>().ToList();
         ///   Pondelok1.Text = enteries[0].Pon1;

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