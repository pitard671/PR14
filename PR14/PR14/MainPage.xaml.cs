using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PR14
{
    public partial class MainPage : ContentPage
    {
        Button timerButton;
        bool alive = true;
        public MainPage()
        {
            timerButton = new Button
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            timerButton.Clicked += TimerButton_Clicked;

            Content = timerButton;

            DisplayTime();
        }
        private async void DisplayTime()
        {
            while (alive)
            {
                timerButton.Text = DateTime.Now.ToString("T");
                await Task.Delay(1000);
            }
        }
        private void TimerButton_Clicked(object sender, EventArgs e)
        {
            if (alive == true)
            {
                alive = false;
            }
            else
            {
                alive = true;
                DisplayTime();
            }
        }
    }
}