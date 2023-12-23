namespace HomagGroup.Blazor3D.Maths;

/// <summary>
/// <para>Class representing a 2D vector. A 2D vector is an ordered pair of numbers (labeled x and y), which can be used to represent a number of things, such as point in 2D space, direction or any ordered pair of numbers.</para>
/// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/math/Vector2">Vector2</a></para>
/// </summary>
public sealed class Vector2
{
    /// <summary>
    /// Default constructor.
    /// </summary>
    public Vector2()
    {
    }

    /// <summary>
    /// Constructor with parameters.
    /// </summary>
    /// <param name="x">double X value of this vector. Default is 0.</param>
    /// <param name="y">double Y value of this vector. Default is 0.</param>
    public Vector2(double x, double y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// double X value of this vector. Default is 0.
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// double Y value of this vector. Default is 0.
    /// </summary>
    public double Y { get; set; }
}