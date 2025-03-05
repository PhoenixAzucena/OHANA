using Microsoft.Maui.Controls;

namespace Ohana
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            logIn.Clicked += OnLogInButtonClicked;
        }

        private async void OnLogInButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PersonnelPage());
        }
    }
}