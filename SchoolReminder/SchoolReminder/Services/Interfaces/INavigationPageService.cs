using System.Threading.Tasks;
using Xamarin.Forms;


namespace SchoolReminder.Services.Interfaces
{
    public interface INavigationPageService
    {
        Task NavigationPagePush(Page page);
        Task NavigationPagePop();
    }
}
