
namespace Blazor3D.Materials
{
    /// <summary>
    /// <para>A standard physically based Material, using Metallic-Roughness workflow.</para>
    /// <para>This class inherits from <see cref="Material"/></para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/materials/MeshStandardMaterial">MeshStandardMaterial</a></para>
    /// </summary>
    /// <inheritdoc><see cref="MeshStandardMaterial"/></inheritdoc>
    public sealed class MeshStandardMaterial : Material
    {
        
        public MeshStandardMaterial() : base("MeshStandardMaterial")
        {

        }

        /// <summary>
        /// <para>Light color. 
        /// You can use <a target="_blank" href="https://developer.mozilla.org/en-US/docs/Web/CSS/color_value">web color values</a> to set up required color.
        /// Default value is "orange"</para>
        /// </summary>
        public string Color { get; set; } = "orange";
    }
}
