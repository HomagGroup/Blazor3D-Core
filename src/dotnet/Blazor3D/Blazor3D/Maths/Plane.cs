namespace Blazor3D.Maths
{
    /// <summary>
    /// <para>A two dimensional surface that extends infinitely in 3d space, represented in Hessian normal form by a unit length normal vector and a constant.</para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/math/Plane">Plane</a></para>
    /// </summary>
    public sealed class Plane
    {
        public Plane()
        {

        }

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="normal">A unit length Vector3 defining the normal of the plane. Default is (1, 0, 0).</param>
        /// <param name="constant">The signed distance from the origin to the plane. Default is 0.</param>
        public Plane(Vector3 normal = null!, double constant = 0)
        {
            Normal = normal ?? new Vector3(1, 0, 0);
            Constant = constant;
        }

        /// <summary>
        /// A unit length Vector3 defining the normal of the plane. Default is (1, 0, 0).
        /// </summary>
        public Vector3 Normal { get; set; } = new Vector3(1, 0, 0);

        /// <summary>
        /// The signed distance from the origin to the plane. Default is 0.
        /// </summary>
        public double Constant { get; set; } = 0;
    }
}
