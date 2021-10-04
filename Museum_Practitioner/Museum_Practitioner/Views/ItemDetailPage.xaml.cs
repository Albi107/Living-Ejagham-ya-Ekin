using Museum_Practitioner.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Museum_Practitioner.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}