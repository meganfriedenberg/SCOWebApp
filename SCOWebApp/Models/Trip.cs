using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCOWebApp.Models
{
    public class Trip //the model helps abstract and use data
    {
        public int TripId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string WeatherConditions { get; set; }

        public decimal Price { get; set; }

        public string ImageURL { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public bool IsTripOfTheWeek { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string Notes { get; set; }




    }
}
