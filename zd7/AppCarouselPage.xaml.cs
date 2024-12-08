using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using zd7;
namespace zd7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppCarouselPage : CarouselPage
    {
        public AppCarouselPage (double fullp)
        {
            InitializeComponent( );
            var cakelist = new List<Cake>
    {
        new Cake("poleno.jpeg", "Полено", "Слоенный", "Кг", "A, Ca, B2", "ТортоЛюбов", "Снимаю с торта пленку.", 37.7, 42.2, 8.5, 120.5, 2),
        new Cake("vivaldi.jpeg", "Вивальди", "Бисквитный", "Кг", "B, Ca, C", "ВашДесерт", "Торт приготовлен на основе классического шоколадного бисквита.", 12.8, 52.6, 4.3, 165.2, 12)
    };

            Children.Add(CreateCakePage("Полено", "poleno.jpg", fullp, cakelist [ 0 ]));
            Children.Add(CreateCakePage("Вивальди", "vivaldi.jpg", fullp, cakelist [ 1 ]));
        }

        private ContentPage CreateCakePage (string title, string imageSource, double price, Cake cake)
        {
            return new ContentPage
            {
                Title = title,
                Content = new StackLayout
                {
                    Padding = new Thickness(10),
                    Spacing = 10,
                    Children =
            {
                new Label
                {
                    Text = "Онлайн-кулинария (заказ и покупка тортов)",
                    TextColor = Color.Blue,
                    FontAttributes = FontAttributes.Italic,
                    FontSize = 20,
                    HorizontalOptions = LayoutOptions.Center
                },
                new Label
                {
                    Text = "Дата: " + DateTime.Now.ToString("dd.MM.yyyy"),
                    TextColor = Color.Red,
                    FontAttributes = FontAttributes.Italic,
                    FontSize = 15,
                    HorizontalOptions = LayoutOptions.Center
                },
                new Image
                {
                    Source = imageSource,
                    HeightRequest = 200,
                    HorizontalOptions = LayoutOptions.Center
                },
                new Label
                {
                    Text = title,
                    FontSize = 20,
                    HorizontalOptions = LayoutOptions.Center
                },
                new Label
                {
                    Text = $"Цена: {price}",
                    FontSize = 16,
                    HorizontalOptions = LayoutOptions.Center
                },
                new Label
                {
                    Text = "Единица измерения: Кг",
                    FontSize = 16,
                    HorizontalOptions = LayoutOptions.Center
                },
                new Button
                {
                    Text = "Перейти к информации",
                    Margin = new Thickness(50, 10),
                    Command = new Command(async () =>
                    {
                        await Navigation.PushAsync(new MainPage(cake));
                    })
                }
            }
                }
            };
        }

    }
}