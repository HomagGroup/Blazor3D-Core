namespace HomagGroup.Blazor3D.Maths;

/// <summary>
/// <para>Class representing a 3D vector. A 3D vector is an ordered triplet of numbers (labeled x, y, and z),
/// which can be used to represent a number of things, such as:</para>
/// <ul>
/// <li>A point in 3D space.</li>
/// <li>A direction, length or scale in 3D space. </li>
/// <li>Any arbitrary ordered triplet of numbers.</li>
/// </ul>
/// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/math/Vector3">Vector3</a></para>
/// </summary>
public sealed class Vector3
{
    /// <summary>
    /// Default constructor.
    /// </summary>
    public Vector3()
    {

        }

    /// <summary>
    /// Constructor with parameters.
    /// </summary>
    /// <param name="x">double X value of this vector. Default is 0.</param>
    /// <param name="y">double Y value of this vector. Default is 0.</param>
    /// <param name="z">double Z value of this vector. Default is 0.</param>
    public Vector3(double x, double y, double z)
    {
            X = x;
            Y = y;
            Z = z;
        }

    /// <summary>
    /// double X value of this vector. Default is 0.
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// double Y value of this vector. Default is 0.
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// double Z value of this vector. Default is 0.
    /// </summary>
    public double Z { get; set; }
}