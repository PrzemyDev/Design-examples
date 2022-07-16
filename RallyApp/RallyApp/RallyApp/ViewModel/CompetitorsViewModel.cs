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
                Name = "Andrzej",
                Surname = "Szyk",
                Nationality = "https://www.ewrc-results.com/images/flags2/poland.png",
                Image = "https://www.ewrc-results.com/photos/unknow.jpg"
            });
            Competitors.Add(new Competitor
            {
                Name = "Harri",
                Surname = "Rovenparä",
                Nationality = "https://www.ewrc-results.com/images/flags2/finland.png",
                Image = "https://www.ewrc-results.com/photos/rovanpera.jpg"
            });
            Competitors.Add(new Competitor
            {
                Name = "Kimi",
                Surname = "Perkele",
                Nationality = "https://www.ewrc-results.com/images/flags2/finland.png",
                Image = "https://www.ewrc-results.com/photos/unknow.jpg"
            });
            Competitors.Add(new Competitor
            {
                Name = "Thierry",
                Surname = "Neuville",
                Nationality = "https://www.ewrc-results.com/images/flags2/belgium.png",
                Image = "https://www.ewrc-results.com/photos/neuville_thierry.jpg"
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
