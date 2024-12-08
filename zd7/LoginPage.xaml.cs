using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        private async void OnLoginButtonClicked (object sender, EventArgs e)
        {
            string login = this.FindByName<Entry>("LoginEntry").Text;
            string password = this.FindByName<Entry>("PasswordEntry").Text;

            if (login == "ects" && password == "ects2024")
            {
                await DisplayAlert("Успех", "Вы успешно вошли!", "OK");

                await Navigation.PushAsync(new AppCarouselPage(120));
            }
            else
            {
                var context = Android.App.Application.Context;
                Toast.MakeText(context, "Неверный логин или пароль", ToastLength.Short).Show( );
            }
        }
    }
}