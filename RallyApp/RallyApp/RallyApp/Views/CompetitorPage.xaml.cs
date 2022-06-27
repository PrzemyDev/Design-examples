using RallyApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RallyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetitorPage : ContentPage
    {
        public CompetitorPage()
        {
            InitializeComponent();
            BindingContext = new CompetitorsViewModel();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

           var details = e.Item as Competitor;
           await Navigation.PushAsync(new CompetitorDetails(details.Name, details.Surname, details.Nationality, details.Image));

        }


    }
}