using Blazor3D.Maths;

namespace Blazor3D.Core
{
    /// <summary>
    /// <para>It's a base abstract class for most objects in <strong>Blazor3D</strong>. 
    /// It provides functionality for manipulating objects in 3D space.</para>
    ///<para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/core/Object3D">Object3D</a></para>
    /// </summary>
    public abstract class Object3D
    {
        protected Object3D(string type)
        {
            Type = type;
        }

        /// <summary>
        /// Represents the object's local <see cref="Vector3"/> position. Default is (0, 0, 0).
        /// </summary>
        public Vector3 Position { get; set; } = new Vector3();

        /// <summary>
        /// Object's local <see cref="Euler"/> rotation, in radians.
        /// </summary>
        public Euler Rotation { get; set; } = new Euler();

        /// <summary>
        /// Represents the object's local <see cref="Vector3"/> scale. Default is (1, 1, 1).
        /// </summary>
        public Vector3 Scale { get; set; } = new Vector3(1, 1, 1);

        public string Type { get; } = "Object3D";

        /// <summary>
        /// Optional name of the object. Default is an empty string. It has not to be unique. 
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <a href="https://en.wikipedia.org/wiki/Universally_unique_identifier" target="_blank">Universal unique identifier</a> of this object instance. It's automatically assigned Guid, so it shouldn't be edited.
        /// </summary>
        public Guid Uuid { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Collection of <see cref="Object3D"/> child objects.
        /// </summary>
        public List<Object3D> Children { get; } = new List<Object3D>();

        /// <summary>
        /// Adds a child <see cref="Object3D"/> object to the Children collection.
        /// </summary>
        /// <param name="child">Child <see cref="Object3D"/> to be added.</param>
        public void Add(Object3D child)
        {
            Children.Add(child);
        }
    }
}
