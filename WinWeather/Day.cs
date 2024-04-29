using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinWeather
{
    public class Day
    {
        public IncrementTracker incrementTracker;
        private DateTime date;  
        public string uiDateString;
        public string city;
        public int dayIncrement;
       
        public bool IsToday()
        {
            return date == DateTime.Today;
        }

        public Day(IncrementTracker incrementTracker, string city)
        {
            this.incrementTracker = incrementTracker;
            dayIncrement = incrementTracker.GetCurrentDayIncrement();
            date = DateTime.Today.AddDays(dayIncrement);
            uiDateString = date.ToString("dd MMMM yyyy");
            this.city = city;
        }

    }
}
