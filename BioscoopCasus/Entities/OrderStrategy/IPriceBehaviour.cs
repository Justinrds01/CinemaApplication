using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopCasus.Entities.OrderStrategy
{
    public interface IPriceBehaviour
    {
        public decimal CalculatePrice(List<MovieTicket> MovieTickets);
    }
}
