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
    public partial class Online_Publications : ContentPage
    {
        public Online_Publications()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Opubs.ItemsSource = new OPublications.OPublicationService().GetOPublicationList();
        }

        public class OPublications
        {
            public class OPublicationCut
            {
                public string BookName { get; set; }
                public string BookDescription { get; set; }
                public string BookImage { get; set; }
                public string Authors { get; set; }
                public string Year { get; set; }
                public string ButtonClicked { get; set; }
            }
            public class OPublicationService
            {
                public List<OPublicationCut> GetOPublicationList()
                {
                    return new List<OPublicationCut>()
                {
                new OPublicationCut()
                {BookName = "Cross River Monoliths: in critical danger of total destruction.", BookImage = "cmll.PNG", BookDescription = "Problem: Cross River State, Nigeria is home to some 450 ancient " +
                "carved monoliths, widely known as Akwanshi, which are exclusive to this region. Although adequate carbon dating has not been conducted, current estimates of their age range from 1,500-500 " +
                "years before present. In spite of several important studies — Partridge (1905), Allison (1968), Nicklin (1975), Eyo (1986), Edet (2000, 2003) — the monoliths are yet to be systematically " +
                "documented. In Éjághám, Ákúâøshì means ‘ancestors in the ground’; ákú ‘ancestors’; kâ ‘in’; øshì ‘ground’ (cf. Allison 1968a: 22).1 Because the monoliths may be sitting on burial sites " +
                "that have not been archeologically excavated, they must not been removed; instead they should be preserved in situ until the overall goal of conducting archeology is possible. Some communities, " +
                "like Nkarasi (Ikom L.G.A.), have removed monoliths from their original sites and placed them near the highway as tourist attractions, thus destroying their archeological context. In addition, " +
                "several monoliths have been reported in western collections; these also appear to have been illegally removed from their sites.  Our recent two-day expedition discovered that the remaining " +
                "stones are in critical danger of total destruction, either by fire damage caused by local communities or theft. If this process continues, we risk losing a unique part of our World Heritage " +
                "before we can understand it. The National Commission for Museums and Monuments of Nigeria, which is responsible for their preservation, has not been able to cope with this crisis. Therefore " +
                "we appeal to the international community for assistance for better documentation, preservation and conservation of the sites..", Authors = "Ivor Miller & Abu S. Edet", Year = "Published 2019", ButtonClicked="https://www.researchgate.net/publication/333448462_Cross_River_Monoliths_in_critical_danger_of_total_destruction"},
                
                new OPublicationCut ()
                {BookName = "Cross River monoliths: destruction, theft and international sales", BookImage = "mnl.PNG", BookDescription = "Problem: After Allison’s pioneering documentation of the carved " +
                "monoliths of the middle Cross River region of Nigeria in the 1960s, selected monolith sites were declared as National Monuments under the Nigerian Department of Antiquities. Since then, there " +
                "has never been a comprehensive survey conducted to establish the locations, numbers and conditions of the monoliths. Our recent expeditions to inspect the monolith sites has revealed general " +
                "destruction through fire, intentional destruction, and theft. In the triad of photographs above, we compare the whole monolith taken by Allison (1968), with its two present-day fragments: the " +
                "upper section from the collection of the Metropolitan Museum of Art (New York City), with the lower section, destroyed by fire, in its natural site in Nigeria, as we documented it in Janaury, " +
                "2015. Our inspection of the monoliths sites reveals a triple threat to these yet-to-be-recognized World Heritage Sites: destruction of the stones by repeated fire, the use of the stones to crack " +
                "palm kernel nuts, and the theft of their top sections for sale on the international art market.  ", Authors = "Ivor Miller & Abu S. Edet", Year = "Published July 2015", ButtonClicked="https://www.researchgate.net/publication/333449068_Cross_River_monoliths_destruction_theft_and_international_sales" },
  new OPublicationCut()
                {BookName = "Cross River monoliths: community efforts to salvage their heritage", BookImage = "cme.PNG", BookDescription = "Problem: In contemporary Nigeria, local communities are faced with theend " +
                "of their heritage, whether linguistic, artistic, spiritual and communal,due to two major factors: the invasion of foreign monotheistic religionsand incompetent governance at both state and federal " +
                "levels. Our recenttrip to the historic areas of the Cross River monoliths found severalexamples of both the devastation of heritage, and the critical communityresponse to take local action in defense " +
                "of their heritage.", Authors = "Ivor Miller & Abu S. Edet", Year = "Published 2015", ButtonClicked="https://www.academia.edu/39299698/Cross_River_monoliths_community_efforts_to_salvage_their_heritage"},

                        new OPublicationCut()
                    { BookName = "Etara Mgbe Burial: age-old Legacies attacked by Churches", BookImage = "etara.jpg", BookDescription = "Problem: The Cross River region was historically a zone of thick " +
                    "forests and deep rivers that was honeycombed with remarkably diverse sculptural forms, body-masks and judicial institutions that awed locals and visitors alike. With colonialism and" +
                    " Christianity, these practices lost authority and appeal to many locals, but they nevertheless survived into the 21st century. But contemporary Cross River communities are witnessing" +
                    " the apex of an identity crisis wherein local languages, traditional institutions, and the interdependent relationship between the human cultures and the natural environment in which " +
                    "they evolved are fast approaching extinction. Reports from the Éjághám heartland are that Nigerian Pentecostal pastors incite local youths to accuse elder traditionalists of ‘witchcraft,’ " +
                    "and to attack any antiquities associated with tradition. In several cases, Ékpè (Úgbè) halls have been burnt to the ground, with all their irreplaceable ritual objects. Because inherited " +
                    "traditions are devalued, and the artisanal apprenticeship system has collapsed, very few artisans remain who can sculpt wood, forge iron, make cloths, masks, and so on. This — " +
                    "in conjunction with the loss of both primary and secondary forests — are culminating in the end of heritage in the entire region. Our recent three-day expedition confirmed that the " +
                    "inherited traditions and artistic heritage of many villages in the former high forest areas are under direct attack by Nigerian churches. We also found that many citizens are unaware " +
                    "that Nigeria has strict laws against the destruction of antiquities. The Federal acts that established the National Commission for Museums and Monuments of Nigeria also spell out Decrees " +
                    "77 & 79, which later became Antiquity Laws against the buying, selling or the destruction of cultural properties. It is imperative that local traditionalists are informed about these laws, " +
                    "in order to defend themselves and their heritage against hateful attacks.",Authors="Ivor Miller & Abu S. Edet", Year="Published May 2015", ButtonClicked="https://www.researchgate.net/publication/333448773_Etara_Mgbe_Burial_age-old_legacies_attacked_by_churches_Text_and_photographs_2015_by"}
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