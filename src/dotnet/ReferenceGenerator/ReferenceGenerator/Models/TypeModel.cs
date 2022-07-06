namespace ReferenceGenerator.Models
{
    public class TypeModel : BaseModel
    {
        public List<MethodModel> Methods { get; set; } = new List<MethodModel>();
        public List<MethodModel> Constructors { get; set; } = new List<MethodModel>();
        public List<PropertyModel> Properties { get; set; } = new List<PropertyModel>();
        public List<FieldModel> Fields { get; set; } = new List<FieldModel>();

        public override void Parse()
        {
            base.Parse();
           

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
        }
    }
}
