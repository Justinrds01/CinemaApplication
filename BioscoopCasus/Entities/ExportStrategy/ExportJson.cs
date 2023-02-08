using Newtonsoft.Json;

namespace BioscoopCasus.Entities.ExportStrategy
{
    public class ExportJson : IExportBehaviour
    {
        public async Task Export(Order order)
        {
            string json = JsonConvert.SerializeObject(this);
            using (StreamWriter writer = new StreamWriter("../../../Files/JsonFile.json")) await writer.WriteAsync(json);
        }
    }
}
