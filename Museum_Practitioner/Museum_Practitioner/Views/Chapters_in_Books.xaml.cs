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
            }
            public class ChapterService
            {
                public List<ChapterCut> GetChaptersList()
                {
                    return new List<ChapterCut>()
                {
                new ChapterCut()
                {BookName = "Public Archaeology and Cultural Resource Management in Nigeria: Resource Conservation and Management of Archeology.", BookImage = "WA0028.jpg", BookDescription = "Biological growth on the surface of basalt rock monoliths by a wide variety of microorganisms including bacteria, (fungi and algae), lichens, mosses and liverworts were studied. " +
                "Microscopic identification, quantification and an ecological classification of the micro-organisms on two different sites were made to aid the study of their implication in crack and pitting observed on monoliths surface. " +
                "The result of this study reveal significant differences and some similarities in growth between the chosen sites and the existence of some of the micro-organisms family species in Japan. " +
                "A complex biotic chemical weathering on the surface of the monoliths was distinguished. " +
                "Over 450 of the cylindrical monoliths are affected. The communities in this region regard the monolith to represent their ancestors. " +
                "The monoliths are monuments protected as important cultural property of national interest.", Authors = "Abu S. Edet", Year = "Published 1990" },
                new ChapterCut ()
                {BookName = "The Dynamics of Arts and Crafts Business in Nigeria", BookImage = "WA0021.jpg", BookDescription = "Corruption is a scandal that has been with human beings from antiquity" +
                " to the present (Tylor, 1871). It pervades and permeates society. Corruption in Nigeria has assumed a enormous proportion and has constituted a serious national problem. Government put " +
                "in place some machinery to fight corruption but to no avail. This paper looks at cultural education and the teaching of the history of peoples as a weapon of overriding strategic importance. " +
                "The role of museum as the promoter of cultural education for combating corruption was studied.Evidence from various researchers such as Okolo (2008), Muthoga(1994), Musheshe(1994) and " +
                "Cockfort (1994) on the subject of corruption indicate that corruption is embedded in every society.This study examined the nature and types of programmes the museum undertakes and those that " +
                "would be suitable and more effective in educating the different members of the public against corrupt practices.The study looks at museum tools such as mass media campaign, mobile public awareness, " +
                "youth education, children enlightenment, anti-corruption workshops and seminar series, advocacy and effective use of cultural resources in public lectures, and exhibitions. Finally it recommends " +
                "the use of cultural education as effective tool for combating corruption and evolving new orientation for society. ", Authors = "Abu S. Edet", Year = "Published 20o4" },
                    new ChapterCut()
                    { BookName = "Cultural Heritage: A tool for Poverty Eradication and Social Development in Nigeria", BookImage = "WA0027.jpg", BookDescription = "The Cross River Monolith, bclg,CRTUd,tu,qIGOUQ UGWuibv/oP//BVYVIW BHIWG bcbiw iwyieyggyliw  iwyEF8YGF VFLVUVL yeg792    ahhfviyvaif vauvfyi IE9Pje",Authors="Abu S. Edet" }
                 };
              }
            }
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            
            await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }
        public ICommand OpenWebCommand { get; }
    }
}


