using SchoolReminder.Services.Interfaces;
using SchoolReminder.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace SchoolReminder.ViewModels
{
    public class LoginViewModel
    {
        public LoginViewModel(IPageDialogService _pageDialogService, INavigationPageService _navigationPageService,
                IUserService _userService)
        {
            this.pageDialogService = _pageDialogService;
            this.navigationPageService = _navigationPageService;
            this.userService = _userService;
        }

        readonly IPageDialogService pageDialogService;
        readonly INavigationPageService navigationPageService;
        readonly IUserService userService;

        public string Email { get; set; }
        public string Password { get; set; }

        public ICommand LogInCommand => new Command(() =>
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                pageDialogService.DisplayAlert("Chyba", "E-mail alebo heslo nie je zadané");
            }
            else
            {
                if (userService.ExistingUser(Email, Password))
                {
                    navigationPageService.NavigationPagePush(new Shell());
                }
                else
                {
                    pageDialogService.DisplayAlert("Chyba", "E-mail alebo heslo je nesprávne");
                }

            }
        });

        public ICommand GoToRegisterCommand => new Command(() =>
        {
            navigationPageService.NavigationPagePush(new RegistrationPage());
        });


    }
}
