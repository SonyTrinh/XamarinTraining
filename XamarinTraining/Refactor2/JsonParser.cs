using Newtonsoft.Json;
using Refactor2.Service.Interface;

namespace Refactor2
{
    public class JsonParser : IParser
    {
        public T Deserialize<T>(string obj)
        {
            return JsonConvert.DeserializeObject<T>(obj);
        }                                       

        public object Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
