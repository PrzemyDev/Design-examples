using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RallyApp.ViewModel
{
    public class ResultsViewModel
    {
        public ObservableCollection<Result> Results { get; set; }
        public ResultsViewModel()
        {
            Results = new ObservableCollection<Result>();
            Results.Add(new Result
            {
                Position = "1",
                Number = "11",
                CarClass = "R4",
                Start = "19:55:03",
                Time = "1:21:23",
                DiffToFirst = "0:00:00"
            });
            Results.Add(new Result
            {
                Position = "2",
                Number = "5",
                CarClass = "R4",
                Start = "20:00:02",
                Time = "1:22:43",
                DiffToFirst = "+0:01:20"
            });
            Results.Add(new Result
            {
                Position = "3",
                Number = "4",
                CarClass = "R4",
                Start = "20:04:12",
                Time = "1:23:56",
                DiffToFirst = "+0:02:33"
            });
            Results.Add(new Result
            {
                Position = "...",
                Number = "8",
                CarClass = "R4",
                Start = "20:09:02",
                Time = "...",
                DiffToFirst = "..."
            });
            Results.Add(new Result
            {
                Position = "...",
                Number = "10",
                CarClass = "R4",
                Start = "...",
                Time = "...",
                DiffToFirst = "..."
            });

        }

    }

    public class Result
    {
        public string Position { get; set; }
        public string Number { get; set; }
        public string CarClass { get; set; }
        public string Start { get; set; }
        public string Time { get; set; }
        public string DiffToFirst { get; set; }

    }
}
