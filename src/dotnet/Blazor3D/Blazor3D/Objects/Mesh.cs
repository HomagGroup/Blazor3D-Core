using Blazor3D.Core;
using Blazor3D.Geometires;
using Blazor3D.Materials;

namespace Blazor3D.Objects
{
    public class Mesh : Object3D
    {
        public Mesh() : base("Mesh")
        {

        }
        public Material material { get; set; } = new MeshStandardMaterial();
        public BufferGeometry Geometry { get; set; } = new BoxGeometry();
    }
}
