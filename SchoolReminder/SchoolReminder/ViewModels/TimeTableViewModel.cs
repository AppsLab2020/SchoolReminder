using SchoolReminder.Models;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SchoolReminder.ViewModels
{
    public class TimeTableViewModel : BaseViewModel
    {

        public Rozvrh Rozvrh;
        public TimeTableViewModel()
        {
            Rozvrh = new Rozvrh("prvy");
 
        }
       



    }
}