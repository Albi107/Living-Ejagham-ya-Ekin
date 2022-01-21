using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Windows.Input;
using System.Threading.Tasks;
using static Museum_Practitioner.Views.Publication.Journals;

namespace Museum_Practitioner.Views
{
   
    public partial class Publication : ContentPage
    {
       

        public Publication()
        {
            InitializeComponent();
           // this.ButtonClicked.Text = "Learn more";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Pubs.ItemsSource = new Journals.JournalService().GetChaptersList();
        }

        
        public class Journals
        {
            public class JournalCut
            {
                public string BookName { get; set; }
                public string BookDescription { get; set; }
                public string BookImage { get; set; }
                public string Authors { get; set; }
                public string Year { get; set; }
                public string ButtonClicked { get; set; }
            }
            public class JournalService
            {
                public List<JournalCut> GetChaptersList()
                {
                    return new List<JournalCut>()
                 
                {
                new JournalCut()
                {BookName = "Ecological Role of Micro-Organism on Surface Deterioration of Cross River basalt Monoliths in Nigeria.", BookImage = "WA0025.jpg", BookDescription = "Biological growth on the surface of basalt rock monoliths by a wide variety of microorganisms including bacteria, (fungi and algae), lichens, mosses and liverworts were studied. " +
                "Microscopic identification, quantification and an ecological classification of the micro-organisms on two different sites were made to aid the study of their implication in crack and pitting observed on monoliths surface. " +
                "The result of this study reveal significant differences and some similarities in growth between the chosen sites and the existence of some of the micro-organisms family species in Japan. " +
                "A complex biotic chemical weathering on the surface of the monoliths was distinguished. " +
                "Over 450 of the cylindrical monoliths are affected. The communities in this region regard the monolith to represent their ancestors. " +
                "The monoliths are monuments protected as important cultural property of national interest.", Authors = "Abu S. Edet, Hidenori Takahashi, Taro Seki", Year = "Published 2002", ButtonClicked="http://jlc.jst.go.jp/DN/JALC/00065493151?from=Google"},
                new JournalCut ()
                {BookName = "The Role of Museum in Curbing Corruption in Nigeria.", BookImage = "WA0022.jpg", BookDescription = "Corruption is a scandal that has been with human beings from antiquity" +
                " to the present (Tylor, 1871). It pervades and permeates society. Corruption in Nigeria has assumed a enormous proportion and has constituted a serious national problem. Government put " +
                "in place some machinery to fight corruption but to no avail. This paper looks at cultural education and the teaching of the history of peoples as a weapon of overriding strategic importance. " +
                "The role of museum as the promoter of cultural education for combating corruption was studied.Evidence from various researchers such as Okolo (2008), Muthoga(1994), Musheshe(1994) and " +
                "Cockfort (1994) on the subject of corruption indicate that corruption is embedded in every society.This study examined the nature and types of programmes the museum undertakes and those that " +
                "would be suitable and more effective in educating the different members of the public against corrupt practices.The study looks at museum tools such as mass media campaign, mobile public awareness, " +
                "youth education, children enlightenment, anti-corruption workshops and seminar series, advocacy and effective use of cultural resources in public lectures, and exhibitions. Finally it recommends " +
                "the use of cultural education as effective tool for combating corruption and evolving new orientation for society. ", Authors = "Abu S. Edet", Year = "Published 2014", ButtonClicked="https://www.researchgate.net/publication/337419452_The_Role_of_Museum_in_Curbing_Corruption_in_Nigeria-_15-Nov-2019_12-18-14"},
                 new JournalCut ()
                {
                     BookName = "The Impact of the Biafra-Nigeria war on the Calabar people, their cultural practices, historic monuments and sites.", BookImage = "WA0024.jpg", BookDescription = "The Nigerian Civil War (1967-1970) brought local" +
                     " tension that had long existed in Calabar into the open. Because the city and its environs were hotly contested during the war, it was not clear which side" +
                     " would actually emerge as dominant...", Authors= "Abu S. Edet", Year ="2019", ButtonClicked="https://www.researchgate.net/publication/337416033_The_Impact_of_The_Nigerian_Civil_War_on_Calabar-_18-Nov-2019_17-04-561"},

                    new JournalCut()
                    {
                        BookName = "Environmental Factors Affecting Monoliths and Sites in the Cross River Region.", BookImage = "WA0020.jpg", BookDescription = "Monolith sites under this study cover an area of" +
                        " about, 70 sq. km. About 95% of total area is affected by thermal weathering due to changing climate and human-induced fires. The 34 known sites have been documented and published (Allison 1968). " +
                        "Many scholarly studies have been conducted on the provenance of the monoliths. Recent conservation studies were conducted on the deterioration of two prominent sites at Alok and Old Nkrigom (Edet 1997). " +
                        "The monoliths are significant cultural rock monuments, rarely found in Africa. Pitiably, the sites are under severe environmental stress, including human activity, such as farming, hunting and forest exploitation. " +
                        "These have resulted in severe fire degradation of the vegetation of which the monoliths and sites are an integral part. This study examines the climatic characteristics of monolith sites in the middle " +
                        "Cross River region of Nigeria where climatic extremity has gradually induced savanna grassland conditions that have produced a high thermal-prone " +
                        "environment...", Authors = "Abu S. Edet", Year = "2003", ButtonClicked="https://www.researchgate.net/publication/337398784_Environmental_Factors_Affecting_Cultural_Monoliths_And_Sites_in_The_Cross_River_Region_of_Nigeria-_18-Nov-2019_16-21-071" },

                new JournalCut()
                {
                        BookName = "Museum Archaeologist: Concept, Role and Responsibility in Museum Development System.", BookImage = "WA0020.jpg", BookDescription = "Coming soon", Authors = "Abu S. Edet", Year = "2014", ButtonClicked="" },


            new JournalCut()
            {
                BookName = "Cultural Resources Management for Poverty Reduction in Africa.", BookImage = "WA0020.jpg", BookDescription = "Economy and cultural imperatives are recognized as the most powerful forces shaping human " +
                "development. Africa have diverse and rich heritage consisting of natural and cultural resources of universal importance. This paper discusses the practical challenges of empowering people to harness the economic " +
                "potentials of their cultural resources for their material benefits. It suggest that Africa's economic transformation can be promoted through effective management and marketing of her cultural resources, " +
                "and that African governments, stakeholders and private sector must work in partnership to yield the desired results...", Authors = "Abu S. Edet", Year = "2019", ButtonClicked="https://www.researchgate.net/publication/337344463_Cultural_Resources_Management_as_a_tool_for_Poverty_Reduction_in_Africa_15-Nov-2019_11-51-06"}

                 };
                }

            }
        }
        
        private async void Button_Clicked(object sender, EventArgs e)
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
 