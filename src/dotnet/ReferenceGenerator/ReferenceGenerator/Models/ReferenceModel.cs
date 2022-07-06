namespace ReferenceGenerator.Models
{
    public class ReferenceModel : BaseModel
    {
        public AssemblyModel Assembly { get; set; } = null!;
        public List<TypeModel> Types { get; set; } = new List<TypeModel>();
    }
}
