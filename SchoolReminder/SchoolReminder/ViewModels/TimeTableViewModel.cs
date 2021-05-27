using SchoolReminder.Models;

namespace SchoolReminder.ViewModels
{
    public class TimeTableViewModel : BaseViewModel
    {
        public Rozvrh Rozvrh { get; }

        public TimeTableViewModel()
        {
            Rozvrh = new Rozvrh("prvy");
        }
    }
}