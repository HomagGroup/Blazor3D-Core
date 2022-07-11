
namespace Blazor3D.Materials
{
    /// <summary>
    /// <p>A standard physically based Material, using Metallic-Roughness workflow.</p>
    /// <p>This class inherits from <see cref="Material"/></p>
    /// <p>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/materials/MeshStandardMaterial">MeshStandardMaterial</a></p>
    /// </summary>
    /// <inheritdoc><see cref="MeshStandardMaterial"/></inheritdoc>
    public sealed class MeshStandardMaterial : Material
    {
        
        public MeshStandardMaterial() : base("MeshStandardMaterial")
        {

        }

        /// <summary>
        /// <p>Light color. 
        /// You can use <a target="_blank" href="https://developer.mozilla.org/en-US/docs/Web/CSS/color_value">web color values</a> to set up required color.
        /// Default value is "grey"</p>
        /// </summary>
        public string Color { get; set; } = "grey";
    }
}
