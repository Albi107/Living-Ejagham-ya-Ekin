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
    public partial class Conference_Papers : ContentPage
    {
        public Conference_Papers()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ConP.ItemsSource = new Conference.ConferenceService().GetConferenceList();
        }

        public class Conference
        {
            public class ConferenceCut
            {
                public string BookName { get; set; }
                public string BookDescription { get; set; }
                public string BookImage { get; set; }
                public string Conference { get; set; }
                public string Year { get; set; }
                public string ButtonClicked { get; set; }
            }
            public class ConferenceService
            {
                public List<ConferenceCut> GetConferenceList()
                {
                    return new List<ConferenceCut>()
                {
                new ConferenceCut()
                {BookName = "The Cultural Properties of Nigeria", BookImage = "", BookDescription = "", Conference = "Tokyo National Research Institute of Cultural Properties", Year = "1994", ButtonClicked = "" },
                new ConferenceCut ()
                {BookName = "Fire Impact on the Monoliths and Sites in the Cross River Region", BookImage = "", BookDescription = "", Conference = "Prague Environmental Conference, Czech Republic", Year = "1998", ButtonClicked = "" },
                    new ConferenceCut()
                    { BookName = "Presentation of Environmental History in Tropical Africa: The Role of Environmental Archaeologist", BookImage = "", BookDescription = "",Conference="13th Colloquium of the West African Archaeology Association Held at Abidjan Ivory Coast", ButtonClicked = "" }
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
                await DisplayAlert("Conference text", "Coming soon", "Ok");
            }

        }

    }
}