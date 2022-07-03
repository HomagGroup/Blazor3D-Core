
namespace Blazor3D.Materials
{
    public class MeshStandardMaterial : Material
    {
        public MeshStandardMaterial() : base("MeshStandardMaterial")
        {

        }
        public string Color { get; set; } = "blue";
    }
}
