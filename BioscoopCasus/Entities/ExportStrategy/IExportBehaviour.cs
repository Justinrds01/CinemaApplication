using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopCasus.Entities.ExportStrategy
{
    public interface IExportBehaviour
    {
        public Task Export(Order order);
    }
}
