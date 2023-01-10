using Newtonsoft.Json;

namespace InventoryManagement
{
    public class FetchInventoryDetails
    {
        public Details Read(string path)
        {
            using (StreamReader file = new StreamReader(path)) 
            {
                try
                {
                    String Json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Details>(Json);
                }
                catch(Exception e)
                {
                    return null;
                }

            }
        }
    }
}
