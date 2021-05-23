using SchoolReminder.Services;
using SchoolReminder.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchoolReminder.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
            this.BindingContext = new RegistationViewModel(new PageDialogService(), new NavigationPageService(), new UserService());
        }

    }
}