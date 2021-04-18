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
            string c;
            c = dni.Text;
            double k;
            k = double.Parse(c) * 3600 * 24;

            string d;
            d = hodiny.Text;
            double h;
            h = double.Parse(d) * 3600;



            string f;
            f = minuty.Text;
            double i;
            i = double.Parse(f) * 60;



            string g;
            g = sekundy.Text;
            double j;
            j = double.Parse(g);


            CrossLocalNotifications.Current.Show(a, b, 5, DateTime.Now.AddSeconds(h+i+j+k));
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