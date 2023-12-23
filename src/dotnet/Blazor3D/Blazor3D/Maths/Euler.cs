namespace HomagGroup.Blazor3D.Maths;

/// <summary>
/// <para>Representing Euler Angles.
/// Euler angles describe a rotational transformation by rotating an object on its various axes in specified amounts per axis, and a specified axis order.
/// Iterating through a Euler instance will yield its components (x, y, z, order) in the corresponding order.</para>
/// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/math/Euler">Euler</a></para>
/// </summary>
public sealed class Euler
{
    /// <summary>
    /// The double angle of the X axis in radians. Default is 0. Optional.
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// The double angle of the Y axis in radians. Default is 0. Optional.
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// The double angle of the Z axis in radians. Default is 0. Optional.
    /// </summary>
    public double Z { get; set; }

    /// <summary>
    /// String representing the order that the rotations are applied. Default is 'XYZ'. Must be upper case.
    /// </summary>
    public string Order { get; set; } = "XYZ";
}