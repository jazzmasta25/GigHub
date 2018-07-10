using GigHub.Models;
using System;
using System.Collections.Generic;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime DateTime //Information master, has the info so it should be the one who calculates values.
        {
            get { return DateTime.Parse(string.Format("{0} {1}", Date, Time)); }
        }
    }
}