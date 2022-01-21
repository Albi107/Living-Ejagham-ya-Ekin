using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Museum_Practitioner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Chapters_in_Books : ContentPage
    {
        public Chapters_in_Books()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
           Chpts.ItemsSource = new Chapters.ChapterService().GetChaptersList();
        }

        public class Chapters
        { 
            public class ChapterCut
            {
                public string BookName { get; set; }
                public string BookDescription { get; set; }
                public string BookImage { get; set; }
                public string Authors { get; set; }
                public string Year { get; set; }
                public string ButtonClicked { get; set; }
            }
            public class ChapterService
            {
                public List<ChapterCut> GetChaptersList()
                {
                    return new List<ChapterCut>()
                {
                new ChapterCut()
                {BookName = "Public Archaeology and Cultural Resource Management in Nigeria: Resource Conservation and Management of Archeology.", BookImage = "WA0028.jpg", BookDescription = "We will begin our discussion by looking closely at the development " +
                "of the con¬cept of Public Archaeology and Cultural Resource Management in Nigeria. This will enable us recall and appreciate certain important functionaries in the history of Nigerian cultural heritage engineering and management. This will then " +
                "be followed by examining the effect of our country's period of trans¬formation on cultural resources and their conservation and development. It is hoped that with a deeper understanding and appreciation of what has been done so far, and the " +
                "enormous problem ahead, a more sympathetic, meaning¬ful and acceptable attitude will be developed by the citizens of this country and the organs responsible for funding the cultural institutions responsible for the protection and preservation " +
                "of Nigerian cultural property. Nigeria is particularly rich in prehistoric sites and historic monuments. A lot has been done since the establishment of the concept of archaeology and cultural materials collection in Nigeria. We have witnessed" +
                " the 2000 years ancient art of Nigeria. All these have yielded examples of fine workmanship whether in stone, pottery, bronze, iron or wood. These assemblages are now preserved in museums throughout Nigeria.", Authors = "Abu S. Edet", Year = "Published 2019", ButtonClicked = "https://www.researchgate.net"},
                new ChapterCut ()
                {BookName = "The Dynamics of Arts and Crafts Business in Nigeria", BookImage = "WA0021.jpg", BookDescription = "Trading in arts and crafts products is a way of creating deeper knowledge of the cultural, historic, and " +
                "religious background of the people of the world. this helps to achieve a peaceful and " +
                "cordial climate of understanding and respect in the art of human existence. Profits from such trade enhance the economy " +
                "of the respective countries, and encourage production, investments and entrepreneurship. Nigerian "  +
                "traditional craft is at a cross road and there are many forces pulling in different directions. On the one hand, government pays little heed to developing this sector" +
                " of the economy, and on the other hand artists, craftsmen, investors, and enlightened planners" +
                " are the visionaries upon whom the future of Nigerian traditonal crafts can only be assured if a balance between" +
                " development and utilization is achieved", Authors = "Abu S. Edet", Year = "Published 2019", ButtonClicked="https://www.researchgate.net/publication/337403800_The_Dynamics_of_Arts_and_Crafts_Business-_Problems_and_Prospects_in_Nigeria-_18-Nov-2019_17-25-061" },
                    new ChapterCut()
                    { BookName = "Cultural Heritage: A tool for Poverty Eradication and Social Development in Nigeria", BookImage = "WA0027.jpg", BookDescription = "Cultural resources are " +
                    "pivoted to the development of heritage industry, tourism and economic fortune of a nation. Nigeria has a diverse and rich heritage consisting of natural and cultural sites of " +
                    "universal importance. Economy and cultural imperatives are recognized as the most powerful forces shaping human development. This paper looks at how preserving and promoting " +
                    "cultural heritage is fundamental to the eradication of poverty and usher in peace and harmony and the importance of community participation in implementing such measures. " +
                    "The paper examines federal government policy and the practical challenges of empowering people to harness the economic potentials of their cultural heritage for their " +
                    "material benefits. And therefore recommend the need for the federal, State and Local Government to put in place measures by which youths amongst others are empowered " +
                    "thereby reduction of poverty through the exploitation of our cultural heritage.",Authors="Abu S. Edet", Year="2019", ButtonClicked="https://www.researchgate.net/publication/337339979_Cultural_Heritage-_A_Tool_for_Poverty_Eradication_and_Social_Development_in_Nigeria-_15-Nov-2019_12-47-38" }
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


