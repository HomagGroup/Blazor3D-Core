namespace HomagGroup.Blazor3D.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddBlazor3DFileTypes(this IServiceCollection services)
    {
        var provider = new FileExtensionContentTypeProvider();

        provider.Mappings.Add(".fbx", "application/octet-stream");
        provider.Mappings.Add(".gltf", "model/gltf+json");
        provider.Mappings.Add(".glb", "model/gltf-binary");
        provider.Mappings.Add(".dae", "model/vnd.collada+xml");
        provider.Mappings.Add(".stl", "model/stl");

        services.Configure<StaticFileOptions>(s => s.ContentTypeProvider = provider);

        return services;
    }
}