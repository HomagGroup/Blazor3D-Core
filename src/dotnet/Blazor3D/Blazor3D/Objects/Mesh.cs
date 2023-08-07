using HomagGroup.Blazor3D.Core;
using HomagGroup.Blazor3D.Geometires;
using HomagGroup.Blazor3D.Materials;

namespace HomagGroup.Blazor3D.Objects
{
    /// <summary>
    /// <para>Class representing triangulated polygon mesh based objects. Also serves as a base for other classes.</para>
    /// <para>This object inherits from <see cref="Object3D"/></para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/objects/Mesh">Mesh</a></para>
    /// </summary>
    /// <inheritdoc><see cref="Object3D"/></inheritdoc>
    public class Mesh : Object3D
    {
        public Mesh() : base("Mesh")
        {

        }

        protected Mesh(string type) : base(type)
        {

        }

        //TODO: make Array of materials
        /// <summary>
        /// <para>Collection of <see cref="HomagGroup.Blazor3D.Materials.Material"/> (or derived classes) materials, defining the object's appearance.</para>
        /// </summary>
        public Material Material { get; set; } = new MeshStandardMaterial();

        /// <summary>
        /// <para>An instance of <see cref="BufferGeometry"/> (or derived classes), defining the object's structure.</para>
        /// </summary>
        public BufferGeometry Geometry { get; set; } = new BoxGeometry();

        /// <summary>
        /// Material <see cref="LineBasicMaterial"/> to draw edges with EdgesGeometry. If not specified, no edges will be drawn.
        /// </summary>
        public LineBasicMaterial EdgesMaterial { get; set; } = null!;
    }
}
