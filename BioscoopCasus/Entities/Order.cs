using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BioscoopCasus.Entities
{
    public class Order
    {
        [JsonProperty]
        private int OrderNr { get; }
        [JsonProperty]
        private readonly bool IsStudentOrder;
        [JsonProperty]
        private readonly List<MovieTicket> MovieTickets;

        public Order(int orderNr, bool isStudentOrder) {
            OrderNr = orderNr;
            IsStudentOrder = isStudentOrder;
            MovieTickets = new();
        }

        public void AddSeatReservation(MovieTicket ticket)
        {
            MovieTickets.Add(ticket);
        }

        public decimal CalculatePrice()
        {
            decimal sum = 0;
            bool isEven = false;
            bool isWeekDay = false;
            
            foreach (MovieTicket movieTicket in MovieTickets) {
                decimal price = movieTicket.GetPrice();
                isWeekDay = IsWeekDay(movieTicket.GetDateAndtime());
                if (isEven && (IsStudentOrder || !isWeekDay)) price = 0;
                else if (movieTicket.IsPremiumTicket()) price += IsStudentOrder ? 2 : 3;
                sum += price;
                isEven = !isEven;
            }
            if (!IsStudentOrder && MovieTickets.Count >= 6 && !isWeekDay) {
                sum *= 0.9m;
            }
            return sum;
        }

        private static bool IsWeekDay(DateTime dateAndTime) 
        {
            return dateAndTime.DayOfWeek != DayOfWeek.Friday && dateAndTime.DayOfWeek != DayOfWeek.Saturday && dateAndTime.DayOfWeek != DayOfWeek.Sunday;
        }

        public async Task Export(TicketExportFormat exportFormat)
        {
            StreamWriter writer;
            switch (exportFormat)
            {
                case TicketExportFormat.PLAINTEXT:
                    StringBuilder stringBuilder = new();
                    stringBuilder.AppendLine("Order number: " + OrderNr);
                    MovieTickets.ForEach(x => stringBuilder.AppendLine(x.ToString()));
                    stringBuilder.AppendLine("---------------");
                    stringBuilder.AppendLine("Total Cost: " + CalculatePrice());
                    writer = new("../../../Files/PlainText.txt");
                    using (writer) await writer.WriteAsync(stringBuilder.ToString());
                    break;
                case TicketExportFormat.JSON:
                    string json = JsonConvert.SerializeObject(this);
                    using (writer = new StreamWriter("../../../Files/JsonFile.json")) await writer.WriteAsync(json);
                    break;
            }
        }

        public int GetOrderNr()
        {
            return OrderNr;
        }
    }
}