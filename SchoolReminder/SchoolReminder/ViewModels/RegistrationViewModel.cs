using SchoolReminder.Models;
using SchoolReminder.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SchoolReminder.ViewModels
{
    public class RegistationViewModel
    {
        public RegistationViewModel(IPageDialogService pageDialogService, INavigationPageService navigationPageService, IUserService userService)
        {
            this.pageDialogService = pageDialogService;
            this.navigationPageService = navigationPageService;
            this.userService = userService;
        }
        readonly IPageDialogService pageDialogService;
        readonly INavigationPageService navigationPageService;
        readonly IUserService userService;

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public ICommand RegisterCommand => new Command(() =>
        {
            if (string.IsNullOrEmpty(Name))
            {
                pageDialogService.DisplayAlert("Chyba", "Musíte zadať meno");
            }
            else if (string.IsNullOrEmpty(Email))
            {
                pageDialogService.DisplayAlert("Chyba", "Musíte zadať e-mail");
            }
            else if (string.IsNullOrEmpty(Password))
            {
                pageDialogService.DisplayAlert("Chyba", "Musíte zadať heslo");
            }
            else if (string.IsNullOrEmpty(ConfirmPassword))
            {
                pageDialogService.DisplayAlert("Chyba", "Musíte potvrdiť svoje heslo");
            }
            else if (Password != ConfirmPassword)
            {
                pageDialogService.DisplayAlert("Chyba", "Hesla sa nezhodujú, zadajte ich prosím znova");
            }
            else
            {
                if (userService.ExistingEmail(Email))
                {
                    pageDialogService.DisplayAlert("Existujúci e-mail", "E-mail už existuje, vyberte iný ");
                }
                else
                {
                    var user = new User();
                    user.Name = Name;
                    user.Email = Email.ToLower();
                    user.Password = Password;

                    userService.AddUser(user);

                    pageDialogService.DisplayAlert("Vytvorené", "Používateľ bol úspešne vytvorený ");

                    navigationPageService.NavigationPagePop();
                }

            }
        });
    }
}