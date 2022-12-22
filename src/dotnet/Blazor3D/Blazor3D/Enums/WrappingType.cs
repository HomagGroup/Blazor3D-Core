namespace Blazor3D.Enums
{
    /// <summary>
    /// These define the texture's WrapS and WrapT properties, which define horizontal and vertical texture wrapping.
    /// </summary>
    public enum WrappingType
    {
        /// <summary>
        /// The texture will simply repeat to infinity
        /// </summary>
        RepeatWrapping = 1000,
        /// <summary>
        /// The last pixel of the texture stretches to the edge of the mesh.
        /// </summary>
        ClampToEdgeWrapping = 1001,
        /// <summary>
        /// The texture will repeats to infinity, mirroring on each repeat.
        /// </summary>
        MirroredRepeatWrapping = 1002
    }
}
