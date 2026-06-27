using System;
using Xamarin.Forms;

namespace zd4.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void OnSignInClicked(object sender, EventArgs e)
        {
            string surname = UsernameEntry.Text?.Trim();
            string password = PasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(surname))
            {
                await DisplayAlert("Ошибка", "Введите фамилию пользователя.", "OK");
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Ошибка", "Введите пароль.", "OK");
                return;
            }
            if (password.Length < 3)
            {
                await DisplayAlert("Ошибка", "Пароль должен содержать не менее 3 символов.", "OK");
                return;
            }
            await Navigation.PushAsync(new ControlsPage(surname));
        }

        private async void OnForgotPasswordTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Восстановление", "Обратитесь к администратору.", "OK");
        }
    }
}
