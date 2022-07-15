using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RallyApp.ViewModel
{
    internal class StandingsOf2022
    {
        public ObservableCollection<Standing> Standings { get; set; }

        public StandingsOf2022()
        {
            Standings = new ObservableCollection<Standing>();
            Standings.Add(new Standing
            {
                Position = "1",
                Driver = "K. Rozdecky",
                Team = "Toyota",
                Points = "145"
            });
            Standings.Add(new Standing
            {
                Position = "2",
                Driver = "Z. Bran",
                Team = "Hyundai",
                Points = "80"
            });
            Standings.Add(new Standing
            {
                Position = "3",
                Driver = "T. Oldville",
                Team = "Toyota",
                Points = "62"
            });
            Standings.Add(new Standing
            {
                Position = "4",
                Driver = "T.Keisuke",
                Team = "Ford",
                Points = "60"
            });
            Standings.Add(new Standing
            {
                Position = "5",
                Driver = "E.Martins",
                Team = "Toyota",
                Points = "57"
            });
            Standings.Add(new Standing
            {
                Position = "6",
                Driver = "S. Leob",
                Team = "Ford",
                Points = "35"
            });
            Standings.Add(new Standing
            {
                Position = "7",
                Driver = "S. Ogar",
                Team = "Toyota",
                Points = "34"
            });
            Standings.Add(new Standing
            {
                Position = "8",
                Driver = "D. Sirbo",
                Team = "Hyundai",
                Points = "34"
            });
            Standings.Add(new Standing
            {
                Position = "9",
                Driver = "Z. Bluesmith",
                Team = "Citroen",
                Points = "28"
            });
            Standings.Add(new Standing
            {
                Position = "10",
                Driver = "K. Kajetanowitz",
                Team = "Skoda",
                Points = "6"
            });
            Standings.Add(new Standing
            {
                Position = "11",
                Driver = "W. Wolny",
                Team = "Skoda",
                Points = "4"
            });
        }
       
        }

    }

    public class Standing
{
    public string Position { get; set; }
    public string Driver { get; set; }
    public string Team { get; set; }
    public string Points { get; set; }
}
    

