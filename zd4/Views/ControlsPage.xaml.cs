using System;
using Xamarin.Forms;
using zd4.Models;
using zd4.Services;

namespace zd4.Views
{
    public partial class ControlsPage : ContentPage
    {
        public ControlsPage(string surname = "")
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(surname))
                SurnameLabel.Text = surname;

            ItemPicker.ItemsSource = DataService.GetListItems();
            ItemPicker.SelectedIndex = 0;
        }

        private async void OnStaticClicked(object sender, EventArgs e)
        {
            if (!(ItemPicker.SelectedItem is ListItem selected))
            {
                await DisplayAlert("Внимание", "Выберите значение из списка.", "OK");
                return;
            }

            double sliderMax = ValueSlider.Maximum;
            string message =
                $"Выбрано: {selected.Title}\n" +
                $"Расшифровка: {selected.Description}\n" +
                $"Максимум слайдера: {sliderMax:0}";

            await DisplayAlert("Static", message, "OK");
            ResultLabel.Text = message;
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderValueLabel.Text = $"Значение: {e.NewValue:0}";
        }
    }
}
