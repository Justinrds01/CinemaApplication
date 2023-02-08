using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopCasus.Entities.ExportStrategy
{
    public class ExportPlainText : IExportBehaviour
    {
        public async Task Export(Order order)
        {
            StringBuilder stringBuilder = new();
            stringBuilder.AppendLine("Order number: " + order.OrderNr);
            order.MovieTickets.ForEach(x => stringBuilder.AppendLine(x.ToString()));
            stringBuilder.AppendLine("---------------");
            stringBuilder.AppendLine("Total Cost: " + order.CalculatePrice());
            using StreamWriter writer = new("../../../Files/PlainText.txt"); 
            await writer.WriteAsync(stringBuilder.ToString());
        }
    }
}
