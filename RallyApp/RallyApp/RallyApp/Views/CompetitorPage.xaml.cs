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
        CompetitorsViewModel competitorsViewModel = new CompetitorsViewModel();
        public CompetitorPage()
        {
            InitializeComponent();
            BindingContext = new CompetitorsViewModel();
            List<string> nats = new List<string>();
            nats.Add("Polska");
            nats.Add("Finlandia");
            nats.Add("Belgia");
            NationalityPicker.ItemsSource = nats;
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

           var details = e.Item as Competitor;
           await Navigation.PushAsync(new CompetitorDetails(details.Name, details.Surname, details.Nationality, details.Image));

        }
        
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*Left comments below for learning purposes.
            var tempCompList = competitorsViewModel.Competitors;
            CompetitorsList.ItemsSource = tempCompList.Where(x => x.Name.StartsWith(e.NewTextValue) || x.Surname.StartsWith(e.NewTextValue));*/
            var tempCompList = competitorsViewModel.Competitors;
            if (NationalityPicker.SelectedIndex == -1 || NationalityPicker.SelectedItem.ToString() == "")
            {
                //CompetitorsList.ItemsSource = tempCompList.Where(x => x.Name.Contains(e.NewTextValue) || x.Surname.Contains(e.NewTextValue));
                CompetitorsList.ItemsSource = tempCompList.Where(x => x.Name.ToLower().Contains(e.NewTextValue.ToLower()) || x.Surname.ToLower().Contains(e.NewTextValue.ToLower()));
            }
            else
            {
                string flagTest = NationalityPicker.SelectedItem.ToString();
                string result = string.Empty;
                TemporaryVoid(ref flagTest, ref result);
                var tempList = tempCompList.Where(x => x.Nationality.Contains(result));
                //CompetitorsList.ItemsSource = tempCompList.Where(x => x.Name.StartsWith(e.NewTextValue) || x.Surname.StartsWith(e.NewTextValue));
                CompetitorsList.ItemsSource = tempList.Where(x => x.Name.ToLower().Contains(e.NewTextValue.ToLower()) || x.Surname.ToLower().Contains(e.NewTextValue.ToLower()));
            }
        }

        private void NationalityPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string flagTest = e;
            string flagTest = NationalityPicker.SelectedItem.ToString();
            string result = string.Empty;
            TemporaryVoid(ref flagTest, ref result);
            var tempCompList = competitorsViewModel.Competitors;
            //CompetitorsList.ItemsSource = tempCompList.Where(x => x.Nationality.Equals(flagTest));
            CompetitorsList.ItemsSource = tempCompList.Where(x => x.Nationality.Contains(result));
        }

        private void TemporaryVoid(ref string flagtest, ref string result)
        {
            //it will be better to add another property to competitor but let's just pretend it is in specification for now
            
            switch (flagtest)
            {
                case "Polska":
                    result = "https://www.ewrc-results.com/images/flags2/poland.png";
                    break;
                case "Finlandia":
                    result = "https://www.ewrc-results.com/images/flags2/finland.png";
                    break;
                case "Belgia":
                    result = "https://www.ewrc-results.com/images/flags2/belgium.png";
                    break;
                default:
                    result = "";
                    break;
            }
        }
        private void BtnClearPicker_Clicked(object sender, EventArgs e)
        {
            //NationalityPicker.SelectedIndex = -1;
            SearchBarCompetitor.Text = "";
            NationalityPicker.SelectedItem = "";

        }
    }
}