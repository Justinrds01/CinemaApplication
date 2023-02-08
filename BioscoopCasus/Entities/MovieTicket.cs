using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopCasus.Entities
{
    public class MovieTicket
    {
        [JsonProperty]
        private int RowNr;
        [JsonProperty]
        private int SeatNr;
        [JsonProperty]
        private bool IsPremium;
        [JsonProperty]
        private MovieScreening MovieScreening;
        public MovieTicket(int rowNr, int seatNr, bool isPremium, MovieScreening movieScreening)
        {
            RowNr = rowNr;
            SeatNr = seatNr;
            IsPremium = isPremium;
            MovieScreening = movieScreening;
        }

        public bool IsPremiumTicket()
        {
            return IsPremium;
        }

        public decimal GetPrice()
        {
            return MovieScreening.GetPricePerSeat();
        }

        public DateTime GetDateAndtime()
        {
            return MovieScreening.GetDateTime();
        }

        public override string ToString()
        {
            return string.Format("Row, Seat\n {0}, {1}\n Premium: {2}", RowNr, SeatNr, IsPremium);
        }

    }
}
