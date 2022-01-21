using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Museum_Practitioner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookShop : ContentPage
    {
        public BookShop()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            NewBooks.ItemsSource = new NewBooksP.NewBooksService().GetNewBooksList();
        }
        public class NewBooksP
        {
            public class NewBooksPic
            {
                public string Name { get; set; }
                public string Description { get; set; }
                public string Image { get; set; }
            }
            public class NewBooksService
            {
                public List<NewBooksPic> GetNewBooksList()
                {
                    return new List<NewBooksPic>()
                {
                new NewBooksPic()
                {
                    Name = "A book on Field Archaeology",
                    Image = "WA0028.jpg",
                    Description = "Salvaging the remains of a dying Heritage"
                },

                 new NewBooksPic ()
                {
                    Name = "The Museum practitioner",
                    Image = "MP.png",
                    Description = "Our new religion: museum practice"
                },
                 new NewBooksPic ()
                {
                    Name = "Cross River Monolith",
                    Image = "DICOVENT.jpg",
                    Description = "The Cross River Monolith"
                },

                  new NewBooksPic ()
                {
                    Name = "How to conserve and exhibit historical collections",
                    Image = "exhibition.png",
                    Description = "the art of designing and developing a gallery"
                },
                  new NewBooksPic ()
                {
                    Name = "Place holder for title",
                    Image = "Publications.png",
                    Description = "place holder for description"
                },
                   new NewBooksPic ()
                {
                    Name = "Place holder for title",
                    Image = "Publications.png",
                    Description = "Place holder for description"
                },
                    new NewBooksPic ()
                {
                    Name = "Place holder for title",
                    Image = "Publications.png",
                    Description = "Place holder for description"
                }

             };
                }
            }

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Buy book", "Coming soon", "ok");
        }
    }
}