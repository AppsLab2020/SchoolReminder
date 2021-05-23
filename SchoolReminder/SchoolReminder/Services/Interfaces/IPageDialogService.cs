using System.Threading.Tasks;

namespace SchoolReminder.Services.Interfaces
{
    public interface IPageDialogService
    {
        Task DisplayAlert(string title, string message, string okText = "Ok");
    }
}
