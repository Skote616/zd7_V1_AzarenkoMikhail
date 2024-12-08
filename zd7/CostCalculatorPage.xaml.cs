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
    public partial class CostCalculatorPage : ContentPage
    {
        Cake cake;
        double money, kilo;
        public CostCalculatorPage(double money, double kilo)
        {
            InitializeComponent();
            this.FindByName<Label>("PriceEntry").Text = $"Цена за кг: {money}";
            this.FindByName<Label>("QuantityCalEntry").Text = $"Количество кг: {kilo}";
            this.money = money;
            this.kilo = kilo;
        }

        private async void OnCalculateClicked(object sender, EventArgs e)
        {
            double fullp = 0;
            switch (this.FindByName<Picker>("ComplexityPicker").SelectedIndex)
            {
                case 0:
                {
                     fullp = (money * kilo) * 0.4 + (money * kilo);
                    break;
                }

                case 1:
                {
                     fullp = (money * kilo) * 0.2 + (money * kilo);
                    break;
                }

                case 2:
                {
                     fullp = (money * kilo) * 0.1 + (money * kilo);
                    break;
                }

                default:
                {
                     fullp = (money * kilo);
                    break;
                }

            }

            this.FindByName<Label>("ResultLabel").Text = $"Рассчитанная стоимость: {fullp}";

            await Navigation.PushAsync(new AppCarouselPage(fullp));
        }

        private async void OnReturnToMainPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppCarouselPage(120));
        }

        private async void OnReturnToRootPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(cake));
        }
    }
}