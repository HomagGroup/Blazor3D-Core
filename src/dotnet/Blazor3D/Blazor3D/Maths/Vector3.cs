namespace Blazor3D.Maths
{
    /// <summary>
    /// Vector doc
    /// </summary>
    public class Vector3
    {
        /// <summary>
        /// 
        /// </summary>
        public Vector3()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// The X coordinate
        /// </summary>
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }
}
