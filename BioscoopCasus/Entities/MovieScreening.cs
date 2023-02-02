using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopCasus.Entities
{
    public class MovieScreening
    {
        [JsonProperty]
        private DateTime DateAndTime;
        [JsonProperty]
        private double PricePerSeat { get; }

        public MovieScreening(DateTime dateAndTime, double pricePerSeat)
        {
            DateAndTime = dateAndTime;
            PricePerSeat = pricePerSeat;
        }
        
        public double GetPricePerSeat()
        {
            return PricePerSeat;
        }

        public DateTime GetDateTime()
        {
            return DateAndTime;
        }

        public override string ToString()
        {
            return string.Format("Date and time: {0}\nPrice per seat: {1}", DateAndTime, PricePerSeat);
        }
    }
}
