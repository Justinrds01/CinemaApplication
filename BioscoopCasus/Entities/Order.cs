using BioscoopCasus.Entities.ExportStrategy;
using BioscoopCasus.Entities.OrderStrategy;
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
        public int OrderNr { get; private set; }
        [JsonProperty]
        public List<MovieTicket> MovieTickets { get; private set; }
        private readonly IPriceBehaviour _priceBehaviour;
        private readonly IExportBehaviour _exportBehaviourJson;
        private readonly IExportBehaviour _exportBehaviourPlainText;

        public Order(int orderNr, IPriceBehaviour priceBehaviour) {
            OrderNr = orderNr;
            MovieTickets = new();
            _priceBehaviour = priceBehaviour;
            _exportBehaviourJson = new ExportJson();
            _exportBehaviourPlainText = new ExportPlainText();
        }

        public void AddSeatReservation(MovieTicket ticket)
        {
            MovieTickets.Add(ticket);
        }

        public decimal CalculatePrice()
        {
            return _priceBehaviour.CalculatePrice(MovieTickets);
        }

        public void Export(TicketExportFormat exportFormat)
        {
            switch (exportFormat)
            {
                case TicketExportFormat.PLAINTEXT:
                    _exportBehaviourPlainText.Export(this);
                    break;
                case TicketExportFormat.JSON:
                    _exportBehaviourJson.Export(this);
                    break;
            }
        }

        public int GetOrderNr()
        {
            return OrderNr;
        }
    }
}