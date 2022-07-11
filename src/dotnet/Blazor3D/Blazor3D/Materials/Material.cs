namespace Blazor3D.Materials
{
    /// <summary>
    /// <p>Abstract base class for materials.</p>
    /// <p>Materials describe the appearance of objects. They are defined in a mostly renderer-independent way, so you don't have to rewrite materials if you decide to use a different renderer.</p>
    /// <p>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/materials/Material">Material</a></p>
    /// </summary>
    public abstract class Material
    {
        protected Material(string type)
        {
            Type = type;
        }

        public string Type { get; } = "Material";

        /// <summary>
        /// Optional name of the object. Default is an empty string. It has not to be unique. 
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <a href="https://en.wikipedia.org/wiki/Universally_unique_identifier" target="_blank">Universal unique identifier</a> of this object instance. It's automatically assigned Guid, so it shouldn't be edited.
        /// </summary>
        public Guid Uuid { get; set; } = Guid.NewGuid();
    }
}
