namespace Blazor3D.Maths
{
    /// <summary>
    /// <p>Class representing a 3D vector. A 3D vector is an ordered triplet of numbers (labeled x, y, and z),
    /// which can be used to represent a number of things, such as:</p>
    /// <ul>
    /// <li>A point in 3D space.</li>
    /// <li>A direction, length or scale in 3D space. </li>
    /// <li>Any arbitrary ordered triplet of numbers.</li>
    /// </ul>
    /// <p>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/math/Vector3">Vector3</a></p>
    /// </summary>
    public class Vector3
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
        /// <param name="x">Float X value of this vector. Default is 0.</param>
        /// <param name="y">Float Y value of this vector. Default is 0.</param>
        /// <param name="z">Float Z value of this vector. Default is 0.</param>
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Float X value of this vector. Default is 0.
        /// </summary>
        public float X { get; set; }

        /// <summary>
        /// Float Y value of this vector. Default is 0.
        /// </summary>
        public float Y { get; set; }

        /// <summary>
        /// Float Z value of this vector. Default is 0.
        /// </summary>
        public float Z { get; set; }
    }
}
