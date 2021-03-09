using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SchoolReminder.ViewModels
{
    public class TimeTableViewModel : BaseViewModel
    {
        public TimeTableViewModel()
        {
            Title = "Rozvrh";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}