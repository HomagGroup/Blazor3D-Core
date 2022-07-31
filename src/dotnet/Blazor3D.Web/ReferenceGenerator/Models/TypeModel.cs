namespace ReferenceGenerator.Models
{
    public class TypeModel : BaseModel
    {
        public TypeModel() : base("Type")
        {
        }

        public List<BaseModel> Methods { get; set; } = new List<BaseModel>();
        public List<BaseModel> Constructors { get; set; } = new List<BaseModel>();
        public List<BaseModel> Properties { get; set; } = new List<BaseModel>();
        public List<BaseModel> Fields { get; set; } = new List<BaseModel>();

        public List<BaseModel> Events { get; set; } = new List<BaseModel>();

        public override void Parse()
        {
            base.Parse();


            foreach (var method in Constructors)
            {
                method.Parse();
            }
            foreach (var method in Methods)
            {
                method.Parse();
            }
            foreach (var prop in Properties)
            {
                prop.Parse();
            }
            foreach (var field in Fields)
            {
                field.Parse();
            }
            foreach (var ev in Events)
            {
                ev.Parse();
            }
        }
    }
}
