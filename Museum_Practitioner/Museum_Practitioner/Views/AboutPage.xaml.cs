using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Museum_Practitioner.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Publication());
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Chapters_in_Books());
        }

        private async void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Online_Publications());
        }

        private async void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Foreign_Conference_Papers_Presented());
        }

        private  async void ImageButton_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Local_Conference_Papers());
        }

        private  async void ImageButton_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Workshop());
        }

        private async void ImageButton_Clicked_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Other_Articles_Papers_and_Lectures());
        }

        private async void ImageButton_Clicked_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Special_Posters());
        }

        private  async void ImageButton_Clicked_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exhibition_Designed_and_Curated());
        }
    }
}