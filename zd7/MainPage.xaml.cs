using Android.Content;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace zd7
{
    public partial class MainPage : ContentPage
    {
        double money;
        public MainPage(Cake cake)
        {
            InitializeComponent();
            AddLines(cake);
            money = cake.price;
        }

        private void AddLines(Cake cake)
        {
            this.FindByName<Image>("image").Source = cake.image;
            this.FindByName<Label>("name").Text = $"Название торта: {cake.name}";
            this.FindByName<Label>("category").Text = $"Категория: {cake.category}";
            this.FindByName<Label>("ed").Text = $"Единица измерения: {cake.ed}";
            this.FindByName<Label>("fats").Text = $"Жиры: {cake.fats}";
            this.FindByName<Label>("protein").Text = $"Белки: {cake.protein}";
            this.FindByName<Label>("carbohydrates").Text = $"Углеводы: {cake.carbohydrates}";
            this.FindByName<Label>("vitamins").Text = $"Витамины: {cake.vitamins}";
            this.FindByName<Label>("price").Text = $"Цена: {cake.price}";
            this.FindByName<Label>("postav").Text = $"Поставщик: {cake.postav}";
            this.FindByName<Label>("quantity").Text = $"Количество: {cake.quantity}";
            this.FindByName<Label>("recept").Text = $"Рецепт: {cake.recept}";

        }

        private async void OnCalculateCostClicked(object sender, EventArgs e)
        {
            double kilo =Convert.ToDouble(this.FindByName<Entry>("QuantityInfoEntry").Text);
            if (kilo > 0.5 && kilo <= 10)
            {
                await Navigation.PushAsync(new CostCalculatorPage(money, kilo));
            }
            else
            {
                var context = Android.App.Application.Context;
                Toast.MakeText(context, "Вес от 0.5 до 10 кг", ToastLength.Short).Show( );
            }
        }

        private async void OnReturnToMainPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppCarouselPage(120));
        }
        
    }
}
