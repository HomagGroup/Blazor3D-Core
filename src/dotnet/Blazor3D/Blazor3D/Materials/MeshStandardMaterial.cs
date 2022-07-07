
namespace Blazor3D.Materials
{
    public sealed class MeshStandardMaterial : Material
    {
        public MeshStandardMaterial() : base("MeshStandardMaterial")
        {

        }
        public string Color { get; set; } = "grey";
    }
}
