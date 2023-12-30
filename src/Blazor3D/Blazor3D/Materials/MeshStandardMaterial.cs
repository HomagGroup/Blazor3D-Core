using HomagGroup.Blazor3D.Textures;

namespace HomagGroup.Blazor3D.Materials;

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
    /// <para>Define whether the material is rendered with flat shading. Default is false.</para>
    /// </summary>
    public bool FlatShading { get; set; } = false;

    /// <summary>
    /// <para>How much the material is like a metal. Non-metallic materials such as wood or stone use 0.0, metallic use 1.0, with nothing (usually) in between. Default is 0.0. A value between 0.0 and 1.0 could be used for a rusty metal look. If metalnessMap is also provided, both values are multiplied.</para>
    /// </summary>
    public double Metalness { get; set; } = 0;

    /// <summary>
    /// <para>How rough the material appears. 0.0 means a smooth mirror reflection, 1.0 means fully diffuse. Default is 1.0. If roughnessMap is also provided, both values are multiplied.</para>
    /// </summary>
    public double Roughness { get; set; } = 1;

    /// <summary>
    /// <para>Render geometry as wireframe. Default is false (i.e. render as flat polygons).</para>
    /// </summary>
    public bool Wireframe { get; set; } = false;

    /// <summary>
    /// The color map. May optionally include an alpha channel, typically combined with Transparent (todo) or AlphaTest(todo). Default is null. The texture map color is modulated by the diffuse Color.
    /// </summary>
    public Texture Map { get; set; } = new Texture();
}