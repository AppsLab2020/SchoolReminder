using SchoolReminder.Services.Interfaces;
using System.Threading.Tasks;

namespace SchoolReminder.Services
{
    public class PageDialogService : IPageDialogService
    {
        public async Task DisplayAlert(string title, string message, string okText = "Ok")
        {
            await App.Current.MainPage.DisplayAlert(title, message, okText);
        }
    }
}

