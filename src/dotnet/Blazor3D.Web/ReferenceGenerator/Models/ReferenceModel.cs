namespace ReferenceGenerator.Models
{
    public class ReferenceModel : BaseModel
    {
        public ReferenceModel() : base("Reference")
        {
        }


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
