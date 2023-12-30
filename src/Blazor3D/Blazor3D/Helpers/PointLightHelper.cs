namespace HomagGroup.Blazor3D.Helpers;

/// <summary>
/// <para>This displays a helper object consisting of a spherical <see cref="Mesh"/> for visualizing a <see cref="PointLight"/>.</para>
/// <para>This object inherits from <see cref="Object3D"/></para>
/// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/helpers/PointLightHelper">PointLightHelper</a></para>
/// </summary>
public sealed class PointLightHelper : Object3D
{
    public PointLightHelper() : base("PointLightHelper")
    {
    }

    /// <summary>
    /// Constructor with parameters
    /// </summary>
    /// <param name="light">The light to be visualized. Must be already added to the scene.</param>
    /// <param name="sphereSize">The size of the sphere helper. Default is 1.</param>
    /// <param name="color">The size of the sphere helper. If color is not set, the helper will take the color of the light.</param>
    public PointLightHelper(PointLight light = null!, double sphereSize = 1, string color = null!) : this()
    {
        Light = light ?? new PointLight();
        SphereSize = sphereSize;
        Color = color;
    }

    /// <summary>
    ///  The light to be visualized. Must be already added to the scene.
    /// </summary>
    public PointLight Light { get; set; } = new PointLight();

    /// <summary>
    /// The size of the sphere helper. Default is 1.
    /// </summary>
    public double SphereSize { get; set; } = 1;

    /// <summary>
    /// The size of the sphere helper. If color is not set, the helper will take the color of the light.
    /// </summary>
    public string Color { get; set; } = null!;
}