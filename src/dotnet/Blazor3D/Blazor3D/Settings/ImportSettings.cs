
using HomagGroup.Blazor3D.Enums;
using HomagGroup.Blazor3D.Materials;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HomagGroup.Blazor3D.Settings
{
    /// <summary>
    /// Settings that will be applied during 3D model file importing.
    /// </summary>
    public class ImportSettings
    {
        /// <summary>
        /// <see cref="Import3DFormats"/> format of 3D model.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))] //todo: may be use serialization helper
        public Import3DFormats Format { get; set; }
        /// <summary>
        /// URL of the 3D model file.
        /// </summary>
        public string FileURL { get; set; } = null!;
        /// <summary>
        /// URL of the texture file
        /// </summary>
        public string? TextureURL { get; set; } = null;
        /// <summary>
        /// UUID of the object to be loaded. Nullable. If not specified, the new Guid is genrated.
        /// </summary>
        public Guid? Uuid { get; set; } = null;
        /// <summary>
        /// <para>Material that will be applied to all loaded meshes.</para>
        /// <para>Currently works only for <see cref="Import3DFormats.Stl"/> STL format.</para>
        /// <para>If not specified, the default <see cref="MeshStandardMaterial"/> is applied to the imported objects.</para>
        /// </summary>
        public MeshStandardMaterial Material { get; set; } = null!;
    }
}
