using RallyApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RallyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StandingsDetails : ContentPage
    {
        
        public StandingsDetails(string SeasonNr)
        {
            InitializeComponent();
            SelectedSeason.Text = SeasonNr;
            BindingContext = new StandingsOf2022();
        }
    }

}
