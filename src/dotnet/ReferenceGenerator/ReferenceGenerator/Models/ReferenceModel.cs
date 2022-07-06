namespace ReferenceGenerator.Models
{
    public class ReferenceModel : BaseModel
    {
        public AssemblyModel Assembly { get; set; } = null!;
        public List<TypeModel> Types { get; set; } = new List<TypeModel>();

        public override void Parse()
        {
            base.Parse();
            foreach (var item in Types)
            {
                item.Parse();
            }
        }
    }
}
