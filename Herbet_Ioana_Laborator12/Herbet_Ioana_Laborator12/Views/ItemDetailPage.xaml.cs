using Herbet_Ioana_Laborator12.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Herbet_Ioana_Laborator12.Views
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