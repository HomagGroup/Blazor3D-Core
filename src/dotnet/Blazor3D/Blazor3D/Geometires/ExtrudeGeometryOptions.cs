namespace HomagGroup.Blazor3D.Geometires
{
    /// <summary>
    /// Options used for extrusion.
    /// </summary>
    public class ExtrudeGeometryOptions
    {
        /// <summary>
        /// Extrusion depth. Default is 1.
        /// </summary>
        public double Depth { get; set; } = 1;

        /// <summary>
        /// Apply beveling to the shape. Default is true.
        /// </summary>
        public bool BevelEnabled { get; set; } = true;
    }
}
