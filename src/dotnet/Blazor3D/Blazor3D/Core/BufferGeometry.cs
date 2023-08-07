namespace HomagGroup.Blazor3D.Core
{
    /// <summary>
    /// <para>A representation of geometry for mesh, line, or point. 
    /// Includes vertex positions, face indices, normals, colors, UVs, and custom attributes within buffers, 
    /// reducing the cost of passing all this data to the GPU.</para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/core/BufferGeometry">BufferGeometry</a></para>
    /// </summary>
    public abstract class BufferGeometry
    {
        protected BufferGeometry(string type)
        {
            Type = type;
        }

        /// <summary>
        /// Optional name of the object. Default is an empty string. It has not to be unique. 
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// <a href="https://en.wikipedia.org/wiki/Universally_unique_identifier" target="_blank">Universal unique identifier</a> of this object instance. It's automatically assigned Guid, so it shouldn't be edited.
        /// </summary>
        public Guid Uuid { get; set; } = Guid.NewGuid();

        public string Type { get; } = "Geometry";
    }
}
