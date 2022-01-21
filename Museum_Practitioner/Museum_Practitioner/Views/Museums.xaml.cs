using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Museum_Practitioner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Museums : ContentPage
    {
        public Museums()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Images.ItemsSource = new MuseumsP.MuseumsService().GetmuseumsList();
        }
        public class MuseumsP
        {
            public class MuseumCut
            {
                public string Name { get; set; }
                public string Description { get; set; }
                public string Image { get; set; }
                public string Authors { get; set; }
                public string Year { get; set; }
                
            }
            public class MuseumsService
            {
                public List<MuseumCut> GetmuseumsList()
                {
                    return new List<MuseumCut>()
                {
                        //Museums in alphabetical order
                new MuseumCut()
                {Name = "National Museum Calabar", Image = "calmun.jpg", Description = "Also known as the old residency, is a 19th century building set on a hill overlooking the Calabar river.  " +
                "The building was originally designed and built in Britain in 1959 before it was then moved in parts to Nigeria. It used to serve as the residence and administrative office of the " +
                "British officials during the colonial era. It contains artifacts, documents and several materials from colonial times."},
                new MuseumCut()
                {Name = "National Museum of Colonial History", Image = "abianat.jpg", Description = "National Museum of Colonial History was established in 1985. " +
                "of the post-colonial era. "},
                    new MuseumCut()
                    { Name = "National Museum Lagos", Image = "lagmus.jpg", Description = "Also known as the Nigerian National Museum has a notable collection " +
                    "of Nigerian art, including pieces of statuary and carvings and archaeological and ethnographic exhibits.Worthy of note is a terracotta human head known as the Jemaa Head, part of the Nok culture."}
                 };
                }

            }
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                await Browser.OpenAsync((string)(sender as Button).CommandParameter, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception)
            {
                //"An unexpected error occured. No browser may be installed on the device.";
            }

        }

    }
}
