namespace Blazor3D.Maths
{
    /// <summary>
    /// Vector doc
    /// </summary>
    public class Vector3
    {
        /// <summary>
        /// ctor
        /// </summary>
        public Vector3()
        {

        }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        /// <param name="z">z</param>
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }
}
