using Blazor3D.Core;
using Blazor3D.Geometires;
using Blazor3D.Materials;

namespace Blazor3D.Objects
{
    /// <summary>
    /// <p>Class representing triangulated polygon mesh based objects. Also serves as a base for other classes.</p>
    /// <p>This object inherits from <see cref="Object3D"/></p>
    /// <p>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/objects/Mesh">Mesh</a></p>
    /// </summary>
    /// <inheritdoc><see cref="Object3D"/></inheritdoc>
    public class Mesh : Object3D
    {
        public Mesh() : base("Mesh")
        {

        }
        //TODO: make Array of materials
        /// <summary>
        /// <p>Collection of <see cref="Blazor3D.Materials.Material"/> (or derived classes) materials, defining the object's appearance.</p>
        /// </summary>
        public Material Material { get; set; } = new MeshStandardMaterial();

        /// <summary>
        /// <p>An instance of <see cref="BufferGeometry"/> (or derived classes), defining the object's structure.</p>
        /// </summary>
        public BufferGeometry Geometry { get; set; } = new BoxGeometry();
    }
}
