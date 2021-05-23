using SchoolReminder.Services.Interfaces;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SchoolReminder.Services
{
    public class NavigationPageService : INavigationPageService
    {
        public async Task NavigationPagePush(Page page)
        {
            await App.Current.MainPage.Navigation.PushAsync(new NavigationPage());
        }
        public async Task NavigationPagePop()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
