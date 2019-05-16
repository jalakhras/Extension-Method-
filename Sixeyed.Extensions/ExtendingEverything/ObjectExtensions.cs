using Newtonsoft.Json;

namespace Sixeyed.Extensions.ExtendingEverything
{
    public static class ObjectExtensions
    {
        public static string ToJsonString(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
