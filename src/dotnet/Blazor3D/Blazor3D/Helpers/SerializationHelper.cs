using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Blazor3D.Helpers
{
    internal static class SerializationHelper
    {
        internal static JsonSerializerSettings GetSerializerSettings()
        {
            return new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };
        }
    }
}
