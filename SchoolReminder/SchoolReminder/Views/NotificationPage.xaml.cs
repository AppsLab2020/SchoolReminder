using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.LocalNotifications;

namespace SchoolReminder.Views
{

    public partial class NotificationPage : ContentPage
    {
        public NotificationPage()
        {
            InitializeComponent();
        }
      

        public void Button_Clicked(object sender, EventArgs e)
        {
            string a;
            a = nadpis.Text;
                string b;
            b = obsah.Text;
            CrossLocalNotifications.Current.Show(a,b, 5);

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