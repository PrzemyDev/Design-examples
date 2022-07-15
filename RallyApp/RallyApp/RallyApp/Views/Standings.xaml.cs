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
    public partial class Standings : ContentPage
    {
        public Standings()
        {
            InitializeComponent();
            this.BindingContext = new StandingsViewModel();
        }

        async private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             var details = e.CurrentSelection.FirstOrDefault() as Season;
             await Navigation.PushAsync(new StandingsDetails(details.SeasonNumber));
            
        }
    }
}