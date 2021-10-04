﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Museum_Practitioner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Publication : ContentPage
    {
        public Publication()
        {
            InitializeComponent();
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
                "The monoliths are monuments protected as important cultural property of national interest.", Authors = "Abu S. Edet, Hidenori Takahashi, Taro Seki", Year = "Published 2002"},
                new JournalCut ()
                {BookName = "The Role of Museum in Curbing Corruption in Nigeria.", BookImage = "WA0022.jpg", BookDescription = "Corruption is a scandal that has been with human beings from antiquity" +
                " to the present (Tylor, 1871). It pervades and permeates society. Corruption in Nigeria has assumed a enormous proportion and has constituted a serious national problem. Government put " +
                "in place some machinery to fight corruption but to no avail. This paper looks at cultural education and the teaching of the history of peoples as a weapon of overriding strategic importance. " +
                "The role of museum as the promoter of cultural education for combating corruption was studied.Evidence from various researchers such as Okolo (2008), Muthoga(1994), Musheshe(1994) and " +
                "Cockfort (1994) on the subject of corruption indicate that corruption is embedded in every society.This study examined the nature and types of programmes the museum undertakes and those that " +
                "would be suitable and more effective in educating the different members of the public against corrupt practices.The study looks at museum tools such as mass media campaign, mobile public awareness, " +
                "youth education, children enlightenment, anti-corruption workshops and seminar series, advocacy and effective use of cultural resources in public lectures, and exhibitions. Finally it recommends " +
                "the use of cultural education as effective tool for combating corruption and evolving new orientation for society. ", Authors = "Abu S. Edet", Year = "Published 2014"},
                 new JournalCut ()
                {BookName = "The Impact of the Biafra-Nigeria war on the Calabar people, their cultural practices, historic monuments and sites.", BookImage = "WA0024.jpg", BookDescription = "e", Authors= "Abu S. Edet"},
                 };
                }
            }
        }
    }
}