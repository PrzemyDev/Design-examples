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
    public partial class CompetitorDetails : ContentPage
    {
        public CompetitorDetails(string Name, string Surname, string imageNationality, string imageSource)
        {
            InitializeComponent();

            SelectedCompetitor.Text = Name + " " + Surname;

            NameCall.Text = Name + " " + Surname;
            NationalityCall.Source = new UriImageSource() { Uri = new Uri(imageNationality) };
            ImageCall.Source = new UriImageSource() { Uri = new Uri(imageSource)};

        }
    }
}