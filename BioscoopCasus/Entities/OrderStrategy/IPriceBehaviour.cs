using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopCasus.Entities.OrderStrategy
{
    public abstract class IPriceBehaviour
    {
        public abstract decimal CalculatePrice(List<MovieTicket> MovieTickets);

        public bool IsWeekDay(DateTime dateAndTime)
        {
            return dateAndTime.DayOfWeek != DayOfWeek.Friday && dateAndTime.DayOfWeek != DayOfWeek.Saturday && dateAndTime.DayOfWeek != DayOfWeek.Sunday;
        }
    }
}
