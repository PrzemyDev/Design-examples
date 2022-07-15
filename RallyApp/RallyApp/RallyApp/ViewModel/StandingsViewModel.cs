using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RallyApp.ViewModel
{
    public class StandingsViewModel
    {
        public ObservableCollection<Season> Seasons { get; set; }
        public StandingsViewModel()
        {
            Seasons = new ObservableCollection<Season>();

            Seasons.Add(new Season
            {
                SeasonNumber = "2022",
                Image = "https://img.freepik.com/darmowe-wektory/numer-naglowka-kalendarza-2022-na-kolorowe-abstrakcyjne-kolorowe-pociagniecia-pedzlem-szczesliwego-nowego-roku-2022-kolorowe-tlo_87521-3053.jpg?w=2000"
            });
            Seasons.Add(new Season
            {
                SeasonNumber = "2021",
                Image = "https://img.freepik.com/darmowe-wektory/2021-szczesliwego-nowego-roku-zloty-blyszczacy-tekst-banner-projekt_1017-29052.jpg?w=2000"
            });
            Seasons.Add(new Season
            {
                SeasonNumber = "2020",
                Image = "https://media.istockphoto.com/vectors/new-year-2020-hand-lettering-illustration-in-grunge-style-vector-id1146220451"
            });
            Seasons.Add(new Season
            {
                SeasonNumber = "2019",
                Image = "https://images.squarespace-cdn.com/content/v1/57d9e959d482e972e8434364/1577822088074-T14DXQ66KYEXCH4JKHVE/shutterstock_1061056634.jpg?format=1000w"
            });
        }

    }

    public class Season
    {
        public string SeasonNumber { get; set; }
        public string Image { get; set; }
    }
}

