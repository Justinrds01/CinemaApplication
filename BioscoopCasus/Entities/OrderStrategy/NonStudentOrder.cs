using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopCasus.Entities.OrderStrategy
{
    public class NonStudentOrder : IPriceBehaviour
    {
        public decimal CalculatePrice(List<MovieTicket> MovieTickets)
        {
            decimal sum = 0;

            foreach (MovieTicket movieTicket in MovieTickets)
            {
                decimal price = movieTicket.GetPrice();
                if (movieTicket.IsPremiumTicket()) price += 3;
                sum += price;
            }
            
            if (MovieTickets.Count >= 6 && !IsWeekDay(MovieTickets.First().GetDateAndtime()))
            {
                sum *= 0.9m;
            }
            return sum;
        }
        private static bool IsWeekDay(DateTime dateAndTime)
        {
            return dateAndTime.DayOfWeek != DayOfWeek.Friday && dateAndTime.DayOfWeek != DayOfWeek.Saturday && dateAndTime.DayOfWeek != DayOfWeek.Sunday;
        }
    }
}
