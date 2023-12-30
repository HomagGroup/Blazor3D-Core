using Newtonsoft.Json.Serialization;

namespace HomagGroup.Blazor3D.ComponentHelpers;

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