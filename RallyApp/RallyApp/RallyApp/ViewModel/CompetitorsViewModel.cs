using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RallyApp.ViewModel
{
    public class CompetitorsViewModel
    {
        public ObservableCollection<Competitor> Competitors { get; set; }
        public CompetitorsViewModel()
        {
            Competitors = new ObservableCollection<Competitor>();
            Competitors.Add(new Competitor
            {
                Name = "Robert", Surname = "Kubica", Nationality = "https://www.ewrc-results.com/images/flags2/poland.png",
                Image= "https://www.ewrc-results.com/photos/kubica.jpg"
            });
            Competitors.Add(new Competitor
            {
                Name = "Robert",
                Surname = "K.",
                Nationality = "https://www.ewrc-results.com/images/flags2/poland.png",
                Image = "https://www.ewrc-results.com/photos/kubica.jpg"
            });
        }        

    }

    public class Competitor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nationality { get; set; }
        public string Image { get; set; }
    }
}
